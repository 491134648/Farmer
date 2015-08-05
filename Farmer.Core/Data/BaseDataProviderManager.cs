using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Data
{
    /// <summary>
    /// 数据提供者管理者
    /// </summary>
   public abstract class BaseDataProviderManager
    {
        /// <summary>
        /// 数据提供者管理者新实例
        /// </summary>
        /// <param name="settings">Data settings</param>
        protected BaseDataProviderManager(DataSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException("settings");
            this.Settings = settings;
        }

        /// <summary>
        /// Gets or sets settings
        /// </summary>
        protected DataSettings Settings { get; private set; }

        /// <summary>
        /// Load data provider
        /// </summary>
        /// <returns>Data provider</returns>
        public abstract IDataProvider LoadDataProvider();
    }
}
