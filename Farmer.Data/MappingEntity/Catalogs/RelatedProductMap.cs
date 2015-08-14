using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class RelatedProductMap : FarmerEntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            this.ToTable("RelatedProduct");
            this.HasKey(c => c.Id);
        }
    }
}