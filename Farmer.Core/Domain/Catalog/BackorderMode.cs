using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 延期交货Represents a backorder mode
    /// </summary>
    public enum BackorderMode
    {
        /// <summary>
        /// 禁止延期
        /// </summary>
        NoBackorders = 0,
        /// <summary>
        /// 允许库存小于0
        /// </summary>
        AllowQtyBelow0 = 1,
        /// <summary>
        /// 允许库存小于0并通知
        /// </summary>
        AllowQtyBelow0AndNotifyCustomer = 2,
    }
}
