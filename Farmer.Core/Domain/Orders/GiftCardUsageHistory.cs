using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// Represents a gift card usage history entry
    /// </summary>
    public partial class GiftCardUsageHistory : BaseEntity
    {
        /// <summary>
        /// Gets or sets the gift card identifier
        /// </summary>
        public Guid GiftCardId { get; set; }

        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public Guid UsedWithOrderId { get; set; }

        /// <summary>
        /// Gets or sets the used value (amount)
        /// </summary>
        public decimal UsedValue { get; set; }

        /// <summary>
        /// Gets the gift card
        /// </summary>
        public virtual GiftCard GiftCard { get; set; }

        /// <summary>
        /// Gets the gift card
        /// </summary>
        public virtual Order UsedWithOrder { get; set; }
    }
}
