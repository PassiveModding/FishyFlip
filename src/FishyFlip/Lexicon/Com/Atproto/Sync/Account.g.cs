// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{
    /// <summary>
    /// Represents a change to an account's status on a host (eg, PDS or Relay). The semantics of this event are that the status is at the host which emitted the event, not necessarily that at the currently active PDS. Eg, a Relay takedown would emit a takedown with active=false, even if the PDS is still active.
    /// </summary>
    public partial class Account : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="seq"></param>
        /// <param name="did"></param>
        /// <param name="time"></param>
        /// <param name="active">Indicates that the account has a repository which can be fetched from the host that emitted this event.</param>
        /// <param name="status">If active=false, this optional field indicates a reason for why the account is not active.
        /// Known Values:
        /// takendown
        /// suspended
        /// deleted
        /// deactivated
        /// </param>
        public Account(long? seq = default, FishyFlip.Models.ATDid? did = default, DateTime? time = default, bool? active = default, string? status = default)
        {
            this.Seq = seq;
            this.Did = did;
            this.Time = time;
            this.Active = active;
            this.Status = status;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account(CBORObject obj)
        {
            if (obj["seq"] is not null) this.Seq = obj["seq"].AsInt64Value();
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["time"] is not null) this.Time = obj["time"].ToDateTime();
            if (obj["active"] is not null) this.Active = obj["active"].AsBoolean();
            if (obj["status"] is not null) this.Status = obj["status"].AsString();
        }

        /// <summary>
        /// Gets or sets the seq.
        /// </summary>
        [JsonPropertyName("seq")]
        [JsonRequired]
        public long? Seq { get; set; }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        [JsonPropertyName("time")]
        [JsonRequired]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Gets or sets the active.
        /// Indicates that the account has a repository which can be fetched from the host that emitted this event.
        /// </summary>
        [JsonPropertyName("active")]
        [JsonRequired]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// If active=false, this optional field indicates a reason for why the account is not active.
        /// Known Values:
        /// takendown
        /// suspended
        /// deleted
        /// deactivated
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.sync.subscribeRepos#account";

        public const string RecordType = "com.atproto.sync.subscribeRepos#account";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Sync.Account>(this, (JsonTypeInfo<Com.Atproto.Sync.Account>)SourceGenerationContext.Default.ComAtprotoSyncAccount)!;
        }

        public static Account FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Sync.Account>(json, (JsonTypeInfo<Com.Atproto.Sync.Account>)SourceGenerationContext.Default.ComAtprotoSyncAccount)!;
        }
    }
}
