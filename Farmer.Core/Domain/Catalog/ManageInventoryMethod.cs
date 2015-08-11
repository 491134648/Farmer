namespace Farmer.Core.Domain
{
    /// <summary>
    /// 库存盘点方法
    /// </summary>
    public enum ManageInventoryMethod
    {
        /// <summary>
        /// 不管理库存
        /// </summary>
        DontManageStock = 0,
        /// <summary>
        /// 追踪库存清单
        /// </summary>
        ManageStock = 1,
        /// <summary>
        /// 依据产品特性追踪库存
        /// </summary>
        ManageStockByAttributes = 2,
    }
}
