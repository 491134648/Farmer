namespace Farmer.Core.Domain
{
    /// <summary>
    /// 订单状态陪住
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 待用户处理
        /// </summary>
        Pending = 10,
        /// <summary>
        /// 待商家处理
        /// </summary>
        PreProsess=12,
        /// <summary>
        /// 打印订单
        /// </summary>
        Printer=15,
        /// <summary>
        /// 打包中
        /// </summary>
        Packing=18,
        /// <summary>
        /// 准备出库
        /// </summary>
        PreShipping=19,
        /// <summary>
        /// 出库
        /// </summary>
        Shipping = 20,
        /// <summary>
        /// 配送完成
        /// </summary>
        Shippinged=25,
        /// <summary>
        /// 客户收货
        /// </summary>
        CustomerToOk = 28,
        /// <summary>
        /// 订单完成
        /// </summary>
        Complete = 30,
        /// <summary>
        /// 订单关闭（超时未支付或其他原因）
        /// </summary>
        Closeed=35,
        /// <summary>
        /// 取消
        /// </summary>
        Cancelled = 40
    }
}
