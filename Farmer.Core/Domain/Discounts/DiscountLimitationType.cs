namespace Farmer.Core.Domain
{
    /// <summary>
    /// �Ż���������
    /// </summary>
    public enum DiscountLimitationType
    {
        /// <summary>
        /// None
        /// </summary>
        Unlimited = 0,
        /// <summary>
        /// �����û�
        /// </summary>
        NTimesOnly = 15,
        /// <summary>
        ///ע���û�
        /// </summary>
        NTimesPerCustomer = 25,
    }
}
