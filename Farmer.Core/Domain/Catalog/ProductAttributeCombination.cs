using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��Ʒ�������
    /// </summary>
    public partial class ProductAttributeCombination : BaseEntity
    {
        /// <summary>
        /// ��ƷId
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// ����xml
        /// </summary>
        public string AttributesXml { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// �Ƿ��������
        /// </summary>
        public bool AllowOutOfStockOrders { get; set; }
        
        /// <summary>
        /// Gets or sets the SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// �����̱��
        /// </summary>
        public Guid ManufacturerPartNumber { get; set; }

        /// <summary>
        /// Gets or sets the Global Trade Item Number (GTIN). These identifiers include UPC (in North America), EAN (in Europe), JAN (in Japan), and ISBN (for books).
        /// </summary>
        public string Gtin { get; set; }

        /// <summary>
        ///��д�۸�
        /// </summary>
        public decimal? OverriddenPrice { get; set; }

        /// <summary>
        /// Gets or sets the quantity when admin should be notified
        /// </summary>
        public int NotifyAdminForQuantityBelow { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual Product Product { get; set; }

    }
}
