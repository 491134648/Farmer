﻿namespace Farmer.Core.Domain
{
    /// <summary>
    /// 全文字搜索模式
    /// </summary>
    public enum FulltextSearchMode
    {
        /// <summary>
        /// Exact match (using CONTAINS with prefix_term)
        /// </summary>
        ExactMatch = 0,
        /// <summary>
        /// Using CONTAINS and OR with prefix_term
        /// </summary>
        Or = 5,
        /// <summary>
        /// Using CONTAINS and AND with prefix_term
        /// </summary>
        And = 10
    }
}
