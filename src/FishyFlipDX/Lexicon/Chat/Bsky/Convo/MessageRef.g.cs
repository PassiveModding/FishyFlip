// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class MessageRef : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRef"/> class.
        /// </summary>
        public MessageRef()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRef"/> class.
        /// </summary>
        public MessageRef(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
            if (obj["messageId"] is not null) this.MessageId = obj["messageId"].AsString();
        }

        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        [JsonPropertyName("convoId")]
        [JsonRequired]
        public string? ConvoId { get; set; }

        [JsonPropertyName("messageId")]
        [JsonRequired]
        public string? MessageId { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.defs#messageRef";

        public const string RecordType = "chat.bsky.convo.defs#messageRef";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Chat.Bsky.Convo.MessageRef>(this, (JsonTypeInfo<Chat.Bsky.Convo.MessageRef>)SourceGenerationContext.Default.ChatBskyConvoMessageRef)!;
        }

        public static MessageRef FromJson(string json)
        {
            return JsonSerializer.Deserialize<Chat.Bsky.Convo.MessageRef>(json, (JsonTypeInfo<Chat.Bsky.Convo.MessageRef>)SourceGenerationContext.Default.ChatBskyConvoMessageRef)!;
        }
    }
}
