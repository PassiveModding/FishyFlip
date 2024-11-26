// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class UnmuteConvoOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteConvoOutput"/> class.
        /// </summary>
        /// <param name="convo">
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.ConvoView"/> (chat.bsky.convo.defs#convoView)
        /// </param>
        public UnmuteConvoOutput(Chat.Bsky.Convo.ConvoView? convo = default)
        {
            this.Convo = convo;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteConvoOutput"/> class.
        /// </summary>
        public UnmuteConvoOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteConvoOutput"/> class.
        /// </summary>
        public UnmuteConvoOutput(CBORObject obj)
        {
            if (obj["convo"] is not null) this.Convo = new Chat.Bsky.Convo.ConvoView(obj["convo"]);
        }

        /// <summary>
        /// Gets or sets the convo.
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.ConvoView"/> (chat.bsky.convo.defs#convoView)
        /// </summary>
        [JsonPropertyName("convo")]
        [JsonRequired]
        public Chat.Bsky.Convo.ConvoView? Convo { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.unmuteConvo#UnmuteConvoOutput";

        public const string RecordType = "chat.bsky.convo.unmuteConvo#UnmuteConvoOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Chat.Bsky.Convo.UnmuteConvoOutput>(this, (JsonTypeInfo<Chat.Bsky.Convo.UnmuteConvoOutput>)SourceGenerationContext.Default.ChatBskyConvoUnmuteConvoOutput)!;
        }

        public static UnmuteConvoOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Chat.Bsky.Convo.UnmuteConvoOutput>(json, (JsonTypeInfo<Chat.Bsky.Convo.UnmuteConvoOutput>)SourceGenerationContext.Default.ChatBskyConvoUnmuteConvoOutput)!;
        }
    }
}
