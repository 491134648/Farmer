using System;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// �ظ�֧����ʷ��¼
    /// </summary>
    public partial class RecurringPaymentHistory : BaseEntity
    {
        /// <summary>
        /// Gets or sets the recurring payment identifier
        /// </summary>
        public Guid RecurringPaymentId { get; set; }

        /// <summary>
        /// Gets or sets the recurring payment identifier
        /// </summary>
        public Guid OrderId { get; set; }
       
        /// <summary>
        /// Gets the recurring payment
        /// </summary>
        public virtual RecurringPayment RecurringPayment { get; set; }

    }
}
