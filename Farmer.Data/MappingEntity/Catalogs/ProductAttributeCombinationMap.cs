namespace Farmer.Data.MappingEntity
{
    public partial class ProductAttributeCombinationMap : FarmerEntityTypeConfiguration<ProductAttributeCombination>
    {
        public ProductAttributeCombinationMap()
        {
            this.ToTable("ProductAttributeCombination");
            this.HasKey(r => r.Id);

            this.Property(r => r.Sku).HasMaxLength(400);
            this.Property(r => r.ManufacturerPartNumber).HasMaxLength(400);
            this.Property(r => r.Gtin).HasMaxLength(400);
            this.Property(r => r.OverriddenPrice).HasPrecision(18, 4);

            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductAttributeCombinations)
                .HasForeignKey(r => r.ProductId);
        }
    }
}