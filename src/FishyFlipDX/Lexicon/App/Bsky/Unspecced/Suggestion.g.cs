// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Unspecced
{
    public partial class Suggestion : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion"/> class.
        /// </summary>
        public Suggestion(string? tag = default, string? subjectType = default, string? subject = default)
        {
            this.Tag = tag;
            this.SubjectType = subjectType;
            this.Subject = subject;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion"/> class.
        /// </summary>
        public Suggestion()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion"/> class.
        /// </summary>
        public Suggestion(CBORObject obj)
        {
            if (obj["tag"] is not null) this.Tag = obj["tag"].AsString();
            // enum
            if (obj["subject"] is not null) this.Subject = obj["subject"].AsString();
        }

        [JsonPropertyName("tag")]
        [JsonRequired]
        public string? Tag { get; set; }

        [JsonPropertyName("subjectType")]
        [JsonRequired]
        public string? SubjectType { get; set; }

        [JsonPropertyName("subject")]
        [JsonRequired]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.unspecced.getTaggedSuggestions#suggestion";

        public const string RecordType = "app.bsky.unspecced.getTaggedSuggestions#suggestion";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Unspecced.Suggestion>(this, (JsonTypeInfo<App.Bsky.Unspecced.Suggestion>)SourceGenerationContext.Default.AppBskyUnspeccedSuggestion)!;
        }

        public static Suggestion FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Unspecced.Suggestion>(json, (JsonTypeInfo<App.Bsky.Unspecced.Suggestion>)SourceGenerationContext.Default.AppBskyUnspeccedSuggestion)!;
        }
    }
}

