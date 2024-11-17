// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class LikeDef : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeDef"/> class.
        /// </summary>
        public LikeDef()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LikeDef"/> class.
        /// </summary>
        public LikeDef(CBORObject obj)
        {
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
            if (obj["actor"] is not null) this.Actor = new App.Bsky.Actor.ProfileView(obj["actor"]);
        }

        [JsonPropertyName("indexedAt")]
        [JsonRequired]
        public DateTime? IndexedAt { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonRequired]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("actor")]
        [JsonRequired]
        public App.Bsky.Actor.ProfileView? Actor { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.getLikes#like";

        public const string RecordType = "app.bsky.feed.getLikes#like";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.LikeDef>(this, (JsonTypeInfo<App.Bsky.Feed.LikeDef>)SourceGenerationContext.Default.AppBskyFeedLikeDef)!;
        }

        public static LikeDef FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.LikeDef>(json, (JsonTypeInfo<App.Bsky.Feed.LikeDef>)SourceGenerationContext.Default.AppBskyFeedLikeDef)!;
        }
    }
}
