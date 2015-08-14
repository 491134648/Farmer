using Farmer.Core.Domain;
namespace Farmer.Data.MappingEntity
{
    public partial class AddressAttributeValueMap : FarmerEntityTypeConfiguration<AddressAttributeValue>
    {
        public AddressAttributeValueMap()
        {
            this.ToTable("AddressAttributeValue");
            this.HasKey(r => r.Id);
            this.Property(r=> r.Name).IsRequired().HasMaxLength(400);

            this.HasRequired(r => r.AddressAttribute)
                .WithMany(r=> r.AddressAttributeValues)
                .HasForeignKey(fk =>fk.AddressAttributeId);
        }
    }
}