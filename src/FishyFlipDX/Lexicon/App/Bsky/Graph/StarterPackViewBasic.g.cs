// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    public partial class StarterPackViewBasic : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StarterPackViewBasic"/> class.
        /// </summary>
        public StarterPackViewBasic()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="StarterPackViewBasic"/> class.
        /// </summary>
        public StarterPackViewBasic(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["record"] is not null) this.Record = obj["record"].ToATObject();
            if (obj["creator"] is not null) this.Creator = new App.Bsky.Actor.ProfileViewBasic(obj["creator"]);
            if (obj["listItemCount"] is not null) this.ListItemCount = obj["listItemCount"].AsInt64Value();
            if (obj["joinedWeekCount"] is not null) this.JoinedWeekCount = obj["joinedWeekCount"].AsInt64Value();
            if (obj["joinedAllTimeCount"] is not null) this.JoinedAllTimeCount = obj["joinedAllTimeCount"].AsInt64Value();
            if (obj["labels"] is not null) this.Labels = obj["labels"].Values.Select(n => n is not null ? new Com.Atproto.Label.Label(n) : null).ToList();
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
        }

        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("cid")]
        [JsonRequired]
        public string? Cid { get; set; }

        [JsonPropertyName("record")]
        [JsonRequired]
        public ATObject? Record { get; set; }

        [JsonPropertyName("creator")]
        [JsonRequired]
        public App.Bsky.Actor.ProfileViewBasic? Creator { get; set; }

        [JsonPropertyName("listItemCount")]
        public long? ListItemCount { get; set; }

        [JsonPropertyName("joinedWeekCount")]
        public long? JoinedWeekCount { get; set; }

        [JsonPropertyName("joinedAllTimeCount")]
        public long? JoinedAllTimeCount { get; set; }

        [JsonPropertyName("labels")]
        public List<FishyFlip.Lexicon.Com.Atproto.Label.Label?>? Labels { get; set; }

        [JsonPropertyName("indexedAt")]
        [JsonRequired]
        public DateTime? IndexedAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.graph.defs#starterPackViewBasic";

        public const string RecordType = "app.bsky.graph.defs#starterPackViewBasic";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Graph.StarterPackViewBasic>(this, (JsonTypeInfo<App.Bsky.Graph.StarterPackViewBasic>)SourceGenerationContext.Default.AppBskyGraphStarterPackViewBasic)!;
        }

        public static StarterPackViewBasic FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Graph.StarterPackViewBasic>(json, (JsonTypeInfo<App.Bsky.Graph.StarterPackViewBasic>)SourceGenerationContext.Default.AppBskyGraphStarterPackViewBasic)!;
        }
    }
}
