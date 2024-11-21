// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class MutedWordsPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MutedWordsPref"/> class.
        /// </summary>
        public MutedWordsPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MutedWordsPref"/> class.
        /// </summary>
        public MutedWordsPref(CBORObject obj)
        {
            if (obj["items"] is not null) this.Items = obj["items"].Values.Select(n =>new App.Bsky.Actor.MutedWord(n)).ToList();
        }

        /// <summary>
        /// A list of words the account owner has muted.
        /// </summary>
        [JsonPropertyName("items")]
        [JsonRequired]
        public List<App.Bsky.Actor.MutedWord>? Items { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#mutedWordsPref";

        public const string RecordType = "app.bsky.actor.defs#mutedWordsPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Actor.MutedWordsPref>(this, (JsonTypeInfo<App.Bsky.Actor.MutedWordsPref>)SourceGenerationContext.Default.AppBskyActorMutedWordsPref)!;
        }

        public static MutedWordsPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Actor.MutedWordsPref>(json, (JsonTypeInfo<App.Bsky.Actor.MutedWordsPref>)SourceGenerationContext.Default.AppBskyActorMutedWordsPref)!;
        }
    }
}

