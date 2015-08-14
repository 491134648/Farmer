using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Farmer.Data
{
    /// <summary>
    /// DataModel FluntAPI
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
   public class FarmerEntityTypeConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity:class
    {
      protected FarmerEntityTypeConfiguration()
        {
            PostInitialize();
        }
        protected virtual void PostInitialize()
        {

        }
    }
}
