// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class PutRecordOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutRecordOutput"/> class.
        /// </summary>
        public PutRecordOutput(FishyFlip.Models.ATUri? uri = default, string? cid = default, Com.Atproto.Repo.CommitMeta? commit = default, string? validationStatus = default)
        {
            this.Uri = uri;
            this.Cid = cid;
            this.Commit = commit;
            this.ValidationStatus = validationStatus;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PutRecordOutput"/> class.
        /// </summary>
        public PutRecordOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PutRecordOutput"/> class.
        /// </summary>
        public PutRecordOutput(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["commit"] is not null) this.Commit = new Com.Atproto.Repo.CommitMeta(obj["commit"]);
            // enum
        }

        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("cid")]
        [JsonRequired]
        public string? Cid { get; set; }

        [JsonPropertyName("commit")]
        public Com.Atproto.Repo.CommitMeta? Commit { get; set; }

        [JsonPropertyName("validationStatus")]
        public string? ValidationStatus { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.putRecord#PutRecordOutput";

        public const string RecordType = "com.atproto.repo.putRecord#PutRecordOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Repo.PutRecordOutput>(this, (JsonTypeInfo<Com.Atproto.Repo.PutRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoPutRecordOutput)!;
        }

        public static PutRecordOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Repo.PutRecordOutput>(json, (JsonTypeInfo<Com.Atproto.Repo.PutRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoPutRecordOutput)!;
        }
    }
}

