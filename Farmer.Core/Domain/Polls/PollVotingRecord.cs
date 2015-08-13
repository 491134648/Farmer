using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// Í¶Æ±¼ÇÂ¼
    /// </summary>
    public partial class PollVotingRecord : BaseEntity
    {
        /// <summary>
        /// Gets or sets the poll answer identifier
        /// </summary>
        public Guid PollAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the poll answer
        /// </summary>
        public virtual PollAnswer PollAnswer { get; set; }
    }
}