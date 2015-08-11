
namespace Farmer.Core.Domain
{
    /// <summary>
    /// 分类模板
    /// </summary>
    public partial class CategoryTemplate : BaseEntity
    {
        /// <summary>
        /// 分类模板名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 视图位置
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        ///显示排序
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
