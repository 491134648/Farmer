using Farmer.Core.Domain;
using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 预定义产品类型
    /// </summary>
    public partial class PredefinedProductAttributeValue : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        /// 产品特性Id
        /// </summary>
        public Guid ProductAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the product attribute name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 价格调整
        /// </summary>
        public decimal PriceAdjustment { get; set; }

        /// <summary>
        /// 重量调整
        /// </summary>
        public decimal WeightAdjustment { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// 预选择
        /// </summary>
        public bool IsPreSelected { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets the product attribute
        /// </summary>
        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
