// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class ProfileViewDetailed : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileViewDetailed"/> class.
        /// </summary>
        public ProfileViewDetailed()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileViewDetailed"/> class.
        /// </summary>
        public ProfileViewDetailed(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["handle"] is not null) this.Handle = obj["handle"].ToATHandle();
            if (obj["displayName"] is not null) this.DisplayName = obj["displayName"].AsString();
            if (obj["description"] is not null) this.Description = obj["description"].AsString();
            if (obj["avatar"] is not null) this.Avatar = obj["avatar"].AsString();
            if (obj["banner"] is not null) this.Banner = obj["banner"].AsString();
            if (obj["followersCount"] is not null) this.FollowersCount = obj["followersCount"].AsInt64Value();
            if (obj["followsCount"] is not null) this.FollowsCount = obj["followsCount"].AsInt64Value();
            if (obj["postsCount"] is not null) this.PostsCount = obj["postsCount"].AsInt64Value();
            if (obj["associated"] is not null) this.Associated = new App.Bsky.Actor.ProfileAssociated(obj["associated"]);
            if (obj["joinedViaStarterPack"] is not null) this.JoinedViaStarterPack = new App.Bsky.Graph.StarterPackViewBasic(obj["joinedViaStarterPack"]);
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
            if (obj["viewer"] is not null) this.Viewer = new App.Bsky.Actor.ViewerState(obj["viewer"]);
            if (obj["labels"] is not null) this.Labels = obj["labels"].Values.Select(n =>new Com.Atproto.Label.Label(n)).ToList();
            if (obj["pinnedPost"] is not null) this.PinnedPost = new FishyFlip.Lexicon.Com.Atproto.Repo.StrongRef(obj["pinnedPost"]);
        }

        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        [JsonPropertyName("handle")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATHandleJsonConverter))]
        public FishyFlip.Models.ATHandle? Handle { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        [JsonPropertyName("banner")]
        public string? Banner { get; set; }

        [JsonPropertyName("followersCount")]
        public long? FollowersCount { get; set; }

        [JsonPropertyName("followsCount")]
        public long? FollowsCount { get; set; }

        [JsonPropertyName("postsCount")]
        public long? PostsCount { get; set; }

        [JsonPropertyName("associated")]
        public App.Bsky.Actor.ProfileAssociated? Associated { get; set; }

        [JsonPropertyName("joinedViaStarterPack")]
        public App.Bsky.Graph.StarterPackViewBasic? JoinedViaStarterPack { get; set; }

        [JsonPropertyName("indexedAt")]
        public DateTime? IndexedAt { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("viewer")]
        public App.Bsky.Actor.ViewerState? Viewer { get; set; }

        [JsonPropertyName("labels")]
        public List<Com.Atproto.Label.Label>? Labels { get; set; }

        [JsonPropertyName("pinnedPost")]
        public Com.Atproto.Repo.StrongRef? PinnedPost { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#profileViewDetailed";

        public const string RecordType = "app.bsky.actor.defs#profileViewDetailed";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Actor.ProfileViewDetailed>(this, (JsonTypeInfo<App.Bsky.Actor.ProfileViewDetailed>)SourceGenerationContext.Default.AppBskyActorProfileViewDetailed)!;
        }

        public static ProfileViewDetailed FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Actor.ProfileViewDetailed>(json, (JsonTypeInfo<App.Bsky.Actor.ProfileViewDetailed>)SourceGenerationContext.Default.AppBskyActorProfileViewDetailed)!;
        }
    }
}

