// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Setting
{

    /// <summary>
    /// tools.ozone.setting Endpoint Class.
    /// </summary>
    public sealed class ToolsOzoneSetting
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneSetting"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ToolsOzoneSetting(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// List settings with optional filtering
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Setting.ListOptionsOutput?>> ListOptionsAsync (int? limit = 50, string? cursor = default, string? scope = default, string? prefix = default, List<string>? keys = default, CancellationToken cancellationToken = default)
        {
            return atp.ListOptionsAsync(limit, cursor, scope, prefix, keys, cancellationToken);
        }


        /// <summary>
        /// Delete settings by key
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Setting.RemoveOptionsOutput?>> RemoveOptionsAsync (List<string> keys, string scope, CancellationToken cancellationToken = default)
        {
            return atp.RemoveOptionsAsync(keys, scope, cancellationToken);
        }


        /// <summary>
        /// Create or update setting option
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Setting.UpsertOptionOutput?>> UpsertOptionAsync (string key, string scope, ATObject value, string? description = default, string? managerRole = default, CancellationToken cancellationToken = default)
        {
            return atp.UpsertOptionAsync(key, scope, value, description, managerRole, cancellationToken);
        }

    }
}

