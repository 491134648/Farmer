namespace Farmer.Core.Domain
{
    /// <summary>
    /// �����Ƿ�����
    /// </summary>
    public partial class ProductReviewHelpfulness : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product review identifier
        /// </summary>
        public string ProductReviewId { get; set; }

        /// <summary>
        /// A value indicating whether a review a helpful
        /// </summary>
        public bool WasHelpful { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual ProductReview ProductReview { get; set; }
    }
}
