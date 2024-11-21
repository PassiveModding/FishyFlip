// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Label
{
    public partial class Labels : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Labels"/> class.
        /// </summary>
        public Labels()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Labels"/> class.
        /// </summary>
        public Labels(CBORObject obj)
        {
            if (obj["seq"] is not null) this.Seq = obj["seq"].AsInt64Value();
            if (obj["labels"] is not null) this.LabelsValue = obj["labels"].Values.Select(n =>new Com.Atproto.Label.Label(n)).ToList();
        }

        [JsonPropertyName("seq")]
        [JsonRequired]
        public long? Seq { get; set; }

        [JsonPropertyName("labels")]
        [JsonRequired]
        public List<Com.Atproto.Label.Label>? LabelsValue { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.label.subscribeLabels#labels";

        public const string RecordType = "com.atproto.label.subscribeLabels#labels";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Label.Labels>(this, (JsonTypeInfo<Com.Atproto.Label.Labels>)SourceGenerationContext.Default.ComAtprotoLabelLabels)!;
        }

        public static Labels FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Label.Labels>(json, (JsonTypeInfo<Com.Atproto.Label.Labels>)SourceGenerationContext.Default.ComAtprotoLabelLabels)!;
        }
    }
}

