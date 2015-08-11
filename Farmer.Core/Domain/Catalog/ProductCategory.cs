namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��Ʒ����ӳ��
    /// </summary>
    public partial class ProductCategory : BaseEntity
    {
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// ����Id
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// �Ƿ����Բ�Ʒ
        /// </summary>
        public bool IsFeaturedProduct { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
        
        /// <summary>
        /// Gets the category
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual Product Product { get; set; }

    }

}
