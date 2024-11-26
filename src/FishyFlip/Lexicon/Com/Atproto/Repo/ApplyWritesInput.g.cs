// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class ApplyWritesInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyWritesInput"/> class.
        /// </summary>
        /// <param name="repo">The handle or DID of the repo (aka, current account).</param>
        /// <param name="validate">Can be set to 'false' to skip Lexicon schema validation of record data across all operations, 'true' to require it, or leave unset to validate only for known Lexicons.</param>
        /// <param name="writes">
        /// Union Types:
        /// #create
        /// #update
        /// #delete
        /// </param>
        /// <param name="swapCommit">If provided, the entire operation will fail if the current repo commit CID does not match this value. Used to prevent conflicting repo mutations.</param>
        public ApplyWritesInput(FishyFlip.Models.ATIdentifier? repo = default, bool? validate = default, List<ATObject>? writes = default, string? swapCommit = default)
        {
            this.Repo = repo;
            this.Validate = validate;
            this.Writes = writes;
            this.SwapCommit = swapCommit;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyWritesInput"/> class.
        /// </summary>
        public ApplyWritesInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyWritesInput"/> class.
        /// </summary>
        public ApplyWritesInput(CBORObject obj)
        {
            if (obj["repo"] is not null) this.Repo = obj["repo"].ToATIdentifier();
            if (obj["validate"] is not null) this.Validate = obj["validate"].AsBoolean();
            if (obj["writes"] is not null) this.Writes = obj["writes"].Values.Select(n =>n.ToATObject()).ToList();
            if (obj["swapCommit"] is not null) this.SwapCommit = obj["swapCommit"].AsString();
        }

        /// <summary>
        /// Gets or sets the repo.
        /// The handle or DID of the repo (aka, current account).
        /// </summary>
        [JsonPropertyName("repo")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATIdentifierJsonConverter))]
        public FishyFlip.Models.ATIdentifier? Repo { get; set; }

        /// <summary>
        /// Gets or sets the validate.
        /// Can be set to 'false' to skip Lexicon schema validation of record data across all operations, 'true' to require it, or leave unset to validate only for known Lexicons.
        /// </summary>
        [JsonPropertyName("validate")]
        public bool? Validate { get; set; }

        /// <summary>
        /// Gets or sets the writes.
        /// Union Types:
        /// <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.Create"/> (com.atproto.repo.applyWrites#create)
        /// <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.Update"/> (com.atproto.repo.applyWrites#update)
        /// <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.Delete"/> (com.atproto.repo.applyWrites#delete)
        /// </summary>
        [JsonPropertyName("writes")]
        [JsonRequired]
        public List<ATObject>? Writes { get; set; }

        /// <summary>
        /// Gets or sets the swapCommit.
        /// If provided, the entire operation will fail if the current repo commit CID does not match this value. Used to prevent conflicting repo mutations.
        /// </summary>
        [JsonPropertyName("swapCommit")]
        public string? SwapCommit { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.applyWrites#ApplyWritesInput";

        public const string RecordType = "com.atproto.repo.applyWrites#ApplyWritesInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Repo.ApplyWritesInput>(this, (JsonTypeInfo<Com.Atproto.Repo.ApplyWritesInput>)SourceGenerationContext.Default.ComAtprotoRepoApplyWritesInput)!;
        }

        public static ApplyWritesInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Repo.ApplyWritesInput>(json, (JsonTypeInfo<Com.Atproto.Repo.ApplyWritesInput>)SourceGenerationContext.Default.ComAtprotoRepoApplyWritesInput)!;
        }
    }
}
