using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 评论是否有用
    /// </summary>
    public partial class ProductReviewHelpfulness : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product review identifier
        /// </summary>
        public Guid ProductReviewId { get; set; }

        /// <summary>
        /// A value indicating whether a review a helpful
        /// </summary>
        public bool WasHelpful { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual ProductReview ProductReview { get; set; }
    }
}
