namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品评论时间
    /// </summary>
    public class ProductReviewApprovedEvent
    {
        private readonly ProductReview _productReview;
        /// <summary>
        /// 产品评论事件新实例
        /// </summary>
        /// <param name="productReview"></param>
        public ProductReviewApprovedEvent(ProductReview productReview)
        {
            this._productReview = productReview;
        }
        /// <summary>
        /// 产品评论
        /// </summary>
        public ProductReview ProductReview
        {
            get { return _productReview; }
        }
    }
}