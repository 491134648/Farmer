using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
   public partial class BlogExtensions:BaseEntity
    {
        /// <summary>
        /// 转换成标签
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns></returns>
        public static string[] ParseTags(this BlogPost blogPost)
        {
            if (blogPost == null)
                throw new ArgumentNullException("blogPost");

            var parsedTags = new List<string>();
            if (!String.IsNullOrEmpty(blogPost.Tags))
            {
                string[] tags2 = blogPost.Tags.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string tag2 in tags2)
                {
                    var tmp = tag2.Trim();
                    if (!String.IsNullOrEmpty(tmp))
                        parsedTags.Add(tmp);
                }
            }
            return parsedTags.ToArray();
        }
    }
}
