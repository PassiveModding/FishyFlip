// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class GetActorLikesOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorLikesOutput"/> class.
        /// </summary>
        public GetActorLikesOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorLikesOutput"/> class.
        /// </summary>
        public GetActorLikesOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["feed"] is not null) this.Feed = obj["feed"].Values.Select(n =>new App.Bsky.Feed.FeedViewPost(n)).ToList();
        }

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        [JsonPropertyName("feed")]
        [JsonRequired]
        public List<App.Bsky.Feed.FeedViewPost>? Feed { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.getActorLikes#GetActorLikesOutput";

        public const string RecordType = "app.bsky.feed.getActorLikes#GetActorLikesOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.GetActorLikesOutput>(this, (JsonTypeInfo<App.Bsky.Feed.GetActorLikesOutput>)SourceGenerationContext.Default.AppBskyFeedGetActorLikesOutput)!;
        }

        public static GetActorLikesOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.GetActorLikesOutput>(json, (JsonTypeInfo<App.Bsky.Feed.GetActorLikesOutput>)SourceGenerationContext.Default.AppBskyFeedGetActorLikesOutput)!;
        }
    }
}

