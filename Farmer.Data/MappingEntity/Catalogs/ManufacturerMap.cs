
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ManufacturerMap : FarmerEntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerMap()
        {
            this.ToTable("Manufacturer");
            this.HasKey(m => m.Id);
            this.Property(m => m.Name).IsRequired().HasMaxLength(400);
            this.Property(m => m.MetaKeywords).HasMaxLength(400);
            this.Property(m => m.MetaTitle).HasMaxLength(400);
            this.Property(m => m.PriceRanges).HasMaxLength(400);
            this.Property(m => m.PageSizeOptions).HasMaxLength(200);
        }
    }
}