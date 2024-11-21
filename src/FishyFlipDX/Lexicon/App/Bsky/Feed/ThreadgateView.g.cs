// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class ThreadgateView : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadgateView"/> class.
        /// </summary>
        public ThreadgateView()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadgateView"/> class.
        /// </summary>
        public ThreadgateView(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["record"] is not null) this.Record = obj["record"].ToATObject();
            if (obj["lists"] is not null) this.Lists = obj["lists"].Values.Select(n =>new App.Bsky.Graph.ListViewBasic(n)).ToList();
        }

        [JsonPropertyName("uri")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("cid")]
        public string? Cid { get; set; }

        [JsonPropertyName("record")]
        public ATObject? Record { get; set; }

        [JsonPropertyName("lists")]
        public List<App.Bsky.Graph.ListViewBasic>? Lists { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.defs#threadgateView";

        public const string RecordType = "app.bsky.feed.defs#threadgateView";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.ThreadgateView>(this, (JsonTypeInfo<App.Bsky.Feed.ThreadgateView>)SourceGenerationContext.Default.AppBskyFeedThreadgateView)!;
        }

        public static ThreadgateView FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.ThreadgateView>(json, (JsonTypeInfo<App.Bsky.Feed.ThreadgateView>)SourceGenerationContext.Default.AppBskyFeedThreadgateView)!;
        }
    }
}

