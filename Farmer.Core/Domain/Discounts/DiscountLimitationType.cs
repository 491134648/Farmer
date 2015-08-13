namespace Farmer.Core.Domain
{
    /// <summary>
    /// 优惠限制类型
    /// </summary>
    public enum DiscountLimitationType
    {
        /// <summary>
        /// None
        /// </summary>
        Unlimited = 0,
        /// <summary>
        /// 所有用户
        /// </summary>
        NTimesOnly = 15,
        /// <summary>
        ///注册用户
        /// </summary>
        NTimesPerCustomer = 25,
    }
}
