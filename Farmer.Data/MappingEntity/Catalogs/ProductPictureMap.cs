
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
    public partial class ProductPictureMap : FarmerEntityTypeConfiguration<ProductPicture>
    {
        public ProductPictureMap()
        {
            this.ToTable("Product_Picture_Mapping");
            this.HasKey(r => r.Id);
            
            this.HasRequired(r => r.Picture)
                .WithMany()
                .HasForeignKey(r => r.PictureId);


            this.HasRequired(r => r.Product)
                .WithMany(p => p.ProductPictures)
                .HasForeignKey(r => r.ProductId);
        }
    }
}