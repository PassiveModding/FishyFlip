// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    public partial class ViewDetached : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDetached"/> class.
        /// </summary>
        public ViewDetached(FishyFlip.Models.ATUri? uri = default, bool? detached = default)
        {
            this.Uri = uri;
            this.Detached = detached;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDetached"/> class.
        /// </summary>
        public ViewDetached()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDetached"/> class.
        /// </summary>
        public ViewDetached(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["detached"] is not null) this.Detached = obj["detached"].AsBoolean();
        }

        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("detached")]
        [JsonRequired]
        public bool? Detached { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.record#viewDetached";

        public const string RecordType = "app.bsky.embed.record#viewDetached";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Embed.ViewDetached>(this, (JsonTypeInfo<App.Bsky.Embed.ViewDetached>)SourceGenerationContext.Default.AppBskyEmbedViewDetached)!;
        }

        public static ViewDetached FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Embed.ViewDetached>(json, (JsonTypeInfo<App.Bsky.Embed.ViewDetached>)SourceGenerationContext.Default.AppBskyEmbedViewDetached)!;
        }
    }
}

