
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductCategoryMap : FarmerEntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            this.ToTable("Product_Category_Mapping");
            this.HasKey(r => r.Id);
            this.HasRequired(r => r.Category)
                .WithMany()
                .HasForeignKey(r => r.CategoryId);
            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(fk=> fk.ProductId);
        }
    }
}