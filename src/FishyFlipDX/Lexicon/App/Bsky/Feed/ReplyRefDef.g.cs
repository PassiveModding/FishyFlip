// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class ReplyRefDef : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyRefDef"/> class.
        /// </summary>
        public ReplyRefDef()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyRefDef"/> class.
        /// </summary>
        public ReplyRefDef(CBORObject obj)
        {
            if (obj["root"] is not null) this.Root = new FishyFlip.Lexicon.Com.Atproto.Repo.StrongRef(obj["root"]);
            if (obj["parent"] is not null) this.Parent = new FishyFlip.Lexicon.Com.Atproto.Repo.StrongRef(obj["parent"]);
        }

        [JsonPropertyName("root")]
        [JsonRequired]
        public Com.Atproto.Repo.StrongRef? Root { get; set; }

        [JsonPropertyName("parent")]
        [JsonRequired]
        public Com.Atproto.Repo.StrongRef? Parent { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.post#replyRef";

        public const string RecordType = "app.bsky.feed.post#replyRef";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.ReplyRefDef>(this, (JsonTypeInfo<App.Bsky.Feed.ReplyRefDef>)SourceGenerationContext.Default.AppBskyFeedReplyRefDef)!;
        }

        public static ReplyRefDef FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.ReplyRefDef>(json, (JsonTypeInfo<App.Bsky.Feed.ReplyRefDef>)SourceGenerationContext.Default.AppBskyFeedReplyRefDef)!;
        }
    }
}
