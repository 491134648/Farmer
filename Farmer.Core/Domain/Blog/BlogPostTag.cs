using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 博客标签
    /// </summary>
    public partial class BlogPostTag
    {
        /// <summary>
        /// 标签名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 博客数
        /// </summary>
        public int BlogPostCount { get; set; }
    }
}
