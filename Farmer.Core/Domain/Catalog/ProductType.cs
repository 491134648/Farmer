namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// ��Ʒ����
    /// </summary>
    public enum ProductType:int
    {
        /// <summary>
        /// ��ͨ��Ʒ
        /// </summary>
        SimpleProduct = 5,
        /// <summary>
        /// �Ź���Ʒ(product with variants)
        /// </summary>
        GroupedProduct = 10,
        /// <summary>
        /// ��ɱ
        /// </summary>
        SkilProduct=15,
        /// <summary>
        /// Ԥ��
        /// </summary>
        ReserveProduct=20,
        /// <summary>
        /// ����
        /// </summary>
        SchedProduct=25
    }
}
