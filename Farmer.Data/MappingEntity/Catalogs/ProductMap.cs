
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductMap : FarmerEntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Product");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
            this.Property(p => p.MetaKeywords).HasMaxLength(400);
            this.Property(p => p.MetaTitle).HasMaxLength(400);
            this.Property(p => p.Sku).HasMaxLength(400);
            this.Property(p => p.ManufacturerPartNumber).HasMaxLength(400);
            this.Property(p => p.Gtin).HasMaxLength(400);
            this.Property(p => p.AdditionalShippingCharge).HasPrecision(18, 4);
            this.Property(p => p.Price).HasPrecision(18, 4);
            this.Property(p => p.OldPrice).HasPrecision(18, 4);
            this.Property(p => p.ProductCost).HasPrecision(18, 4);
            this.Property(p => p.SpecialPrice).HasPrecision(18, 4);
            this.Property(p => p.MinimumCustomerEnteredPrice).HasPrecision(18, 4);
            this.Property(p => p.MaximumCustomerEnteredPrice).HasPrecision(18, 4);
            this.Property(p => p.Weight).HasPrecision(18, 4);
            this.Property(p => p.Length).HasPrecision(18, 4);
            this.Property(p => p.Width).HasPrecision(18, 4);
            this.Property(p => p.Height).HasPrecision(18, 4);
            this.Property(p => p.RequiredProductIds).HasMaxLength(1000);
            this.Property(p => p.AllowedQuantities).HasMaxLength(1000);
            this.Property(p => p.BasepriceAmount).HasPrecision(18, 4);
            this.Property(p => p.BasepriceBaseAmount).HasPrecision(18, 4);

            this.Property(p => p.ProductType).HasColumnType("int");
            this.Property(p => p.BackorderMode).HasColumnType("int");
            this.Property(p => p.DownloadActivationType).HasColumnType("int");
            this.Property(p => p.GiftCardType).HasColumnType("int");
            this.Property(p => p.LowStockActivity).HasColumnType("int");
            this.Property(p => p.ManageInventoryMethod).HasColumnType("int");
            this.Property(p => p.RecurringCyclePeriod).HasColumnType("int");
            this.Property(p => p.RentalPricePeriod).HasColumnType("int");

            this.HasMany(p => p.ProductTags)
                .WithMany(pt => pt.Products)
                .Map(m => m.ToTable("Product_ProductTag_Mapping"));
        }
    }
}