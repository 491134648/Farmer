
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class PredefinedProductAttributeValueMap : FarmerEntityTypeConfiguration<PredefinedProductAttributeValue>
    {
        public PredefinedProductAttributeValueMap()
        {
            this.ToTable("PredefinedProductAttributeValue");
            this.HasKey(pav => r.Id);
            this.Property(r => r.Name).IsRequired().HasMaxLength(400);

            this.Property(r => r.PriceAdjustment).HasPrecision(18, 4);
            this.Property(r => r.WeightAdjustment).HasPrecision(18, 4);
            this.Property(r => r.Cost).HasPrecision(18, 4);

            this.HasRequired(r => r.ProductAttribute)
                .WithMany()
                .HasForeignKey(r => r.ProductAttributeId);
        }
    }
}