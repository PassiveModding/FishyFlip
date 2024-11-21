// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class LabelersPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelersPref"/> class.
        /// </summary>
        public LabelersPref(List<App.Bsky.Actor.LabelerPrefItem>? labelers = default)
        {
            this.Labelers = labelers;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelersPref"/> class.
        /// </summary>
        public LabelersPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelersPref"/> class.
        /// </summary>
        public LabelersPref(CBORObject obj)
        {
            if (obj["labelers"] is not null) this.Labelers = obj["labelers"].Values.Select(n =>new App.Bsky.Actor.LabelerPrefItem(n)).ToList();
        }

        [JsonPropertyName("labelers")]
        [JsonRequired]
        public List<App.Bsky.Actor.LabelerPrefItem>? Labelers { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#labelersPref";

        public const string RecordType = "app.bsky.actor.defs#labelersPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Actor.LabelersPref>(this, (JsonTypeInfo<App.Bsky.Actor.LabelersPref>)SourceGenerationContext.Default.AppBskyActorLabelersPref)!;
        }

        public static LabelersPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Actor.LabelersPref>(json, (JsonTypeInfo<App.Bsky.Actor.LabelersPref>)SourceGenerationContext.Default.AppBskyActorLabelersPref)!;
        }
    }
}

