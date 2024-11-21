// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    /// <summary>
    /// The subject's followers whom you also follow
    /// </summary>
    public partial class KnownFollowers : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="KnownFollowers"/> class.
        /// </summary>
        public KnownFollowers()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="KnownFollowers"/> class.
        /// </summary>
        public KnownFollowers(CBORObject obj)
        {
            if (obj["count"] is not null) this.Count = obj["count"].AsInt64Value();
            if (obj["followers"] is not null) this.Followers = obj["followers"].Values.Select(n =>new App.Bsky.Actor.ProfileViewBasic(n)).ToList();
        }

        [JsonPropertyName("count")]
        [JsonRequired]
        public long? Count { get; set; }

        [JsonPropertyName("followers")]
        [JsonRequired]
        public List<App.Bsky.Actor.ProfileViewBasic>? Followers { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#knownFollowers";

        public const string RecordType = "app.bsky.actor.defs#knownFollowers";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Actor.KnownFollowers>(this, (JsonTypeInfo<App.Bsky.Actor.KnownFollowers>)SourceGenerationContext.Default.AppBskyActorKnownFollowers)!;
        }

        public static KnownFollowers FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Actor.KnownFollowers>(json, (JsonTypeInfo<App.Bsky.Actor.KnownFollowers>)SourceGenerationContext.Default.AppBskyActorKnownFollowers)!;
        }
    }
}

