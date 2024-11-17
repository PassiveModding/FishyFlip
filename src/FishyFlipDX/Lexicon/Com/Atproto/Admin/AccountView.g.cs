// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class AccountView : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountView"/> class.
        /// </summary>
        public AccountView()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountView"/> class.
        /// </summary>
        public AccountView(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["handle"] is not null) this.Handle = obj["handle"].ToATHandle();
            if (obj["email"] is not null) this.Email = obj["email"].AsString();
            if (obj["relatedRecords"] is not null) this.RelatedRecords = obj["relatedRecords"].Values.Select(n => n is not null ? n.ToATObject() : null).ToList();
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
            if (obj["invitedBy"] is not null) this.InvitedBy = new Com.Atproto.Server.InviteCode(obj["invitedBy"]);
            if (obj["invites"] is not null) this.Invites = obj["invites"].Values.Select(n => n is not null ? new Com.Atproto.Server.InviteCode(n) : null).ToList();
            if (obj["invitesDisabled"] is not null) this.InvitesDisabled = obj["invitesDisabled"].AsBoolean();
            if (obj["emailConfirmedAt"] is not null) this.EmailConfirmedAt = obj["emailConfirmedAt"].ToDateTime();
            if (obj["inviteNote"] is not null) this.InviteNote = obj["inviteNote"].AsString();
            if (obj["deactivatedAt"] is not null) this.DeactivatedAt = obj["deactivatedAt"].ToDateTime();
            if (obj["threatSignatures"] is not null) this.ThreatSignatures = obj["threatSignatures"].Values.Select(n => n is not null ? new ThreatSignature(n) : null).ToList();
        }

        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        [JsonPropertyName("handle")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATHandleJsonConverter))]
        public FishyFlip.Models.ATHandle? Handle { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("relatedRecords")]
        public List<ATObject?>? RelatedRecords { get; set; }

        [JsonPropertyName("indexedAt")]
        [JsonRequired]
        public DateTime? IndexedAt { get; set; }

        [JsonPropertyName("invitedBy")]
        public Com.Atproto.Server.InviteCode? InvitedBy { get; set; }

        [JsonPropertyName("invites")]
        public List<FishyFlip.Lexicon.Com.Atproto.Server.InviteCode?>? Invites { get; set; }

        [JsonPropertyName("invitesDisabled")]
        public bool? InvitesDisabled { get; set; }

        [JsonPropertyName("emailConfirmedAt")]
        public DateTime? EmailConfirmedAt { get; set; }

        [JsonPropertyName("inviteNote")]
        public string? InviteNote { get; set; }

        [JsonPropertyName("deactivatedAt")]
        public DateTime? DeactivatedAt { get; set; }

        [JsonPropertyName("threatSignatures")]
        public List<FishyFlip.Lexicon.Com.Atproto.Admin.ThreatSignature?>? ThreatSignatures { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.admin.defs#accountView";

        public const string RecordType = "com.atproto.admin.defs#accountView";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Admin.AccountView>(this, (JsonTypeInfo<Com.Atproto.Admin.AccountView>)SourceGenerationContext.Default.ComAtprotoAdminAccountView)!;
        }

        public static AccountView FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Admin.AccountView>(json, (JsonTypeInfo<Com.Atproto.Admin.AccountView>)SourceGenerationContext.Default.ComAtprotoAdminAccountView)!;
        }
    }
}
