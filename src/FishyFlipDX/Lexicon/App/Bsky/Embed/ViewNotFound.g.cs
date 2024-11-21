// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    public partial class ViewNotFound : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewNotFound"/> class.
        /// </summary>
        public ViewNotFound(FishyFlip.Models.ATUri? uri = default, bool? notFound = default)
        {
            this.Uri = uri;
            this.NotFound = notFound;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewNotFound"/> class.
        /// </summary>
        public ViewNotFound()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewNotFound"/> class.
        /// </summary>
        public ViewNotFound(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["notFound"] is not null) this.NotFound = obj["notFound"].AsBoolean();
        }

        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("notFound")]
        [JsonRequired]
        public bool? NotFound { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.record#viewNotFound";

        public const string RecordType = "app.bsky.embed.record#viewNotFound";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Embed.ViewNotFound>(this, (JsonTypeInfo<App.Bsky.Embed.ViewNotFound>)SourceGenerationContext.Default.AppBskyEmbedViewNotFound)!;
        }

        public static ViewNotFound FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Embed.ViewNotFound>(json, (JsonTypeInfo<App.Bsky.Embed.ViewNotFound>)SourceGenerationContext.Default.AppBskyEmbedViewNotFound)!;
        }
    }
}

