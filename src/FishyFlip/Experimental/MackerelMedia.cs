// <copyright file="MackerelMedia.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlip.Models.Experimental.MackerelMedia;

namespace FishyFlip.Experimental;

/// <summary>
/// Mackerel Media.
/// </summary>
public sealed class MackerelMedia
{
    private ATProtocol proto;

    /// <summary>
    /// Initializes a new instance of the <see cref="MackerelMedia"/> class.
    /// </summary>
    /// <param name="proto"><see cref="ATProtocol"/>.</param>
    internal MackerelMedia(ATProtocol proto)
    {
        this.proto = proto;
    }

    private ATProtocolOptions Options => this.proto.Options;

    /// <summary>
    /// Asynchronously uploads a media file to the repository.
    /// </summary>
    /// <param name="mp4File">The path to the MP4 file to be uploaded.</param>
    /// <param name="cancellationToken">An optional cancellation token. Defaults to None.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a Result of type RecordRef.</returns>
    public async Task<Result<RecordRef>> UploadMediaAsync(string mp4File, CancellationToken cancellationToken = default)
    {
        using var streamContent = new StreamContent(File.OpenRead(mp4File));
        streamContent.Headers.ContentType = new MediaTypeHeaderValue("video/mp4");

        var (blobResult, blobError) = await this.proto.Repo.UploadBlobAsync(streamContent, CancellationToken.None);

        if (blobError is not null)
        {
            return blobError!;
        }

        var media = blobResult!.Blob.ToMedia();
        var mediaRecord = new CreateMediaRecord(Constants.Experimental.MackerelMediaTypes.Media, this.proto.SessionManager!.Session!.Did.ToString()!, media);
        return await this.proto.Repo.CreateRecord<CreateMediaRecord, RecordRef>(mediaRecord, this.Options.SourceGenerationContext.CreateMediaRecord, this.Options.SourceGenerationContext.RecordRef, cancellationToken);
    }

    /// <summary>
    /// Asynchronously list the media from the user.
    /// </summary>
    /// <param name="userDid">User repo.</param>
    /// <param name="limit">The maximum number of records to retrieve. Default is 50.</param>
    /// <param name="cursor">Optional. A string that represents the starting point for the next set of records.</param>
    /// <param name="reverse">Optional. A boolean that indicates whether the records should be retrieved in reverse order.</param>
    /// <param name="cancellationToken">Optional. A CancellationToken that can be used to cancel the operation.</param>
    /// <returns>A Task that represents the asynchronous operation. The task result contains a Result object with a list of records, or null if no records were found.</returns>
    /// <returns>A list of author posts.</returns>
    public async Task<Result<ListRecords<Media>?>> GetMediaFromUserAsync(
        ATIdentifier userDid,
        int limit = 50,
        string? cursor = default,
        bool? reverse = default,
        CancellationToken cancellationToken = default)
    {
        var (protocol, did, usingCurrentProto) = await this.proto.GenerateClientFromATIdentifierAsync(userDid, cancellationToken, this.Options.Logger);

        string url = $"{Constants.Urls.ATProtoRepo.ListRecords}?collection={Constants.Experimental.MackerelMediaTypes.Media}&repo={userDid}&limit={limit}";
        if (cursor is not null)
        {
            url += $"&cursor={cursor}";
        }

        if (reverse is not null)
        {
            url += $"&reverse={reverse}";
        }

        try
        {
            return await protocol.Client.Get<ListRecords<Media>>(url, this.Options.SourceGenerationContext.ListRecordsMedia, this.Options.JsonSerializerOptions, cancellationToken, this.Options.Logger);
        }
        finally
        {
            if (!usingCurrentProto)
            {
                protocol.Dispose();
            }
        }
    }
}