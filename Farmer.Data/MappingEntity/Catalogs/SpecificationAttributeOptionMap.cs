
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class SpecificationAttributeOptionMap : FarmerEntityTypeConfiguration<SpecificationAttributeOption>
    {
        public SpecificationAttributeOptionMap()
        {
            this.ToTable("SpecificationAttributeOption");
            this.HasKey(r => r.Id);
            this.Property(r => r.Name).IsRequired();
            
            this.HasRequired(r => r.SpecificationAttribute)
                .WithMany(sa => sa.SpecificationAttributeOptions)
                .HasForeignKey(r => r.SpecificationAttributeId);
        }
    }
}