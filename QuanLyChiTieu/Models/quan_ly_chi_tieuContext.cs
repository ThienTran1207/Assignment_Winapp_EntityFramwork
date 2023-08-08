using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace QuanLyChiTieu.Models
{
    public partial class quan_ly_chi_tieuContext : DbContext
    {
        public quan_ly_chi_tieuContext()
        {
        }

        public quan_ly_chi_tieuContext(DbContextOptions<quan_ly_chi_tieuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Outcome> Outcomes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.ToTable("income");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.DateUse)
                    .HasColumnType("date")
                    .HasColumnName("date_use");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_income_category");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.Incomes)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK_income_users");
            });

            modelBuilder.Entity<Outcome>(entity =>
            {
                entity.ToTable("outcome");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.DateUse)
                    .HasColumnType("date")
                    .HasColumnName("date_use");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Outcomes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_outcome_category");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.Outcomes)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK_outcome_users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
