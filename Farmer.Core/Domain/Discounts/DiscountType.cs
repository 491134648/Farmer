namespace Farmer.Core.Domain
{
    /// <summary>
    /// �Ż�����
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// ��������
        /// </summary>
        AssignedToOrderTotal = 1,
        /// <summary>
        /// ��Ʒ�Ż�
        /// </summary>
        AssignedToSkus = 2,
        /// <summary>
        ///��Ŀ�Ż�ȯ
        /// </summary>
        AssignedToCategories = 5,
        /// <summary>
        /// �������Ż�ȯ
        /// </summary>
        AssignedToManufacturers = 6,
        /// <summary>
        ///�����Ż�ȯ
        /// </summary>
        AssignedToShipping = 10,
        /// <summary>
        /// �����ܼ��Ż�l
        /// </summary>
        AssignedToOrderSubTotal = 20,
    }
}
