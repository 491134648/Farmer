
using Farmer.Core.Domain;

namespace Farmer.Data.MappingEntity
{
   public class BlogCommentMap:FarmerEntityTypeConfiguration<BlogComment>
    {
        public BlogCommentMap()
        {
            this.ToTable("BlogComment");
            this.HasKey(r => r.Id);
            this.HasRequired(r => r.BlogPost).WithMany(p => p.BlogComments).HasForeignKey(fk => fk.BlogPostId).WillCascadeOnDelete(false);
            this.HasRequired(r => r.Customer).WithMany().HasForeignKey(fk => fk.CustomerId);
        }
    }
}
