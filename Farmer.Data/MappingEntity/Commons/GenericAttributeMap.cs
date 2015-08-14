
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class GenericAttributeMap : FarmerEntityTypeConfiguration<GenericAttribute>
    {
        public GenericAttributeMap()
        {
            this.ToTable("GenericAttribute");
            this.HasKey(r => r.Id);

            this.Property(r => r.KeyGroup).IsRequired().HasMaxLength(400);
            this.Property(r => r.Key).IsRequired().HasMaxLength(400);
            this.Property(r => r.Value).IsRequired();
        }
    }
}