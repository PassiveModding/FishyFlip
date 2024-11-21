// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class HiddenPostsPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenPostsPref"/> class.
        /// </summary>
        public HiddenPostsPref(List<FishyFlip.Models.ATUri>? items = default)
        {
            this.Items = items;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenPostsPref"/> class.
        /// </summary>
        public HiddenPostsPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenPostsPref"/> class.
        /// </summary>
        public HiddenPostsPref(CBORObject obj)
        {
            if (obj["items"] is not null) this.Items = obj["items"].Values.Select(n =>n.ToATUri()!).ToList();
        }

        /// <summary>
        /// A list of URIs of posts the account owner has hidden.
        /// </summary>
        [JsonPropertyName("items")]
        [JsonRequired]
        public List<FishyFlip.Models.ATUri>? Items { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#hiddenPostsPref";

        public const string RecordType = "app.bsky.actor.defs#hiddenPostsPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Actor.HiddenPostsPref>(this, (JsonTypeInfo<App.Bsky.Actor.HiddenPostsPref>)SourceGenerationContext.Default.AppBskyActorHiddenPostsPref)!;
        }

        public static HiddenPostsPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Actor.HiddenPostsPref>(json, (JsonTypeInfo<App.Bsky.Actor.HiddenPostsPref>)SourceGenerationContext.Default.AppBskyActorHiddenPostsPref)!;
        }
    }
}

