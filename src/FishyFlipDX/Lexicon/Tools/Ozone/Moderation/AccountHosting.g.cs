// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    public partial class AccountHosting : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHosting"/> class.
        /// </summary>
        public AccountHosting()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHosting"/> class.
        /// </summary>
        public AccountHosting(CBORObject obj)
        {
            // enum
            if (obj["updatedAt"] is not null) this.UpdatedAt = obj["updatedAt"].ToDateTime();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
            if (obj["deletedAt"] is not null) this.DeletedAt = obj["deletedAt"].ToDateTime();
            if (obj["deactivatedAt"] is not null) this.DeactivatedAt = obj["deactivatedAt"].ToDateTime();
            if (obj["reactivatedAt"] is not null) this.ReactivatedAt = obj["reactivatedAt"].ToDateTime();
        }

        [JsonPropertyName("status")]
        [JsonRequired]
        public string? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        [JsonPropertyName("deactivatedAt")]
        public DateTime? DeactivatedAt { get; set; }

        [JsonPropertyName("reactivatedAt")]
        public DateTime? ReactivatedAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.defs#accountHosting";

        public const string RecordType = "tools.ozone.moderation.defs#accountHosting";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Moderation.AccountHosting>(this, (JsonTypeInfo<Tools.Ozone.Moderation.AccountHosting>)SourceGenerationContext.Default.ToolsOzoneModerationAccountHosting)!;
        }

        public static AccountHosting FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Moderation.AccountHosting>(json, (JsonTypeInfo<Tools.Ozone.Moderation.AccountHosting>)SourceGenerationContext.Default.ToolsOzoneModerationAccountHosting)!;
        }
    }
}
