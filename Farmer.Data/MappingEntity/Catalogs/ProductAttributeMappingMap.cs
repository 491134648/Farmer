using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductAttributeMappingMap : FarmerEntityTypeConfiguration<ProductAttributeMapping>
    {
        public ProductAttributeMappingMap()
        {
            this.ToTable("Product_ProductAttribute_Mapping");
            this.HasKey(r => r.Id);
            this.Property(r => r.AttributeControlTypeId).HasColumnType("int");
            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductAttributeMappings)
                .HasForeignKey(r => r.ProductId);
            this.HasRequired(r => r.ProductAttribute)
                .WithMany()
                .HasForeignKey(r => r.ProductAttributeId);
        }
    }
}