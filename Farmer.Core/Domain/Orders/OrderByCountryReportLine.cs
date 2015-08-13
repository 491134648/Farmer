using System;

namespace Nop.Core.Domain.Orders
{
    /// <summary>
    /// 订单国别报表
    /// </summary>
    public partial class OrderByCountryReportLine
    {
        /// <summary>
        /// Country identifier; null for unknow country
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the number of orders
        /// </summary>
        public int TotalOrders { get; set; }

        /// <summary>
        /// Gets or sets the order total summary
        /// </summary>
        public decimal SumOrders { get; set; }
    }
}
