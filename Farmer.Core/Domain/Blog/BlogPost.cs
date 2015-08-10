using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
    public partial class BlogPost:BaseEntity, ISlugSupported, IStoreMappingSupported
    {
        private ICollection<BlogComment> blogComments;
        public string LanguageId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string BodyOverview { get; set; }
        /// <summary>
        /// 允许评论
        /// </summary>
        public bool AllowComments { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 元关键词
        /// </summary>
        public string MetaKeyWords { get; set; }
        /// <summary>
        /// 元描述
        /// </summary>
        public string MetaDescription { get; set; }
        /// <summary>
        /// 元标签
        /// </summary>
        public string MetaTitle { get; set; }
        /// <summary>
        /// 限制店铺
        /// </summary>
        public bool LimitedToStores { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public virtual ICollection<BlogComment> BlogComments
        {
            get { return blogComments ?? (blogComments = new List<BlogComment>()); }
            protected set { blogComments = value; }
        }
    }
}
