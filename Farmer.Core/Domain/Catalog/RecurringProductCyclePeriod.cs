namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��Ʒ����ѭ��
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
        /// ����
        /// </summary>
        Session=30,
        /// <summary>
        /// Years
        /// </summary>
        Years = 40
    }
}
