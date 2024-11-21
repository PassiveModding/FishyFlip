// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class ListConvosOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConvosOutput"/> class.
        /// </summary>
        public ListConvosOutput(string? cursor = default, List<Chat.Bsky.Convo.ConvoView>? convos = default)
        {
            this.Cursor = cursor;
            this.Convos = convos;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListConvosOutput"/> class.
        /// </summary>
        public ListConvosOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListConvosOutput"/> class.
        /// </summary>
        public ListConvosOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["convos"] is not null) this.Convos = obj["convos"].Values.Select(n =>new Chat.Bsky.Convo.ConvoView(n)).ToList();
        }

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        [JsonPropertyName("convos")]
        [JsonRequired]
        public List<Chat.Bsky.Convo.ConvoView>? Convos { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.listConvos#ListConvosOutput";

        public const string RecordType = "chat.bsky.convo.listConvos#ListConvosOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Chat.Bsky.Convo.ListConvosOutput>(this, (JsonTypeInfo<Chat.Bsky.Convo.ListConvosOutput>)SourceGenerationContext.Default.ChatBskyConvoListConvosOutput)!;
        }

        public static ListConvosOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Chat.Bsky.Convo.ListConvosOutput>(json, (JsonTypeInfo<Chat.Bsky.Convo.ListConvosOutput>)SourceGenerationContext.Default.ChatBskyConvoListConvosOutput)!;
        }
    }
}

