// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Signature
{
    public partial class RelatedAccount : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedAccount"/> class.
        /// </summary>
        public RelatedAccount()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedAccount"/> class.
        /// </summary>
        public RelatedAccount(CBORObject obj)
        {
            if (obj["account"] is not null) this.Account = new Com.Atproto.Admin.AccountView(obj["account"]);
            if (obj["similarities"] is not null) this.Similarities = obj["similarities"].Values.Select(n =>new Tools.Ozone.Signature.SigDetail(n)).ToList();
        }

        [JsonPropertyName("account")]
        [JsonRequired]
        public Com.Atproto.Admin.AccountView? Account { get; set; }

        [JsonPropertyName("similarities")]
        public List<Tools.Ozone.Signature.SigDetail>? Similarities { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.signature.findRelatedAccounts#relatedAccount";

        public const string RecordType = "tools.ozone.signature.findRelatedAccounts#relatedAccount";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Signature.RelatedAccount>(this, (JsonTypeInfo<Tools.Ozone.Signature.RelatedAccount>)SourceGenerationContext.Default.ToolsOzoneSignatureRelatedAccount)!;
        }

        public static RelatedAccount FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Signature.RelatedAccount>(json, (JsonTypeInfo<Tools.Ozone.Signature.RelatedAccount>)SourceGenerationContext.Default.ToolsOzoneSignatureRelatedAccount)!;
        }
    }
}

