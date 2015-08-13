using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 畅销产品报表
    /// </summary>
    [Serializable]
    public partial class BestsellersReportLine
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the total amount
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the total quantity
        /// </summary>
        public int TotalQuantity { get; set; }

    }
}
