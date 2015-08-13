using System;
namespace Farmer.Core.Domain
{
    /// <summary>
    /// Represents a currency
    /// </summary>
    public partial class Currency : BaseEntity, ILocalizedEntity, IStoreMappingSupported
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ǰ����
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        ///����
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// ������ʾ
        /// </summary>
        public string DisplayLocale { get; set; }

        /// <summary>
        /// �Զ����ʽ
        /// </summary>
        public string CustomFormatting { get; set; }

        /// <summary>
        /// �Ƿ��������
        /// </summary>
        public bool LimitedToStores { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public DateTime UpdatedOn { get; set; }
    }

}
