
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class CrossSellProductMap : FarmerEntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            this.ToTable("CrossSellProduct");
            this.HasKey(c => c.Id);
        }
    }
}