
namespace Farmer.Core.Domain
{
    /// <summary>
    ///������ģ��
    /// </summary>
    public partial class ManufacturerTemplate : BaseEntity
    {
        /// <summary>
        /// Gets or sets the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ͼλ��
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
