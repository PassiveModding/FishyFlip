// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class SavedFeedsPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedFeedsPref"/> class.
        /// </summary>
        public SavedFeedsPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SavedFeedsPref"/> class.
        /// </summary>
        public SavedFeedsPref(CBORObject obj)
        {
            if (obj["pinned"] is not null) this.Pinned = obj["pinned"].Values.Select(n => n is not null ? new FishyFlip.Models.ATUri(n) : null).ToList();
            if (obj["saved"] is not null) this.Saved = obj["saved"].Values.Select(n => n is not null ? new FishyFlip.Models.ATUri(n) : null).ToList();
            if (obj["timelineIndex"] is not null) this.TimelineIndex = obj["timelineIndex"].AsInt64Value();
        }

        [JsonPropertyName("pinned")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.GenericListConverter<FishyFlip.Models.ATUri?, FishyFlip.Tools.Json.ATUriJsonConverter>))]
        public List<FishyFlip.Models.ATUri?>? Pinned { get; set; }

        [JsonPropertyName("saved")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.GenericListConverter<FishyFlip.Models.ATUri?, FishyFlip.Tools.Json.ATUriJsonConverter>))]
        public List<FishyFlip.Models.ATUri?>? Saved { get; set; }

        [JsonPropertyName("timelineIndex")]
        public long? TimelineIndex { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#savedFeedsPref";

        public const string RecordType = "app.bsky.actor.defs#savedFeedsPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Actor.SavedFeedsPref>(this, (JsonTypeInfo<App.Bsky.Actor.SavedFeedsPref>)SourceGenerationContext.Default.AppBskyActorSavedFeedsPref)!;
        }

        public static SavedFeedsPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Actor.SavedFeedsPref>(json, (JsonTypeInfo<App.Bsky.Actor.SavedFeedsPref>)SourceGenerationContext.Default.AppBskyActorSavedFeedsPref)!;
        }
    }
}
