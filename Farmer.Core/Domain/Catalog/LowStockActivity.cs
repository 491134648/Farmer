namespace Farmer.Core.Domain
{
    /// <summary>
    /// �Ϳ�漤��
    /// </summary>
    public enum LowStockActivity
    {
        /// <summary>
        /// Nothing
        /// </summary>
        Nothing = 0,
        /// <summary>
        /// ���ù���ť
        /// </summary>
        DisableBuyButton = 1,
        /// <summary>
        /// ������
        /// </summary>
        Unpublish = 2,
    }
}
