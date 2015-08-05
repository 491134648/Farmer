using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Infrastructure
{
    /// <summary>
    /// 类型发现者
    /// </summary>
   public interface ITypeFinder
    {
        /// <summary>
        /// 获得程序集
        /// </summary>
        /// <returns></returns>
        IList<Assembly> GetAssemblies();
        /// <summary>
        /// 发现指定类型的class
        /// </summary>
        /// <param name="assignTypeFrom"></param>
        /// <param name="onlyConcreteClasses">仅包含具体对象</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreteClasses = true);
        /// <summary>
        /// 指定程序集中的指定类型
        /// </summary>
        /// <param name="assignTypeFrom">来源类</param>
        /// <param name="assemblies">程序集</param>
        /// <param name="onlyConcreteClasses">仅包含具体类</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true);
        /// <summary>
        /// 发现某类型的的类集合
        /// </summary>
        /// <typeparam name="T">仅包含具体</typeparam>
        /// <param name="onlyConcreteClasses"></param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType<T>(bool onlyConcreteClasses = true);

        /// <summary>
        /// 指定程序集中的某类型
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="assemblies">程序集List</param>
        /// <param name="onlyConcreteClasses">仅包含具体</param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType<T>(IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true);
    }
}
