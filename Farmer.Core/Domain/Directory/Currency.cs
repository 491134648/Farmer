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
        /// 当前代码
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        ///汇率
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// 本地显示
        /// </summary>
        public string DisplayLocale { get; set; }

        /// <summary>
        /// 自定义格式
        /// </summary>
        public string CustomFormatting { get; set; }

        /// <summary>
        /// 是否店铺限制
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
