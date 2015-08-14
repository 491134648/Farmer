
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductTagMap : FarmerEntityTypeConfiguration<ProductTag>
    {
        public ProductTagMap()
        {
            this.ToTable("ProductTag");
            this.HasKey(r => r.Id);
            this.Property(r => r.Name).IsRequired().HasMaxLength(400);
        }
    }
}