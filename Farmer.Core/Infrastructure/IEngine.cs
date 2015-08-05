using Farmer.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Infrastructure
{
    /// <summary>
    /// IEngine接口
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// 容器Manager
        /// </summary>
        ContainerManager ContainerManager { get; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="config">Config</param>
        void Initialize(FarmConfig config);

        /// <summary>
        /// 注入依赖
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <returns></returns>
        T Resolve<T>() where T : class;

        /// <summary>
        ///  注入对象依赖
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns></returns>
        object Resolve(Type type);

        /// <summary>
        /// 注入某类型依赖
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <returns></returns>
        T[] ResolveAll<T>();
    }
}
