
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductReviewMap : FarmerEntityTypeConfiguration<ProductReview>
    {
        public ProductReviewMap()
        {
            this.ToTable("ProductReview");
            this.HasKey(r => r.Id);

            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductReviews)
                .HasForeignKey(r => r.ProductId);

            this.HasRequired(r => r.Customer)
                .WithMany()
                .HasForeignKey(fk => fk.CustomerId);
        }
    }
}