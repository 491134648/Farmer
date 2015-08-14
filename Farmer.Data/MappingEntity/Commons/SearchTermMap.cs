
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class SearchTermMap : FarmerEntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
