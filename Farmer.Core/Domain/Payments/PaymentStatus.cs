
namespace Farmer.Core.Domain
{
    /// <summary>
    /// ֧��״̬
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        ///���û�����
        /// </summary>
        Pending = 10,
        /// <summary>
        /// ��֤��Ȩ�����ڻ�����������ͣ�
        /// </summary>
        Authorized = 20,
        /// <summary>
        /// ��֧��
        /// </summary>
        Paid = 30,
        /// <summary>
        ///�����˿�
        /// </summary>
        PartiallyRefunded = 35,
        /// <summary>
        /// �˿�
        /// </summary>
        Refunded = 40,
        /// <summary>
        /// ����
        /// </summary>
        Voided = 50,
    }
}
