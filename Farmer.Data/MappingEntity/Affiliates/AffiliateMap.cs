using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class AffiliateMap:FarmerEntityTypeConfiguration<Affiliate>
    {
        public AffiliateMap()
        {
            this.ToTable("Affiliate");
            this.HasKey(a => a.Id);
            this.HasRequired(a => a.Address).WithMany().HasForeignKey(x => x.AddressId).WillCascadeOnDelete(false);
        }
      
    }
}
