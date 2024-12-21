using CodeFirstRelation.Data.UserEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CodeFirstRelation.Data
{
    public class PostEntityConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Content).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.User).WithMany(x => x.Posts).HasForeignKey(x => x.UserId);
        }
    }
    

    
}
