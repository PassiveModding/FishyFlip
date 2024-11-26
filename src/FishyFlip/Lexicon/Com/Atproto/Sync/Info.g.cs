// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{
    public partial class Info : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Info"/> class.
        /// </summary>
        /// <param name="name">
        /// Known Values:
        /// OutdatedCursor
        /// </param>
        /// <param name="message"></param>
        public Info(string? name = default, string? message = default)
        {
            this.Name = name;
            this.Message = message;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Info"/> class.
        /// </summary>
        public Info()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Info"/> class.
        /// </summary>
        public Info(CBORObject obj)
        {
            if (obj["name"] is not null) this.Name = obj["name"].AsString();
            if (obj["message"] is not null) this.Message = obj["message"].AsString();
        }

        /// <summary>
        /// Gets or sets the name.
        /// Known Values:
        /// OutdatedCursor
        /// </summary>
        [JsonPropertyName("name")]
        [JsonRequired]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.sync.subscribeRepos#info";

        public const string RecordType = "com.atproto.sync.subscribeRepos#info";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Sync.Info>(this, (JsonTypeInfo<Com.Atproto.Sync.Info>)SourceGenerationContext.Default.ComAtprotoSyncInfo)!;
        }

        public static Info FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Sync.Info>(json, (JsonTypeInfo<Com.Atproto.Sync.Info>)SourceGenerationContext.Default.ComAtprotoSyncInfo)!;
        }
    }
}
