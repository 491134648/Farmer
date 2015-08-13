namespace Farmer.Core.Domain
{
    /// <summary>
    /// �������
    /// </summary>
    public partial class MeasureDimension : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///ϵͳ�ټ���
        /// </summary>
        public string SystemKeyword { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public decimal Ratio { get; set; }

        /// <summary>
        /// ��ʾ����
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
