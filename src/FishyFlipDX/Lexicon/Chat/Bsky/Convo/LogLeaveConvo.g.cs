// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class LogLeaveConvo : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LogLeaveConvo"/> class.
        /// </summary>
        public LogLeaveConvo(string? rev = default, string? convoId = default)
        {
            this.Rev = rev;
            this.ConvoId = convoId;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LogLeaveConvo"/> class.
        /// </summary>
        public LogLeaveConvo()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LogLeaveConvo"/> class.
        /// </summary>
        public LogLeaveConvo(CBORObject obj)
        {
            if (obj["rev"] is not null) this.Rev = obj["rev"].AsString();
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
        }

        [JsonPropertyName("rev")]
        [JsonRequired]
        public string? Rev { get; set; }

        [JsonPropertyName("convoId")]
        [JsonRequired]
        public string? ConvoId { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.defs#logLeaveConvo";

        public const string RecordType = "chat.bsky.convo.defs#logLeaveConvo";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Chat.Bsky.Convo.LogLeaveConvo>(this, (JsonTypeInfo<Chat.Bsky.Convo.LogLeaveConvo>)SourceGenerationContext.Default.ChatBskyConvoLogLeaveConvo)!;
        }

        public static LogLeaveConvo FromJson(string json)
        {
            return JsonSerializer.Deserialize<Chat.Bsky.Convo.LogLeaveConvo>(json, (JsonTypeInfo<Chat.Bsky.Convo.LogLeaveConvo>)SourceGenerationContext.Default.ChatBskyConvoLogLeaveConvo)!;
        }
    }
}

