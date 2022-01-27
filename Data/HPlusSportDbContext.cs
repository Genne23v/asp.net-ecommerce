using HPlus.Ecommerce.Data.Entities;
using System.Data.Entity;

<<<<<<< HEAD
namespace HPlus.Ecommerce.Data
=======
namespace HPlus_App.Data
>>>>>>> 6976662a5ab6e3db8a0d4789396607527501b474
{
    public partial class HPlusSportDbContext : DbContext
    {
        public HPlusSportDbContext() : base("name=HPlusSport") { }

        public virtual DbSet<CartProduct> CartProducts { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasMany(e => e.CartProducts)
                .WithRequired(e => e.Cart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.FullPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.CurrentPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartProducts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
