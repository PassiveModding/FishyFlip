using System.Net.WebSockets;
using System.Text;
using System.Formats.Cbor;
using PeterO.Cbor;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Security.Cryptography;
using Ipfs;

public class WebSocketClient
{
    private const int ReceiveBufferSize = 32768;

    public static async Task Connect(string serverUri)
    {
        using (ClientWebSocket webSocket = new ClientWebSocket())
        {
            try
            {
                await webSocket.ConnectAsync(new Uri(serverUri), CancellationToken.None);
                Console.WriteLine("Connected to the server.");

                // Start receiving messages in a separate task
                Task receiveTask = ReceiveMessages(webSocket);

                // Send messages to the server
                await SendMessages(webSocket);

                // Wait for the receive task to complete
                await receiveTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    private static async Task SendMessages(ClientWebSocket webSocket)
    {
        //while (webSocket.State == WebSocketState.Open)
        //{
        //    Console.Write("Enter a message (or 'exit' to close the connection): ");
        //    string message = Console.ReadLine();

        //    if (message.ToLower() == "exit")
        //    {
        //        // Close the WebSocket connection
        //        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed by the client.", CancellationToken.None);
        //        Console.WriteLine("Connection closed.");
        //        break;
        //    }

        //    byte[] messageBytes = Encoding.UTF8.GetBytes(message);
        //    await webSocket.SendAsync(new ArraySegment<byte>(messageBytes), WebSocketMessageType.Text, true, CancellationToken.None);
        //}
    }

    private static async Task ReceiveMessages(ClientWebSocket webSocket)
    {
        var jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault,
            Converters =
            {
                new BlocksConverter()
            }
        };

        var tm = new CBORTypeMapper().AddConverter(
           typeof(FrameBody),
           new FrameBodyConverter());

        byte[] receiveBuffer = new byte[ReceiveBufferSize];
        while (webSocket.State == WebSocketState.Open)
        {
            WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);
            
            if (result.MessageType == WebSocketMessageType.Binary && result.EndOfMessage == true)
            {
                using var memoryStream = new MemoryStream(receiveBuffer, 0, result.Count);
                var objects = CBORObject.ReadSequence(memoryStream);
                Console.WriteLine(objects.Length);

                Console.WriteLine(objects[0].ToJSONString());

                var test = objects[1].ToObject<FrameBody>(tm);
                var car = CarDecoder.DecodeCar(test.Blocks);

                var itemTest = car.FirstOrDefault();
                var val2 = CBORObject.Read(new MemoryStream(itemTest.Value.ToArray()));
                var testingJson = val2.ToJSONString();
                var typeName = val2["$type"]?.AsString() ?? string.Empty;
                if (typeName == "app.bsky.feed.post")
                {
                    //var post = val2.ToObject<Post>(tm);
                    var embed = val2["embed"];
                    if (embed is not null)
                    {
                        var embedType = embed["$type"].AsString();
                        if (embedType == "app.bsky.embed.images")
                        {
                            var images = embed["images"];
                            var image = images[0];
                            var refId = Cid.Read(image["image"]["ref"].GetByteString());
                           // File.WriteAllBytes("test.jpg", refId);
                        }
                        else if (embedType == "app.bsky.embed.record")
                        {

                        }
                        else if (embedType == "app.bsky.embed.recordWithMedia")
                        {

                        }
                        else
                        {

                        }
                    }

                    Console.WriteLine(val2.ToJSONString());
                }

                //var obj = CBORObject.Read(new MemoryStream(car.Value.ToArray())).ToJSONString();
                //Console.WriteLine(obj);
                foreach (var item in car)
                {
                    Console.WriteLine(item.Key);
                    var val = CBORObject.Read(new MemoryStream(item.Value.ToArray()));
                    var obj = CBORObject.Read(new MemoryStream(item.Value.ToArray())).ToJSONString();
                    Console.WriteLine(obj);
                }
            }

            //    string message = Encoding.UTF8.GetString(receiveBuffer, 0, result.Count);
            //Console.WriteLine($"Received message: {message}");
        }
    }
}

public class Post
{
    public string Text { get; set; }

    public string Type { get; set; }
}

public class Block
{
    public string Cid { get; set; }
    public string Data { get; set; }
}

public static class CarDecoder
{
    private const int _cidV1BytesLength = 36;

    public static Dictionary<string, byte[]> DecodeCar(byte[] bytes)
    {
        var blocks = new Dictionary<string, byte[]>();

        int bytesLength = bytes.Length;
        var header = DecodeReader(bytes);

        int start = header.Length + header.Value;

        while (start < bytesLength)
        {
            var body = DecodeReader(bytes[start..]);
            start += body.Length;

            var cidBytes = bytes[start..(start + _cidV1BytesLength)];
            var cid = Cid.Read(cidBytes);

            start += _cidV1BytesLength;
            var blockData = bytes[start..(start + body.Value - _cidV1BytesLength)];
            blocks[cid] = blockData;
            start += body.Value - _cidV1BytesLength;
        }

        return blocks;
    }

    private static _DecodedBlock DecodeReader(byte[] bytes)
    {
        var a = new List<byte>();

        int i = 0;
        while (true)
        {
            byte b = bytes[i];

            i++;
            a.Add(b);
            if ((b & 0x80) == 0)
            {
                break;
            }
        }

        return new _DecodedBlock(Decode(a), a.Count);
    }

    private class _DecodedBlock
    {
        public _DecodedBlock(int value, int length)
        {
            Value = value;
            Length = length;
        }

        public int Value { get; }
        public int Length { get; }
    }

    private static int Decode(List<byte> b)
    {
        int r = 0;
        for (int i = 0; i < b.Count; i++)
        {
            int e = b[i];
            r = r + ((e & 0x7F) << (i * 7));
        }

        return r;
    }

    public delegate void ProgressStatus(ProgressStatusEvent e);

    public class ProgressStatusEvent
    {
        public ProgressStatusEvent(int bytesLength, int start)
        {
            BytesLength = bytesLength;
            Start = start;
        }

        public int BytesLength { get; }
        public int Start { get; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //MemoryStream stream = new MemoryStream();
        //var writer = new StreamWriter(stream);
        //writer.Write("{ref: \"AAFVEiAM-tGPQ6vplAtXpRTynsf4i-3yU14tPnGN-qZcumoGcg\"}");
        //writer.Flush();
        //var testing = CBORObject.ReadJSON(stream);
        //var byteArray = testing.GetByteString();
        // var test = CBORObject.De("AAFVEiAM-tGPQ6vplAtXpRTynsf4i-3yU14tPnGN-qZcumoGcg");
        //var test = Cid.Decode("AAFVEiAM-tGPQ6vplAtXpRTynsf4i-3yU14tPnGN-qZcumoGcg");
        string serverUri = "wss://bsky.social/xrpc/com.atproto.sync.subscribeRepos";
        WebSocketClient.Connect(serverUri).Wait();
    }
}

public class FrameHeader
{
    [System.Text.Json.Serialization.JsonPropertyName("op")]
    public int Operation { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("t")]
    public string Type { get; set; }
}

public class FrameBody
{
    public Ops[] Ops { get; set; }

    public int Seq { get; set; }

    public string Prev { get; set; }

    public string Repo { get; set; }

    public DateTime Time { get; set; }

    public byte[] Blocks { get; set; }

    public string Commit { get; set; }

    public bool Rebase { get; set; }

    public bool TooBig { get; set; }
}

public class FrameBodyConverter : ICBORToFromConverter<FrameBody>
{
    public CBORObject ToCBORObject(FrameBody cpod)
    {
        throw new Exception("The method or operation is not implemented.");
    }
    public FrameBody FromCBORObject(CBORObject obj)
    {
        if (obj.Type != CBORType.Map)
        {
            throw new CBORException();
        }
        var ret = new FrameBody();
        ret.Seq = obj["seq"].AsInt32();
        ret.Blocks = obj["blocks"]?.GetByteString();
        //ret.Bb = obj[1].AsString();
        //ret.Cc = obj[2].AsString();
        return ret;
    }
}

public class Ops
{
    public string Cid { get; set; }

    public string Path { get; set; }

    public string Action { get; set; }
}

public class ErrorBody
{
    [System.Text.Json.Serialization.JsonPropertyName("error")]
    public string Error { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("message")]
    public string Message { get; set; }
}

public class BlocksConverter : JsonConverter<Block[]>
{
    public override Block[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException("Expected string value.");
        }
        var car = CarDecoder.DecodeCar(Encoding.UTF8.GetBytes(reader.GetString()));
        return car.Select(x => new Block { Cid = x.Key, Data = Encoding.UTF8.GetString(x.Value.ToArray()) }).ToArray();
        //var test = Convert.FromBase64String(base64String.Trim());
        //return Convert.FromBase64String(base64String);
    }

    public override void Write(Utf8JsonWriter writer, Block[] value, JsonSerializerOptions options)
    {
    }
}