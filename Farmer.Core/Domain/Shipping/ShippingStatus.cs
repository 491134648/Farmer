namespace Farmer.Core.Domain
{
    /// <summary>
    /// ����״̬
    /// </summary>
    public enum ShippingStatus
    {
        /// <summary>
        /// ��������
        /// </summary>
        ShippingNotRequired = 10,
        /// <summary>
        /// ��δ����
        /// </summary>
        NotYetShipped = 20,
        /// <summary>
        /// ��������
        /// </summary>
        PartiallyShipped = 25,
        /// <summary>
        /// ������
        /// </summary>
        Shipped = 30,
        /// <summary>
        /// �������
        /// </summary>
        Delivered = 40,
    }
}
