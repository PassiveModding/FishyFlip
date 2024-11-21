// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    public partial class ListViewerState : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewerState"/> class.
        /// </summary>
        public ListViewerState(bool? muted = default, FishyFlip.Models.ATUri? blocked = default)
        {
            this.Muted = muted;
            this.Blocked = blocked;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewerState"/> class.
        /// </summary>
        public ListViewerState()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListViewerState"/> class.
        /// </summary>
        public ListViewerState(CBORObject obj)
        {
            if (obj["muted"] is not null) this.Muted = obj["muted"].AsBoolean();
            if (obj["blocked"] is not null) this.Blocked = obj["blocked"].ToATUri();
        }

        [JsonPropertyName("muted")]
        public bool? Muted { get; set; }

        [JsonPropertyName("blocked")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Blocked { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.graph.defs#listViewerState";

        public const string RecordType = "app.bsky.graph.defs#listViewerState";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Graph.ListViewerState>(this, (JsonTypeInfo<App.Bsky.Graph.ListViewerState>)SourceGenerationContext.Default.AppBskyGraphListViewerState)!;
        }

        public static ListViewerState FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Graph.ListViewerState>(json, (JsonTypeInfo<App.Bsky.Graph.ListViewerState>)SourceGenerationContext.Default.AppBskyGraphListViewerState)!;
        }
    }
}

