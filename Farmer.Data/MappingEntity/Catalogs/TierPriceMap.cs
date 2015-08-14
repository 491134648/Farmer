
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class TierPriceMap : FarmerEntityTypeConfiguration<TierPrice>
    {
        public TierPriceMap()
        {
            this.ToTable("TierPrice");
            this.HasKey(tp => tp.Id);
            this.Property(tp => tp.Price).HasPrecision(18, 4);

            this.HasRequired(tp => tp.Product)
                .WithMany(p => p.TierPrices)
                .HasForeignKey(fk => fk.ProductId);

            this.HasOptional(tp => tp.CustomerRole)
                .WithMany()
                .HasForeignKey(fk => fk.CustomerRoleId)
                .WillCascadeOnDelete(true);
        }
    }
}