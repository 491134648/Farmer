namespace Nop.Core.Domain
{
    /// <summary>
    /// 下载激活类型
    /// </summary>
    public enum DownloadActivationType
    {
        /// <summary>
        /// 订单支付时
        /// </summary>
        WhenOrderIsPaid = 1,
        /// <summary>
        /// 手动
        /// </summary>
        Manually = 10,
    }
}
