using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
   public partial class Affiliate:BaseEntity
    {
        public string AddressId { get; set; }
        /// <summary>
        /// 管理员评论
        /// </summary>
        public string AdminComment { get; set; }
        /// <summary>
        /// 友情单位
        /// </summary>
        public string FriendlyUrlName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public virtual Address Address { get; set; }
    }
}
