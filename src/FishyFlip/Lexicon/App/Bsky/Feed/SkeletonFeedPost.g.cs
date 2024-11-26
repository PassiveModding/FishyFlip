// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class SkeletonFeedPost : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonFeedPost"/> class.
        /// </summary>
        /// <param name="post"></param>
        /// <param name="reason">
        /// Union Types:
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.SkeletonReasonRepost"/> (app.bsky.feed.defs#skeletonReasonRepost)
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.SkeletonReasonPin"/> (app.bsky.feed.defs#skeletonReasonPin)
        /// </param>
        /// <param name="feedContext">Context that will be passed through to client and may be passed to feed generator back alongside interactions.</param>
        public SkeletonFeedPost(FishyFlip.Models.ATUri? post = default, ATObject? reason = default, string? feedContext = default)
        {
            this.Post = post;
            this.Reason = reason;
            this.FeedContext = feedContext;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonFeedPost"/> class.
        /// </summary>
        public SkeletonFeedPost()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonFeedPost"/> class.
        /// </summary>
        public SkeletonFeedPost(CBORObject obj)
        {
            if (obj["post"] is not null) this.Post = obj["post"].ToATUri();
            if (obj["reason"] is not null) this.Reason = obj["reason"].ToATObject();
            if (obj["feedContext"] is not null) this.FeedContext = obj["feedContext"].AsString();
        }

        /// <summary>
        /// Gets or sets the post.
        /// </summary>
        [JsonPropertyName("post")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Post { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// Union Types:
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.SkeletonReasonRepost"/> (app.bsky.feed.defs#skeletonReasonRepost)
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.SkeletonReasonPin"/> (app.bsky.feed.defs#skeletonReasonPin)
        /// </summary>
        [JsonPropertyName("reason")]
        public ATObject? Reason { get; set; }

        /// <summary>
        /// Gets or sets the feedContext.
        /// Context that will be passed through to client and may be passed to feed generator back alongside interactions.
        /// </summary>
        [JsonPropertyName("feedContext")]
        public string? FeedContext { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.defs#skeletonFeedPost";

        public const string RecordType = "app.bsky.feed.defs#skeletonFeedPost";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.SkeletonFeedPost>(this, (JsonTypeInfo<App.Bsky.Feed.SkeletonFeedPost>)SourceGenerationContext.Default.AppBskyFeedSkeletonFeedPost)!;
        }

        public static SkeletonFeedPost FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.SkeletonFeedPost>(json, (JsonTypeInfo<App.Bsky.Feed.SkeletonFeedPost>)SourceGenerationContext.Default.AppBskyFeedSkeletonFeedPost)!;
        }
    }
}
