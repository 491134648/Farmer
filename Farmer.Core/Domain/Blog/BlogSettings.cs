using Farmer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// Blog设定
    /// </summary>
   public class BlogSettings: ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether blog is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the page size for posts
        /// </summary>
        public int PostsPageSize { get; set; }

        /// <summary>
        ///是否允许非注册用户评论
        /// </summary>
        public bool AllowNotRegisteredUsersToLeaveComments { get; set; }

        /// <summary>
        /// 新博客评论更新
        /// </summary>
        public bool NotifyAboutNewBlogComments { get; set; }

        /// <summary>
        /// Gets or sets a number of blog tags that appear in the tag cloud
        /// </summary>
        public int NumberOfTags { get; set; }

        /// <summary>
        /// Enable the blog RSS feed link in customers browser address bar
        /// </summary>
        public bool ShowHeaderRssUrl { get; set; }
    }
}
