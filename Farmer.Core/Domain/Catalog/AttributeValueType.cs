using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 特性值类型枚举
    /// </summary>
    public enum AttributeValueType
    {
        /// <summary>
        /// 简单
        /// </summary>
        Simple = 0,
        /// <summary>
        /// 关联产品 (used when configuring bundled products)
        /// </summary>
        AssociatedToProduct = 10,
    }
}
