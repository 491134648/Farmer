namespace Farmer.Core.Domain
{
    /// <summary>
    /// ����̵㷽��
    /// </summary>
    public enum ManageInventoryMethod
    {
        /// <summary>
        /// ��������
        /// </summary>
        DontManageStock = 0,
        /// <summary>
        /// ׷�ٿ���嵥
        /// </summary>
        ManageStock = 1,
        /// <summary>
        /// ���ݲ�Ʒ����׷�ٿ��
        /// </summary>
        ManageStockByAttributes = 2,
    }
}
