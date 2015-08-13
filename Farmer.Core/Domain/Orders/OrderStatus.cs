namespace Farmer.Core.Domain
{
    /// <summary>
    /// ����״̬��ס
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// ���û�����
        /// </summary>
        Pending = 10,
        /// <summary>
        /// ���̼Ҵ���
        /// </summary>
        PreProsess=12,
        /// <summary>
        /// ��ӡ����
        /// </summary>
        Printer=15,
        /// <summary>
        /// �����
        /// </summary>
        Packing=18,
        /// <summary>
        /// ׼������
        /// </summary>
        PreShipping=19,
        /// <summary>
        /// ����
        /// </summary>
        Shipping = 20,
        /// <summary>
        /// �������
        /// </summary>
        Shippinged=25,
        /// <summary>
        /// �ͻ��ջ�
        /// </summary>
        CustomerToOk = 28,
        /// <summary>
        /// �������
        /// </summary>
        Complete = 30,
        /// <summary>
        /// �����رգ���ʱδ֧��������ԭ��
        /// </summary>
        Closeed=35,
        /// <summary>
        /// ȡ��
        /// </summary>
        Cancelled = 40
    }
}
