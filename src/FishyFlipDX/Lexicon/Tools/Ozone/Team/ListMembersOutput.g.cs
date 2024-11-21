// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Team
{
    public partial class ListMembersOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMembersOutput"/> class.
        /// </summary>
        public ListMembersOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListMembersOutput"/> class.
        /// </summary>
        public ListMembersOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["members"] is not null) this.Members = obj["members"].Values.Select(n =>new Tools.Ozone.Team.Member(n)).ToList();
        }

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        [JsonPropertyName("members")]
        [JsonRequired]
        public List<Tools.Ozone.Team.Member>? Members { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.team.listMembers#ListMembersOutput";

        public const string RecordType = "tools.ozone.team.listMembers#ListMembersOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Team.ListMembersOutput>(this, (JsonTypeInfo<Tools.Ozone.Team.ListMembersOutput>)SourceGenerationContext.Default.ToolsOzoneTeamListMembersOutput)!;
        }

        public static ListMembersOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Team.ListMembersOutput>(json, (JsonTypeInfo<Tools.Ozone.Team.ListMembersOutput>)SourceGenerationContext.Default.ToolsOzoneTeamListMembersOutput)!;
        }
    }
}

