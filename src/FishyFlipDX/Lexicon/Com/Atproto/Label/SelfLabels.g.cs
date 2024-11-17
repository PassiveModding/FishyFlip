// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Label
{
    /// <summary>
    /// Metadata tags on an atproto record, published by the author within the record.
    /// </summary>
    public partial class SelfLabels : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfLabels"/> class.
        /// </summary>
        public SelfLabels()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SelfLabels"/> class.
        /// </summary>
        public SelfLabels(CBORObject obj)
        {
            if (obj["values"] is not null) this.Values = obj["values"].Values.Select(n => n is not null ? new SelfLabel(n) : null).ToList();
        }

        [JsonPropertyName("values")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.Com.Atproto.Label.SelfLabel?>? Values { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.label.defs#selfLabels";

        public const string RecordType = "com.atproto.label.defs#selfLabels";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Label.SelfLabels>(this, (JsonTypeInfo<Com.Atproto.Label.SelfLabels>)SourceGenerationContext.Default.ComAtprotoLabelSelfLabels)!;
        }

        public static SelfLabels FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Label.SelfLabels>(json, (JsonTypeInfo<Com.Atproto.Label.SelfLabels>)SourceGenerationContext.Default.ComAtprotoLabelSelfLabels)!;
        }
    }
}
