
namespace Farmer.Core.Domain
{
    /// <summary>
    /// ˰������
    /// </summary>
    public enum TaxBasedOn
    {
        /// <summary>
        /// �˵���ַ
        /// </summary>
        BillingAddress = 1,
        /// <summary>
        ///���͵�ַ
        /// </summary>
        ShippingAddress = 2,
        /// <summary>
        /// Ĭ�ϵ�ַ
        /// </summary>
        DefaultAddress = 3,
    }
}
