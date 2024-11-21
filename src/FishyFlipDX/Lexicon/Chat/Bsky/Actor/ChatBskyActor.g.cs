// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Actor
{

    /// <summary>
    /// chat.bsky.actor Endpoint Class.
    /// </summary>
    public sealed class ChatBskyActor
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyActor"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ChatBskyActor(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Generated endpoint for chat.bsky.actor.exportAccountData
        /// </summary>
        public Task<Result<Success?>> ExportAccountDataAsync (CancellationToken cancellationToken = default)
        {
            return atp.ExportAccountDataAsync(cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.actor.deleteAccount
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Actor.DeleteAccountOutput?>> DeleteAccountAsync (CancellationToken cancellationToken = default)
        {
            return atp.DeleteAccountAsync(cancellationToken);
        }

    }
}

