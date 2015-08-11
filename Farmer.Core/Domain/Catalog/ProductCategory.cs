namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品分类映射
    /// </summary>
    public partial class ProductCategory : BaseEntity
    {
        /// <summary>
        /// 产品分类
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 分类Id
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 是否特性产品
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
