namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品排序枚举
    /// </summary>
    public enum ProductSortingEnum
    {
        /// <summary>
        /// Position (display order)
        /// </summary>
        Position = 0,
        /// <summary>
        /// 名称升序
        /// </summary>
        NameAsc = 5,
        /// <summary>
        /// 名称降序
        /// </summary>
        NameDesc = 6,
        /// <summary>
        ///价格升序
        /// </summary>
        PriceAsc = 10,
        /// <summary>
        /// 价格降序
        /// </summary>
        PriceDesc = 11,
        /// <summary>
        ///日期升序
        /// </summary>
        CreatedOnAsc = 15,
        /// <summary>
        /// 日期降序
        /// </summary>
        CreateOnDesc=16
    }
}