using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// �������۲�Ʒ
    /// </summary>
    public partial class CrossSellProduct : BaseEntity
    {
        /// <summary>
        /// ��Ʒ1
        /// </summary>
        public Guid ProductId1 { get; set; }

        /// <summary>
        /// Gets or sets the second product identifier
        /// </summary>
        public Guid ProductId2 { get; set; }
    }

}
