// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{

    /// <summary>
    /// tools.ozone.moderation Endpoint Class.
    /// </summary>
    public sealed class ToolsOzoneModeration
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModeration"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ToolsOzoneModeration(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Take a moderation action on an actor.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.ModEventView?>> EmitEventAsync (ATObject @event, ATObject subject, FishyFlip.Models.ATDid createdBy, List<string>? subjectBlobCids = default, CancellationToken cancellationToken = default)
        {
            return atp.EmitEventAsync(@event, subject, createdBy, subjectBlobCids, cancellationToken);
        }


        /// <summary>
        /// Get details about a moderation event.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.ModEventViewDetail?>> GetEventAsync (int id, CancellationToken cancellationToken = default)
        {
            return atp.GetEventAsync(id, cancellationToken);
        }


        /// <summary>
        /// Get details about a record.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.RecordViewDetail?>> GetRecordAsync (FishyFlip.Models.ATUri uri, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(uri, cid, cancellationToken);
        }


        /// <summary>
        /// Get details about some records.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.GetRecordsOutput?>> GetRecordsAsync (List<FishyFlip.Models.ATUri> uris, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordsAsync(uris, cancellationToken);
        }


        /// <summary>
        /// Get details about a repository.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.RepoViewDetail?>> GetRepoAsync (FishyFlip.Models.ATDid did, CancellationToken cancellationToken = default)
        {
            return atp.GetRepoAsync(did, cancellationToken);
        }


        /// <summary>
        /// Get details about some repositories.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.GetReposOutput?>> GetReposAsync (List<FishyFlip.Models.ATDid> dids, CancellationToken cancellationToken = default)
        {
            return atp.GetReposAsync(dids, cancellationToken);
        }


        /// <summary>
        /// List moderation events related to a subject.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.QueryEventsOutput?>> QueryEventsAsync (List<string>? types = default, FishyFlip.Models.ATDid? createdBy = default, string? sortDirection = default, DateTime? createdAfter = default, DateTime? createdBefore = default, string? subject = default, List<string>? collections = default, string? subjectType = default, bool? includeAllUserRecords = default, int? limit = 50, bool? hasComment = default, string? comment = default, List<string>? addedLabels = default, List<string>? removedLabels = default, List<string>? addedTags = default, List<string>? removedTags = default, List<string>? reportTypes = default, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.QueryEventsAsync(types, createdBy, sortDirection, createdAfter, createdBefore, subject, collections, subjectType, includeAllUserRecords, limit, hasComment, comment, addedLabels, removedLabels, addedTags, removedTags, reportTypes, cursor, cancellationToken);
        }


        /// <summary>
        /// View moderation statuses of subjects (record or repo).
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.QueryStatusesOutput?>> QueryStatusesAsync (bool? includeAllUserRecords = default, string? subject = default, string? comment = default, DateTime? reportedAfter = default, DateTime? reportedBefore = default, DateTime? reviewedAfter = default, DateTime? hostingDeletedAfter = default, DateTime? hostingDeletedBefore = default, DateTime? hostingUpdatedAfter = default, DateTime? hostingUpdatedBefore = default, List<string>? hostingStatuses = default, DateTime? reviewedBefore = default, bool? includeMuted = default, bool? onlyMuted = default, string? reviewState = default, List<string>? ignoreSubjects = default, FishyFlip.Models.ATDid? lastReviewedBy = default, string? sortField = default, string? sortDirection = default, bool? takendown = default, bool? appealed = default, int? limit = 50, List<string>? tags = default, List<string>? excludeTags = default, string? cursor = default, List<string>? collections = default, string? subjectType = default, CancellationToken cancellationToken = default)
        {
            return atp.QueryStatusesAsync(includeAllUserRecords, subject, comment, reportedAfter, reportedBefore, reviewedAfter, hostingDeletedAfter, hostingDeletedBefore, hostingUpdatedAfter, hostingUpdatedBefore, hostingStatuses, reviewedBefore, includeMuted, onlyMuted, reviewState, ignoreSubjects, lastReviewedBy, sortField, sortDirection, takendown, appealed, limit, tags, excludeTags, cursor, collections, subjectType, cancellationToken);
        }


        /// <summary>
        /// Find repositories based on a search term.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Moderation.SearchReposOutput?>> SearchReposAsync (string? q = default, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.SearchReposAsync(q, limit, cursor, cancellationToken);
        }

    }
}

