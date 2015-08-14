
namespace Farmer.Data.MappingEntity
{
    public partial class ProductSpecificationAttributeMap : FarmerEntityTypeConfiguration<ProductSpecificationAttribute>
    {
        public ProductSpecificationAttributeMap()
        {
            this.ToTable("Product_SpecificationAttribute_Mapping");
            this.HasKey(r => r.Id);

            this.Property(r => r.CustomValue).HasMaxLength(4000);

            this.Property(r => r.AttributeType).HasColumnType("int");

            this.HasRequired(r => r.SpecificationAttributeOption)
                .WithMany()
                .HasForeignKey(fk => fk.SpecificationAttributeOptionId);


            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductSpecificationAttributes)
                .HasForeignKey(fk => fk.ProductId);
        }
    }
}