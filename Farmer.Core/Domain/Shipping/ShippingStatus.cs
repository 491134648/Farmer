namespace Farmer.Core.Domain
{
    /// <summary>
    /// 配送状态
    /// </summary>
    public enum ShippingStatus
    {
        /// <summary>
        /// 无需配送
        /// </summary>
        ShippingNotRequired = 10,
        /// <summary>
        /// 尚未发货
        /// </summary>
        NotYetShipped = 20,
        /// <summary>
        /// 分批配送
        /// </summary>
        PartiallyShipped = 25,
        /// <summary>
        /// 配送中
        /// </summary>
        Shipped = 30,
        /// <summary>
        /// 交互完成
        /// </summary>
        Delivered = 40,
    }
}
