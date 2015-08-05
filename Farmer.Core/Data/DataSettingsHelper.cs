using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Data
{
    /// <summary>
    /// Data设定Helper
    /// </summary>
   public partial class DataSettingsHelper
    {
        //数据库是否安装
        private static bool? _databaseIsInstalled;

        /// <summary>
        ///返回一个值表示数据库是否安装
        /// </summary>
        /// <returns></returns>
        public static bool DatabaseIsInstalled()
        {
            if (!_databaseIsInstalled.HasValue)
            {
                var manager = new DataSettingsManager();
                var settings = manager.LoadSettings();
                _databaseIsInstalled = settings != null && !String.IsNullOrEmpty(settings.DataConnectionString);
            }
            return _databaseIsInstalled.Value;
        }

        /// <summary>
        /// 重设缓存
        /// </summary>
        public static void ResetCache()
        {
            _databaseIsInstalled = null;
        }
    }
}
