namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// 收入价格周期(for prices)
    /// </summary>
    public enum RentalPricePeriod
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
        /// 季节
        /// </summary>
        Session=30,
        /// <summary>
        /// Years
        /// </summary>
        Years = 40
    }
}
