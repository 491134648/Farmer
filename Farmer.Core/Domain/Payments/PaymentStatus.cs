
namespace Farmer.Core.Domain
{
    /// <summary>
    /// 支付状态
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        ///待用户处理
        /// </summary>
        Pending = 10,
        /// <summary>
        /// 认证授权（用于货到付款等类型）
        /// </summary>
        Authorized = 20,
        /// <summary>
        /// 已支付
        /// </summary>
        Paid = 30,
        /// <summary>
        ///部分退款
        /// </summary>
        PartiallyRefunded = 35,
        /// <summary>
        /// 退款
        /// </summary>
        Refunded = 40,
        /// <summary>
        /// 作废
        /// </summary>
        Voided = 50,
    }
}
