// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

using FishyFlip.Lexicon.Com.Atproto.Repo;

namespace FishyFlip.Lexicon
{

    /// <summary>
    /// Extension methods for app.bsky.actor.
    /// </summary>
    public static class BlueskyActorExtensions
    {

        /// <summary>
        /// Create a Profile record.
        /// </summary>
        public static Task<Result<CreateRecordOutput?>> CreateProfileAsync(this FishyFlip.Lexicon.App.Bsky.Actor.BlueskyActor atp, FishyFlip.Models.ATIdentifier repo, FishyFlip.Lexicon.App.Bsky.Actor.Profile record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.CreateRecordAsync(repo, "app.bsky.actor.profile", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a Profile record.
        /// </summary>
        public static Task<Result<CreateRecordOutput?>> CreateProfileAsync(this FishyFlip.Lexicon.App.Bsky.Actor.BlueskyActor atp, string? displayName = default, string? description = default, Blob? avatar = default, Blob? banner = default, Com.Atproto.Label.SelfLabels? labels = default, Com.Atproto.Repo.StrongRef? joinedViaStarterPack = default, Com.Atproto.Repo.StrongRef? pinnedPost = default, DateTime? createdAt = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.App.Bsky.Actor.Profile();
            record.DisplayName = displayName;
            record.Description = description;
            record.Avatar = avatar;
            record.Banner = banner;
            record.Labels = labels;
            record.JoinedViaStarterPack = joinedViaStarterPack;
            record.PinnedPost = pinnedPost;
            record.CreatedAt = createdAt;
            return atp.ATProtocol.CreateRecordAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.actor.profile", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a Profile record.
        /// </summary>
        public static Task<Result<DeleteRecordOutput?>> DeleteProfileAsync(this FishyFlip.Lexicon.App.Bsky.Actor.BlueskyActor atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.DeleteRecordAsync(repo, "app.bsky.actor.profile", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a Profile record.
        /// </summary>
        public static Task<Result<PutRecordOutput?>> PutProfileAsync(this FishyFlip.Lexicon.App.Bsky.Actor.BlueskyActor atp, FishyFlip.Models.ATIdentifier repo, string rkey, FishyFlip.Lexicon.App.Bsky.Actor.Profile record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.PutRecordAsync(repo, "app.bsky.actor.profile", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List Profile records.
        /// </summary>
        public static Task<Result<ListRecordsOutput?>> ListProfilesAsync(this FishyFlip.Lexicon.App.Bsky.Actor.BlueskyActor atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.ListRecordsAsync(repo, "app.bsky.actor.profile", limit, cursor, reverse, cancellationToken);
        }
    }
}

