using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Event
{
    /// <summary>
    /// 删除的实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class EntityDeleted<T> where T:BaseEntity
    {
        public EntityDeleted(T entity)
        {
            this.Entity = entity;
        }
        public T Entity { get; private set; }
    }
}
