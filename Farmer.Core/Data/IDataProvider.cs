using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Data
{
    /// <summary>
    /// 数据提供者接口
    /// </summary>
    public interface IDataProvider
    {
        /// <summary>
        ///初始化连接接口
        /// </summary>
        void InitConnectionFactory();

        /// <summary>
        /// 设置数据库初始化
        /// </summary>
        void SetDatabaseInitializer();

        /// <summary>
        /// 初始化数据库
        /// </summary>
        void InitDatabase();

        /// <summary>
        ///是否支持存储过程
        /// </summary>
        bool StoredProceduredSupported { get; }

        /// <summary>
        /// Gets a support database parameter object (used by stored procedures)
        /// </summary>
        /// <returns>Parameter</returns>
        DbParameter GetParameter();
    }
}
