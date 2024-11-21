// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Labeler
{
    public partial class LabelerPolicies : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerPolicies"/> class.
        /// </summary>
        public LabelerPolicies(List<string>? labelValues = default, List<Com.Atproto.Label.LabelValueDefinition>? labelValueDefinitions = default)
        {
            this.LabelValues = labelValues;
            this.LabelValueDefinitions = labelValueDefinitions;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerPolicies"/> class.
        /// </summary>
        public LabelerPolicies()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerPolicies"/> class.
        /// </summary>
        public LabelerPolicies(CBORObject obj)
        {
            if (obj["labelValues"] is not null) this.LabelValues = obj["labelValues"].Values.Select(n =>n.AsString()).ToList();
            if (obj["labelValueDefinitions"] is not null) this.LabelValueDefinitions = obj["labelValueDefinitions"].Values.Select(n =>new Com.Atproto.Label.LabelValueDefinition(n)).ToList();
        }

        /// <summary>
        /// The label values which this labeler publishes. May include global or custom labels.
        /// </summary>
        [JsonPropertyName("labelValues")]
        [JsonRequired]
        public List<string>? LabelValues { get; set; }

        /// <summary>
        /// Label values created by this labeler and scoped exclusively to it. Labels defined here will override global label definitions for this labeler.
        /// </summary>
        [JsonPropertyName("labelValueDefinitions")]
        public List<Com.Atproto.Label.LabelValueDefinition>? LabelValueDefinitions { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.labeler.defs#labelerPolicies";

        public const string RecordType = "app.bsky.labeler.defs#labelerPolicies";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Labeler.LabelerPolicies>(this, (JsonTypeInfo<App.Bsky.Labeler.LabelerPolicies>)SourceGenerationContext.Default.AppBskyLabelerLabelerPolicies)!;
        }

        public static LabelerPolicies FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Labeler.LabelerPolicies>(json, (JsonTypeInfo<App.Bsky.Labeler.LabelerPolicies>)SourceGenerationContext.Default.AppBskyLabelerLabelerPolicies)!;
        }
    }
}

