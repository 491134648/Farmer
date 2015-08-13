namespace Farmer.Core.Domain
{
    /// <summary>
    /// 优惠类型
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// 订单满减
        /// </summary>
        AssignedToOrderTotal = 1,
        /// <summary>
        /// 产品优惠
        /// </summary>
        AssignedToSkus = 2,
        /// <summary>
        ///类目优惠券
        /// </summary>
        AssignedToCategories = 5,
        /// <summary>
        /// 制造商优惠券
        /// </summary>
        AssignedToManufacturers = 6,
        /// <summary>
        ///物流优惠券
        /// </summary>
        AssignedToShipping = 10,
        /// <summary>
        /// 订单总价优惠l
        /// </summary>
        AssignedToOrderSubTotal = 20,
    }
}
