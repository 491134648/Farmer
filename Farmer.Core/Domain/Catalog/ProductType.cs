namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// 产品类型
    /// </summary>
    public enum ProductType:int
    {
        /// <summary>
        /// 普通产品
        /// </summary>
        SimpleProduct = 5,
        /// <summary>
        /// 团购产品(product with variants)
        /// </summary>
        GroupedProduct = 10,
        /// <summary>
        /// 秒杀
        /// </summary>
        SkilProduct=15,
        /// <summary>
        /// 预定
        /// </summary>
        ReserveProduct=20,
        /// <summary>
        /// 定制
        /// </summary>
        SchedProduct=25
    }
}
