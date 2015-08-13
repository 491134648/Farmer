
namespace Farmer.Core.Domain
{
    /// <summary>
    /// 税务类型
    /// </summary>
    public enum TaxBasedOn
    {
        /// <summary>
        /// 账单地址
        /// </summary>
        BillingAddress = 1,
        /// <summary>
        ///配送地址
        /// </summary>
        ShippingAddress = 2,
        /// <summary>
        /// 默认地址
        /// </summary>
        DefaultAddress = 3,
    }
}
