
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductManufacturerMap : FarmerEntityTypeConfiguration<ProductManufacturer>
    {
        public ProductManufacturerMap()
        {
            this.ToTable("Product_Manufacturer_Mapping");
            this.HasKey(r => r.Id);
            
            this.HasRequired(r => r.Manufacturer)
                .WithMany()
                .HasForeignKey(r => r.ManufacturerId);


            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductManufacturers)
                .HasForeignKey(r => r.ProductId);
        }
    }
}