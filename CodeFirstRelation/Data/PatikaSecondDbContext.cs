
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data.UserEntity
{

    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=217.182.78.155;Port=5433;Username=patika;Password=patika;Database=PatikaSecondDb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne<User>(b => b.User)  //PostEntity sınıfı ile ilişkilendirme yapılıyor.
                .WithMany(a => a.Posts)           //UserEntity sınıfı ile ilişkilendirme yapılıyor.
                .HasForeignKey(b => b.UserId);    //PostEntity sınıfındaki UserId alanı ile ilişkilendirme yapılıyor.
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration());

        }


    }
}






