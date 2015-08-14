using Farmer.Core.Domain;
using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��Ʒ����ֵ
    /// </summary>
    public partial class ProductAttributeValue : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        ///��Ʒ����ӳ��Id
        /// </summary>
        public Guid ProductAttributeMappingId { get; set; }

        /// <summary>
        /// Gets or sets the attribute value type identifier
        /// </summary>
        public AttributeValueType AttributeValueTypeId { get; set; }

        /// <summary>
        /// ������ƷIdGets or sets the associated product identifier (used only with AttributeValueType.AssociatedToProduct)
        /// </summary>
        public Guid AssociatedProductId { get; set; }

        /// <summary>
        ///��Ʒ��������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ɫ(used with "Color squares" attribute type)
        /// </summary>
        public string ColorSquaresRgb { get; set; }

        /// <summary>
        /// �۸����used only with AttributeValueType.Simple)
        /// </summary>
        public decimal PriceAdjustment { get; set; }

        /// <summary>
        /// �������� (used only with AttributeValueType.Simple)
        /// </summary>
        public decimal WeightAdjustment { get; set; }

        /// <summary>
        ///�ɱ�(used only with AttributeValueType.Simple)
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// ���� (used only with AttributeValueType.AssociatedToProduct)
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Ԥѡ��
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
