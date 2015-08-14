using Farmer.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Data.MappingEntity
{
    public partial class BlogPostMap:FarmerEntityTypeConfiguration<BlogPost>
    {
        public BlogPostMap()
        {
            this.ToTable("BlogPost");
            this.HasKey(r => r.Id);
            this.Property(r => r.Title).IsRequired();
            this.Property(r => r.Body).IsRequired();
            this.Property(r => r.MetaKeyWords).HasMaxLength(400);
            this.Property(r => r.MetaTitle).HasMaxLength(400);

            this.HasRequired(r =>r.Language)
                .WithMany()
                .HasForeignKey(r => r.LanguageId).WillCascadeOnDelete(true);
        }
    }
}
