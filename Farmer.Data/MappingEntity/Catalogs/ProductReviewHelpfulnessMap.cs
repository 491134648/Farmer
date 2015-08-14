
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductReviewHelpfulnessMap : FarmerEntityTypeConfiguration<ProductReviewHelpfulness>
    {
        public ProductReviewHelpfulnessMap()
        {
            this.ToTable("ProductReviewHelpfulness");
            this.HasKey(r => r.Id);
            this.HasOptional(r => r.Customer).WithMany().HasForeignKey(fk => fk.CustomerId);
            this.HasRequired(prh => prh.ProductReview)
                .WithMany(r => r.ProductReviewHelpfulnessEntries)
                .HasForeignKey(prh => prh.ProductReviewId).WillCascadeOnDelete(true);
        }
    }
}