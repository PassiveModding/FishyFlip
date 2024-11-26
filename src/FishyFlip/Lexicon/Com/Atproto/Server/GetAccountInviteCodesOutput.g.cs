// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class GetAccountInviteCodesOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInviteCodesOutput"/> class.
        /// </summary>
        /// <param name="codes"></param>
        public GetAccountInviteCodesOutput(List<Com.Atproto.Server.InviteCode>? codes = default)
        {
            this.Codes = codes;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInviteCodesOutput"/> class.
        /// </summary>
        public GetAccountInviteCodesOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInviteCodesOutput"/> class.
        /// </summary>
        public GetAccountInviteCodesOutput(CBORObject obj)
        {
            if (obj["codes"] is not null) this.Codes = obj["codes"].Values.Select(n =>new Com.Atproto.Server.InviteCode(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the codes.
        /// </summary>
        [JsonPropertyName("codes")]
        [JsonRequired]
        public List<Com.Atproto.Server.InviteCode>? Codes { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.getAccountInviteCodes#GetAccountInviteCodesOutput";

        public const string RecordType = "com.atproto.server.getAccountInviteCodes#GetAccountInviteCodesOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Server.GetAccountInviteCodesOutput>(this, (JsonTypeInfo<Com.Atproto.Server.GetAccountInviteCodesOutput>)SourceGenerationContext.Default.ComAtprotoServerGetAccountInviteCodesOutput)!;
        }

        public static GetAccountInviteCodesOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Server.GetAccountInviteCodesOutput>(json, (JsonTypeInfo<Com.Atproto.Server.GetAccountInviteCodesOutput>)SourceGenerationContext.Default.ComAtprotoServerGetAccountInviteCodesOutput)!;
        }
    }
}
