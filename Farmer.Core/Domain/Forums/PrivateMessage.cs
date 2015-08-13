using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// Represents a private message
    /// </summary>
    public partial class PrivateMessage : BaseEntity
    {
        /// <summary>
        /// Gets or sets the store identifier
        /// </summary>
        public Guid StoreId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier who sent the message
        /// </summary>
        public Guid FromCustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier who should receive the message
        /// </summary>
        public Guid ToCustomerId { get; set; }

        /// <summary>
        /// Gets or sets the subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets a value indivating whether message is read
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// Gets or sets a value indivating whether message is deleted by author
        /// </summary>
        public bool IsDeletedByAuthor { get; set; }

        /// <summary>
        /// Gets or sets a value indivating whether message is deleted by recipient
        /// </summary>
        public bool IsDeletedByRecipient { get; set; }

        /// <summary>
        /// Gets the customer who sent the message
        /// </summary>
        public virtual Customer FromCustomer { get; set; }

        /// <summary>
        /// Gets the customer who should receive the message
        /// </summary>
        public virtual Customer ToCustomer { get; set; }
    }
}
