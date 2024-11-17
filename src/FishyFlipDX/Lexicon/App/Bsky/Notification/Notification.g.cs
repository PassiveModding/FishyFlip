// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Notification
{
    public partial class Notification : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        public Notification()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        public Notification(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["author"] is not null) this.Author = new App.Bsky.Actor.ProfileView(obj["author"]);
            // enum
            if (obj["reasonSubject"] is not null) this.ReasonSubject = obj["reasonSubject"].ToATUri();
            if (obj["record"] is not null) this.Record = obj["record"].ToATObject();
            if (obj["isRead"] is not null) this.IsRead = obj["isRead"].AsBoolean();
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
            if (obj["labels"] is not null) this.Labels = obj["labels"].Values.Select(n => n is not null ? new Com.Atproto.Label.Label(n) : null).ToList();
        }

        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("cid")]
        [JsonRequired]
        public string? Cid { get; set; }

        [JsonPropertyName("author")]
        [JsonRequired]
        public App.Bsky.Actor.ProfileView? Author { get; set; }

        /// <summary>
        /// Expected values are 'like', 'repost', 'follow', 'mention', 'reply', 'quote', and 'starterpack-joined'.
        /// </summary>
        [JsonPropertyName("reason")]
        [JsonRequired]
        public string? Reason { get; set; }

        [JsonPropertyName("reasonSubject")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? ReasonSubject { get; set; }

        [JsonPropertyName("record")]
        [JsonRequired]
        public ATObject? Record { get; set; }

        [JsonPropertyName("isRead")]
        [JsonRequired]
        public bool? IsRead { get; set; }

        [JsonPropertyName("indexedAt")]
        [JsonRequired]
        public DateTime? IndexedAt { get; set; }

        [JsonPropertyName("labels")]
        public List<FishyFlip.Lexicon.Com.Atproto.Label.Label?>? Labels { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.notification.listNotifications#notification";

        public const string RecordType = "app.bsky.notification.listNotifications#notification";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Notification.Notification>(this, (JsonTypeInfo<App.Bsky.Notification.Notification>)SourceGenerationContext.Default.AppBskyNotificationNotification)!;
        }

        public static Notification FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Notification.Notification>(json, (JsonTypeInfo<App.Bsky.Notification.Notification>)SourceGenerationContext.Default.AppBskyNotificationNotification)!;
        }
    }
}
