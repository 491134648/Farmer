using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
   public class BlogComment
    {
        /// <summary>
        /// 会员Id
        /// </summary>
        public string CustomerId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string CommentText { get; set; }
        /// <summary>
        /// 博客Id
        /// </summary>
        public string BlogPostId { get; set; }
        /// <summary>
        /// 会员信息
        /// </summary>
        public virtual Customer Customer { get; set; }
        /// <summary>
        /// 博客内容
        /// </summary>
        public virtual BlogPost BlogPost { get; set; }
        public virtual IList<Picture> AttrPicture { get; set; }
    }
}
