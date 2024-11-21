// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    public partial class ModerationDetail : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationDetail"/> class.
        /// </summary>
        public ModerationDetail(Tools.Ozone.Moderation.SubjectStatusView? subjectStatus = default)
        {
            this.SubjectStatus = subjectStatus;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationDetail"/> class.
        /// </summary>
        public ModerationDetail()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationDetail"/> class.
        /// </summary>
        public ModerationDetail(CBORObject obj)
        {
            if (obj["subjectStatus"] is not null) this.SubjectStatus = new Tools.Ozone.Moderation.SubjectStatusView(obj["subjectStatus"]);
        }

        [JsonPropertyName("subjectStatus")]
        public Tools.Ozone.Moderation.SubjectStatusView? SubjectStatus { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.defs#moderationDetail";

        public const string RecordType = "tools.ozone.moderation.defs#moderationDetail";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Moderation.ModerationDetail>(this, (JsonTypeInfo<Tools.Ozone.Moderation.ModerationDetail>)SourceGenerationContext.Default.ToolsOzoneModerationModerationDetail)!;
        }

        public static ModerationDetail FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Moderation.ModerationDetail>(json, (JsonTypeInfo<Tools.Ozone.Moderation.ModerationDetail>)SourceGenerationContext.Default.ToolsOzoneModerationModerationDetail)!;
        }
    }
}

