
namespace Farmer.Core.Domain
{
    /// <summary>
    /// ����ģ��
    /// </summary>
    public partial class CategoryTemplate : BaseEntity
    {
        /// <summary>
        /// ����ģ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ͼλ��
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        ///��ʾ����
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
