using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Domain
{
    /// <summary>
    /// 店铺映射支持
    /// </summary>
    public interface IStoreMappingSupported
    {
        bool LimitedToStores { get; set; }
    }
}
