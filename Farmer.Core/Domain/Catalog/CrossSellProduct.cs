using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 交叉销售产品
    /// </summary>
    public partial class CrossSellProduct : BaseEntity
    {
        /// <summary>
        /// 产品1
        /// </summary>
        public Guid ProductId1 { get; set; }

        /// <summary>
        /// Gets or sets the second product identifier
        /// </summary>
        public Guid ProductId2 { get; set; }
    }

}
