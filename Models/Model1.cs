using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace E_WORKERS.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Table_Admin> Table_Admin { get; set; }
        public virtual DbSet<Table_Categories> Table_Categories { get; set; }
        public virtual DbSet<Table_Categories_Product> Table_Categories_Product { get; set; }
        public virtual DbSet<Table_City> Table_City { get; set; }
        public virtual DbSet<Table_Customer> Table_Customer { get; set; }
        public virtual DbSet<Table_Feedback> Table_Feedback { get; set; }
        public virtual DbSet<Table_Order> Table_Order { get; set; }
        public virtual DbSet<Table_OrderDetails> Table_OrderDetails { get; set; }
        public virtual DbSet<Table_Products> Table_Products { get; set; }
        public virtual DbSet<Table_Service> Table_Service { get; set; }
        public virtual DbSet<Table_Worker> Table_Worker { get; set; }
        public virtual DbSet<Table_Worker_Linked_Services> Table_Worker_Linked_Services { get; set; }
        public virtual DbSet<Table_Order_Assign> Table_Order_Assign { get; set; }
        public virtual DbSet<Table_Worker_Order_Booked> Table_Worker_Order_Booked { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_Categories_Product>()
                .HasMany(e => e.Table_Products)
                .WithRequired(e => e.Table_Categories_Product)
                .HasForeignKey(e => e.Category_Product_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_City>()
                .HasMany(e => e.Table_Customer)
                .WithRequired(e => e.Table_City)
                .HasForeignKey(e => e.City_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_City>()
                .HasMany(e => e.Table_Worker)
                .WithRequired(e => e.Table_City)
                .HasForeignKey(e => e.City_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Customer>()
                .HasMany(e => e.Table_Feedback)
                .WithRequired(e => e.Table_Customer)
                .HasForeignKey(e => e.Customer_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Customer>()
                .HasMany(e => e.Table_Order)
                .WithRequired(e => e.Table_Customer)
                .HasForeignKey(e => e.Customer_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Customer>()
                .HasMany(e => e.Table_Worker_Order_Booked)
                .WithRequired(e => e.Table_Customer)
                .HasForeignKey(e => e.Customer_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Feedback>()
                .Property(e => e.Feedback_Rating)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Table_Order>()
                .HasMany(e => e.Table_OrderDetails)
                .WithRequired(e => e.Table_Order)
                .HasForeignKey(e => e.Order_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_OrderDetails>()
                .Property(e => e.Products_Saleprice)
                .HasPrecision(18, 0);
            modelBuilder.Entity<Table_OrderDetails>()
                .Property(e => e.Products_Purchaseprice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Table_Products>()
                .Property(e => e.Products_SalePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Table_Products>()
                .Property(e => e.Products_PurchasePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Table_Service>()
                .Property(e => e.Service_Charges)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Table_Service>()
                .HasMany(e => e.Table_Categories)
                .WithRequired(e => e.Table_Service)
                .HasForeignKey(e => e.Service_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Service>()
                .HasMany(e => e.Table_Worker_Linked_Services)
                .WithRequired(e => e.Table_Service)
                .HasForeignKey(e => e.Service_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Service>()
                .HasMany(e => e.Table_Worker_Order_Booked)
                .WithRequired(e => e.Table_Service)
                .HasForeignKey(e => e.Service_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Worker>()
                .HasMany(e => e.Table_Order)
                .WithRequired(e => e.Table_Worker)
                .HasForeignKey(e => e.Worker_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Worker>()
                .HasMany(e => e.Table_Order_Assign)
                .WithRequired(e => e.Table_Worker)
                .HasForeignKey(e => e.Worker_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_Worker>()
                .HasMany(e => e.Table_Worker_Linked_Services)
                .WithRequired(e => e.Table_Worker)
                .HasForeignKey(e => e.Worker_FID)
                .WillCascadeOnDelete(false);
        }
    }
}
