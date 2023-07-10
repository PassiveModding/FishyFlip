using System.Net.WebSockets;
using FishyFlip.Events;
using FishyFlip.Models;
using FishyFlip.Tools.Cbor;
using Microsoft.Extensions.Logging;
using PeterO.Cbor;

namespace FishyFlip.Tools;

internal class ATWebSocketClient : IDisposable
{
    private const int ReceiveBufferSize = 32768;
    private ClientWebSocket client;
    private ATProtocolOptions options;
    private CancellationToken? token;
    private CBORTypeMapper mapper;
    private CarDecoder decoder;
    private bool disposedValue;
    private Task? recieveTask;
    private ILogger? logger;

    public ATWebSocketClient(ATProtocolOptions options, ILogger? logger = default)
    {
        this.logger = logger;
        this.options = options;
        this.client = new ClientWebSocket();
        this.mapper = new CBORTypeMapper()
            .AddConverter(typeof(FrameBody), new FrameBodyConverter())
            .AddConverter(typeof(FrameHeader), new FrameHeaderConverter());
        this.decoder = new CarDecoder();
        this.decoder.ProgressStatus += this.Decoder_ProgressStatus;
    }

    public async Task ConnectAsync(CancellationToken? token = default)
    {
        if (this.client.State == WebSocketState.Open)
        {
            return;
        }

        var baselineUrl = new Uri($"{this.options.Url}");
        var endToken = token ?? CancellationToken.None;
        await this.client.ConnectAsync(new Uri($"wss://{baselineUrl.Host}{Constants.Urls.AtProtoSync.SubscribeRepos}"), endToken);
        this.logger?.LogInformation($"WSS: Connected to {baselineUrl}");
        this.recieveTask = Task.Run(() => this.ReceiveMessages(this.client, endToken));
    }

    public Task CloseAsync(WebSocketCloseStatus status = WebSocketCloseStatus.NormalClosure, string disconnectReason = "Client disconnecting", CancellationToken? token = default)
    {
        var endToken = token ?? CancellationToken.None;
        this.logger?.LogInformation($"WSS: Disconnecting");
        return this.client.CloseAsync(status, disconnectReason, endToken);
    }

    private async Task ReceiveMessages(ClientWebSocket webSocket, CancellationToken token)
    {
        byte[] receiveBuffer = new byte[ReceiveBufferSize];
        while (webSocket.State == WebSocketState.Open)
        {
            WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), token);

            if (result.MessageType == WebSocketMessageType.Binary && result.EndOfMessage == true)
            {
                using var memoryStream = new MemoryStream(receiveBuffer, 0, result.Count);
                var objects = CBORObject.ReadSequence(memoryStream);
                if (objects.Length == 2)
                {
                    try
                    {
                        var frameHeader = objects[0].ToObject<FrameHeader>(this.mapper);
                        if (frameHeader.Operation == 1)
                        {
                            var frameBody = objects[1].ToObject<FrameBody>(this.mapper);
                            Task.Run(() => this.decoder.DecodeCar(frameBody.Blocks));
                        }
                        else
                        {
                            // TODO: Add Frame Error Handling.
                            this.logger?.LogWarning($"WSS: Unexpected operation {frameHeader.Operation}");
                        }
                    }
                    catch (Exception ex)
                    {
                        this.logger?.LogError(ex, "Error parsing WSS messages");
                        await this.CloseAsync(WebSocketCloseStatus.InternalServerError, "Error parsing WSS messages");
                    }
                }
                else
                {
                    this.logger?.LogWarning($"WSS: Unexpected message length {objects.Length}");
                }
            }
        }
    }

    private void Decoder_ProgressStatus(object? sender, CreateCarEvent e)
    {
        var obj = CBORObject.Read(new MemoryStream(e.Data)).ToJSONString();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                this.decoder.ProgressStatus -= this.Decoder_ProgressStatus;
                this.client.Dispose();
            }

            disposedValue = true;
        }
    }


    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
