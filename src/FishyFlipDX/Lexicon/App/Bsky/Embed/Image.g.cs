// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    public partial class Image : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        public Image()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        public Image(CBORObject obj)
        {
            if (obj["image"] is not null) this.ImageValue = new FishyFlip.Models.Blob(obj["image"]);
            if (obj["alt"] is not null) this.Alt = obj["alt"].AsString();
            if (obj["aspectRatio"] is not null) this.AspectRatio = new App.Bsky.Embed.AspectRatio(obj["aspectRatio"]);
        }

        [JsonPropertyName("image")]
        [JsonRequired]
        public Blob? ImageValue { get; set; }

        /// <summary>
        /// Alt text description of the image, for accessibility.
        /// </summary>
        [JsonPropertyName("alt")]
        [JsonRequired]
        public string? Alt { get; set; }

        [JsonPropertyName("aspectRatio")]
        public App.Bsky.Embed.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.images#image";

        public const string RecordType = "app.bsky.embed.images#image";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Embed.Image>(this, (JsonTypeInfo<App.Bsky.Embed.Image>)SourceGenerationContext.Default.AppBskyEmbedImage)!;
        }

        public static Image FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Embed.Image>(json, (JsonTypeInfo<App.Bsky.Embed.Image>)SourceGenerationContext.Default.AppBskyEmbedImage)!;
        }
    }
}
