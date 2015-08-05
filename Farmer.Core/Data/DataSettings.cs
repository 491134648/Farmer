using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Data
{
    /// <summary>
    /// 数据设定
    /// </summary>
   public partial class DataSettings
    {
        /// <summary>
        /// DataSettings新实例
        /// </summary>
        public DataSettings()
        {
            RawDataSettings = new Dictionary<string, string>();
        }

        /// <summary>
        /// 数据库提供程序
        /// </summary>
        public string DataProvider { get; set; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string DataConnectionString { get; set; }

        /// <summary>
        /// 原始设定文件
        /// </summary>
        public IDictionary<string, string> RawDataSettings { get; private set; }

        /// <summary>
        /// 进入的信息是否有效
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return !String.IsNullOrEmpty(this.DataProvider) && !String.IsNullOrEmpty(this.DataConnectionString);
        }
    }
}
