namespace Farmer.Core.Domain
{
    /// <summary>
    ///论坛搜索类型
    /// </summary>
    public enum ForumSearchType
    {
        /// <summary>
        ///所有
        /// </summary>
        All = 0,
        /// <summary>
        /// 主题标题
        /// </summary>
        TopicTitlesOnly = 10,
        /// <summary>
        ///仅内容文字
        /// </summary>
        PostTextOnly = 20,
    }
}
