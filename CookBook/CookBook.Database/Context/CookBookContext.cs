using Microsoft.EntityFrameworkCore;
using CookBook.Database.Seeder;
using CookBook.Core.Entities;
#nullable disable

namespace CookBook.Database.Context
{
    public partial class CookBookContext : DbContext
    {
        public CookBookContext()
        {
        }

        public CookBookContext(DbContextOptions<CookBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> AppUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeDetail> RecipeDetails { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=CookBook1;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("AppUser");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.PasswordHash).HasMaxLength(100);

                entity.Property(e => e.PasswordSalt).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(10);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("Recipe");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RecipeDetail>(entity =>
            {
                entity.ToTable("RecipeDetail");

                entity.Property(e => e.Measure)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rd_ingr");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rd_recep");
            });

            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Seed();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
