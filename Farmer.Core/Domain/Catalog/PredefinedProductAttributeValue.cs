using Farmer.Core.Domain;
using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// Ԥ�����Ʒ����
    /// </summary>
    public partial class PredefinedProductAttributeValue : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        /// ��Ʒ����Id
        /// </summary>
        public Guid ProductAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the product attribute name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �۸����
        /// </summary>
        public decimal PriceAdjustment { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public decimal WeightAdjustment { get; set; }

        /// <summary>
        /// �ɱ�
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Ԥѡ��
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
