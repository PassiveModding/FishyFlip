// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class GetActorFeedsOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorFeedsOutput"/> class.
        /// </summary>
        public GetActorFeedsOutput(string? cursor = default, List<App.Bsky.Feed.GeneratorView>? feeds = default)
        {
            this.Cursor = cursor;
            this.Feeds = feeds;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorFeedsOutput"/> class.
        /// </summary>
        public GetActorFeedsOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorFeedsOutput"/> class.
        /// </summary>
        public GetActorFeedsOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["feeds"] is not null) this.Feeds = obj["feeds"].Values.Select(n =>new App.Bsky.Feed.GeneratorView(n)).ToList();
        }

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        [JsonPropertyName("feeds")]
        [JsonRequired]
        public List<App.Bsky.Feed.GeneratorView>? Feeds { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.getActorFeeds#GetActorFeedsOutput";

        public const string RecordType = "app.bsky.feed.getActorFeeds#GetActorFeedsOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.GetActorFeedsOutput>(this, (JsonTypeInfo<App.Bsky.Feed.GetActorFeedsOutput>)SourceGenerationContext.Default.AppBskyFeedGetActorFeedsOutput)!;
        }

        public static GetActorFeedsOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.GetActorFeedsOutput>(json, (JsonTypeInfo<App.Bsky.Feed.GetActorFeedsOutput>)SourceGenerationContext.Default.AppBskyFeedGetActorFeedsOutput)!;
        }
    }
}

