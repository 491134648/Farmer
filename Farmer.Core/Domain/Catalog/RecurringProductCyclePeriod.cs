namespace Farmer.Core.Domain
{
    /// <summary>
    /// 产品周期循环
    /// </summary>
    public enum RecurringProductCyclePeriod:int
    {
        /// <summary>
        /// Days
        /// </summary>
        Days = 0,
        /// <summary>
        /// Weeks
        /// </summary>
        Weeks = 10,
        /// <summary>
        /// Months
        /// </summary>
        Months = 20,
        /// <summary>
        /// 季度
        /// </summary>
        Session=30,
        /// <summary>
        /// Years
        /// </summary>
        Years = 40
    }
}
