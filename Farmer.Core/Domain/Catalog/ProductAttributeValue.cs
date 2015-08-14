using Farmer.Core.Domain;
using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品特性值
    /// </summary>
    public partial class ProductAttributeValue : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        ///产品特性映射Id
        /// </summary>
        public Guid ProductAttributeMappingId { get; set; }

        /// <summary>
        /// Gets or sets the attribute value type identifier
        /// </summary>
        public AttributeValueType AttributeValueTypeId { get; set; }

        /// <summary>
        /// 关联产品IdGets or sets the associated product identifier (used only with AttributeValueType.AssociatedToProduct)
        /// </summary>
        public Guid AssociatedProductId { get; set; }

        /// <summary>
        ///产品特性名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 颜色(used with "Color squares" attribute type)
        /// </summary>
        public string ColorSquaresRgb { get; set; }

        /// <summary>
        /// 价格调整used only with AttributeValueType.Simple)
        /// </summary>
        public decimal PriceAdjustment { get; set; }

        /// <summary>
        /// 重量调整 (used only with AttributeValueType.Simple)
        /// </summary>
        public decimal WeightAdjustment { get; set; }

        /// <summary>
        ///成本(used only with AttributeValueType.Simple)
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// 数量 (used only with AttributeValueType.AssociatedToProduct)
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 预选中
        /// </summary>
        public bool IsPreSelected { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the picture (identifier) associated with this value
        /// </summary>
        public Guid PictureId { get; set; }
        public virtual Picture Picture { get; set; }
        /// <summary>
        /// Gets the product attribute mapping
        /// </summary>
        public virtual ProductAttributeMapping ProductAttributeMapping { get; set; }
    }
}
