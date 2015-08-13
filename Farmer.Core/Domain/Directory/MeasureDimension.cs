namespace Farmer.Core.Domain
{
    /// <summary>
    /// 测量规格
    /// </summary>
    public partial class MeasureDimension : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///系统官架子
        /// </summary>
        public string SystemKeyword { get; set; }

        /// <summary>
        /// 比率
        /// </summary>
        public decimal Ratio { get; set; }

        /// <summary>
        /// 显示排序
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
