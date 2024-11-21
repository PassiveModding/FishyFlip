// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Set
{
    public partial class QuerySetsOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySetsOutput"/> class.
        /// </summary>
        public QuerySetsOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySetsOutput"/> class.
        /// </summary>
        public QuerySetsOutput(CBORObject obj)
        {
            if (obj["sets"] is not null) this.Sets = obj["sets"].Values.Select(n =>new Tools.Ozone.Set.SetView(n)).ToList();
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
        }

        [JsonPropertyName("sets")]
        [JsonRequired]
        public List<Tools.Ozone.Set.SetView>? Sets { get; set; }

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.set.querySets#QuerySetsOutput";

        public const string RecordType = "tools.ozone.set.querySets#QuerySetsOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Set.QuerySetsOutput>(this, (JsonTypeInfo<Tools.Ozone.Set.QuerySetsOutput>)SourceGenerationContext.Default.ToolsOzoneSetQuerySetsOutput)!;
        }

        public static QuerySetsOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Set.QuerySetsOutput>(json, (JsonTypeInfo<Tools.Ozone.Set.QuerySetsOutput>)SourceGenerationContext.Default.ToolsOzoneSetQuerySetsOutput)!;
        }
    }
}

