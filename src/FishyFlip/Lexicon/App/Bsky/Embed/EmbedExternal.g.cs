// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    /// <summary>
    /// A representation of some externally linked content (eg, a URL and 'card'), embedded in a Bluesky record (eg, a post).
    /// </summary>
    public partial class EmbedExternal : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedExternal"/> class.
        /// </summary>
        /// <param name="external">
        /// app.bsky.embed.defs#external
        /// </param>
        public EmbedExternal(App.Bsky.Embed.External? external = default)
        {
            this.External = external;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedExternal"/> class.
        /// </summary>
        public EmbedExternal()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedExternal"/> class.
        /// </summary>
        public EmbedExternal(CBORObject obj)
        {
            if (obj["external"] is not null) this.External = new App.Bsky.Embed.External(obj["external"]);
        }

        /// <summary>
        /// Gets or sets the external.
        /// app.bsky.embed.defs#external
        /// </summary>
        [JsonPropertyName("external")]
        [JsonRequired]
        public App.Bsky.Embed.External? External { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.external";

        public const string RecordType = "app.bsky.embed.external";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Embed.EmbedExternal>(this, (JsonTypeInfo<App.Bsky.Embed.EmbedExternal>)SourceGenerationContext.Default.AppBskyEmbedEmbedExternal)!;
        }

        public static EmbedExternal FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Embed.EmbedExternal>(json, (JsonTypeInfo<App.Bsky.Embed.EmbedExternal>)SourceGenerationContext.Default.AppBskyEmbedEmbedExternal)!;
        }
    }
}
