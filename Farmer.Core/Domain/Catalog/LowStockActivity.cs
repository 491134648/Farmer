namespace Farmer.Core.Domain
{
    /// <summary>
    /// 低库存激活
    /// </summary>
    public enum LowStockActivity
    {
        /// <summary>
        /// Nothing
        /// </summary>
        Nothing = 0,
        /// <summary>
        /// 禁用购买按钮
        /// </summary>
        DisableBuyButton = 1,
        /// <summary>
        /// 不发布
        /// </summary>
        Unpublish = 2,
    }
}
