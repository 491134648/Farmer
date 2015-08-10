using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Event
{
    /// <summary>
    /// 插入实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class EntityInserted<T> where T :class
    {
        public EntityInserted(T entity)
        {
            this.Entity = entity;
        }
        public T Entity { get; private set; }
    }
}
