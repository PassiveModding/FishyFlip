// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

using FishyFlip.Lexicon.Com.Atproto.Repo;

namespace FishyFlip.Lexicon.App.Bsky.Labeler
{

    /// <summary>
    /// Extension methods for app.bsky.labeler.
    /// </summary>
    public static class ATProtoLabelerExtensions
    {

        /// <summary>
        /// Create a Service record.
        /// </summary>
        public static Task<Result<CreateRecordOutput?>> CreateServiceAsync(this FishyFlip.ATProtocol atp, App.Bsky.Labeler.Service record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a Service record.
        /// </summary>
        public static Task<Result<CreateRecordOutput?>> CreateServiceAsync(this FishyFlip.ATProtocol atp, App.Bsky.Labeler.LabelerPolicies? policies, DateTime? createdAt, Com.Atproto.Label.SelfLabels? labels = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.App.Bsky.Labeler.Service();
            record.Policies = policies;
            record.Labels = labels;
            record.CreatedAt = createdAt;
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a Service record.
        /// </summary>
        public static Task<Result<DeleteRecordOutput?>> DeleteServiceAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.DeleteRecordAsync(repo, "app.bsky.labeler.service", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a Service record.
        /// </summary>
        public static Task<Result<PutRecordOutput?>> PutServiceAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, App.Bsky.Labeler.Service record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.PutRecordAsync(repo, "app.bsky.labeler.service", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List Service records.
        /// </summary>
        public static Task<Result<ListRecordsOutput?>> ListServicesAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(repo, "app.bsky.labeler.service", limit, cursor, reverse, cancellationToken);
        }
    }
}

