
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductAttributeValueMap : FarmerEntityTypeConfiguration<ProductAttributeValue>
    {
        public ProductAttributeValueMap()
        {
            this.ToTable("ProductAttributeValue");
            this.HasKey(r => r.Id);
            this.Property(r => r.Name).IsRequired().HasMaxLength(400);
            this.Property(r => r.ColorSquaresRgb).HasMaxLength(100);
            this.Property(r => r.PriceAdjustment).HasPrecision(18, 4);
            this.Property(r => r.WeightAdjustment).HasPrecision(18, 4);
            this.Property(r => r.Cost).HasPrecision(18, 4);
            this.Property(r =>r.AttributeValueTypeId).HasColumnType("int");
            this.HasOptional(r => r.Picture).WithMany().HasForeignKey(fk => fk.PictureId);
            this.HasRequired(r => r.ProductAttributeMapping)
                .WithMany(pam => pam.ProductAttributeValues)
                .HasForeignKey(fk => fk.ProductAttributeMappingId);
        }
    }
}