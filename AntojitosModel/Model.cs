namespace AntojitosModel
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Models")
        {
        }

        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_Category> Product_Category { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rol_Actions> Rol_Actions { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Sales_Detail> Sales_Detail { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<User_Rol> User_Rol { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actions>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Actions>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<Actions>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Actions>()
                .HasMany(e => e.Rol_Actions)
                .WithRequired(e => e.Actions)
                .HasForeignKey(e => e.ActionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Surnames)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Identification)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentMethods>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMethods>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.PaymentMethods)
                .HasForeignKey(e => e.PaymentMethodId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales_Detail)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product_Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Product_Category)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Rol_Actions)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.User_Rol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Iva)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.NetoWorth)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sales>()
                .HasMany(e => e.Sales_Detail)
                .WithRequired(e => e.Sales)
                .HasForeignKey(e => e.SaleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<States>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.States)
                .HasForeignKey(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.States)
                .HasForeignKey(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.User_Rol)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
