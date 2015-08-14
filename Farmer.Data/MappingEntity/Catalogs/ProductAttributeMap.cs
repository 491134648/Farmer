using Farmer.Core.Domain;
namespace Farmer.Data.MappingEntity
{
    public partial class ProductAttributeMap : FarmerEntityTypeConfiguration<ProductAttribute>
    {
        public ProductAttributeMap()
        {
            this.ToTable("ProductAttribute");
            this.HasKey(r => r.Id);
            this.Property(r => r.Name).IsRequired();
        }
    }
}