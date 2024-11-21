// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Signature
{
    public partial class FindRelatedAccountsOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FindRelatedAccountsOutput"/> class.
        /// </summary>
        public FindRelatedAccountsOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="FindRelatedAccountsOutput"/> class.
        /// </summary>
        public FindRelatedAccountsOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["accounts"] is not null) this.Accounts = obj["accounts"].Values.Select(n =>new Tools.Ozone.Signature.RelatedAccount(n)).ToList();
        }

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        [JsonPropertyName("accounts")]
        [JsonRequired]
        public List<Tools.Ozone.Signature.RelatedAccount>? Accounts { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.signature.findRelatedAccounts#FindRelatedAccountsOutput";

        public const string RecordType = "tools.ozone.signature.findRelatedAccounts#FindRelatedAccountsOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Signature.FindRelatedAccountsOutput>(this, (JsonTypeInfo<Tools.Ozone.Signature.FindRelatedAccountsOutput>)SourceGenerationContext.Default.ToolsOzoneSignatureFindRelatedAccountsOutput)!;
        }

        public static FindRelatedAccountsOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Signature.FindRelatedAccountsOutput>(json, (JsonTypeInfo<Tools.Ozone.Signature.FindRelatedAccountsOutput>)SourceGenerationContext.Default.ToolsOzoneSignatureFindRelatedAccountsOutput)!;
        }
    }
}

