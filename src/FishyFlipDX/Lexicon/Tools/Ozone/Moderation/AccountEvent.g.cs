// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    /// <summary>
    /// Logs account status related events on a repo subject. Normally captured by automod from the firehose and emitted to ozone for historical tracking.
    /// </summary>
    public partial class AccountEvent : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEvent"/> class.
        /// </summary>
        public AccountEvent()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEvent"/> class.
        /// </summary>
        public AccountEvent(CBORObject obj)
        {
            if (obj["comment"] is not null) this.Comment = obj["comment"].AsString();
            if (obj["active"] is not null) this.Active = obj["active"].AsBoolean();
            // enum
            if (obj["timestamp"] is not null) this.Timestamp = obj["timestamp"].ToDateTime();
        }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Indicates that the account has a repository which can be fetched from the host that emitted this event.
        /// </summary>
        [JsonPropertyName("active")]
        [JsonRequired]
        public bool? Active { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("timestamp")]
        [JsonRequired]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.defs#accountEvent";

        public const string RecordType = "tools.ozone.moderation.defs#accountEvent";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Moderation.AccountEvent>(this, (JsonTypeInfo<Tools.Ozone.Moderation.AccountEvent>)SourceGenerationContext.Default.ToolsOzoneModerationAccountEvent)!;
        }

        public static AccountEvent FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Moderation.AccountEvent>(json, (JsonTypeInfo<Tools.Ozone.Moderation.AccountEvent>)SourceGenerationContext.Default.ToolsOzoneModerationAccountEvent)!;
        }
    }
}
