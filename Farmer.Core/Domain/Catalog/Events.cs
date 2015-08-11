namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��Ʒ����ʱ��
    /// </summary>
    public class ProductReviewApprovedEvent
    {
        private readonly ProductReview _productReview;
        /// <summary>
        /// ��Ʒ�����¼���ʵ��
        /// </summary>
        /// <param name="productReview"></param>
        public ProductReviewApprovedEvent(ProductReview productReview)
        {
            this._productReview = productReview;
        }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public ProductReview ProductReview
        {
            get { return _productReview; }
        }
    }
}