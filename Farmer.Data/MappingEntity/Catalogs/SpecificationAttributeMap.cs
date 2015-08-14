using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class SpecificationAttributeMap : FarmerEntityTypeConfiguration<SpecificationAttribute>
    {
        public SpecificationAttributeMap()
        {
            this.ToTable("SpecificationAttribute");
            this.HasKey(r => r.Id);
            this.Property(r => r.Name).IsRequired();
        }
    }
}