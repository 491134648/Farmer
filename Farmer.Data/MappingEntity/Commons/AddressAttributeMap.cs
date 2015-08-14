
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class AddressAttributeMap : FarmerEntityTypeConfiguration<AddressAttribute>
    {
        public AddressAttributeMap()
        {
            this.ToTable("AddressAttribute");
            this.HasKey(aa => aa.Id);
            this.Property(r => r.AttributeControlType).HasColumnType("int");
            this.Property(aa => aa.Name).IsRequired().HasMaxLength(400);

            this.Property(aa => aa.AttributeControlType).HasColumnType("int");
        }
    }
}