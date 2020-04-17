using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProductService.Entities
{
    public partial class AdventureWorks2017Context : DbContext
    {
        public AdventureWorks2017Context()
        {
        }

        public AdventureWorks2017Context(DbContextOptions<AdventureWorks2017Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product1> Product1 { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductReview1> ProductReview1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8K4E0L7;Database=AdventureWorks2017;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ProductSubcategoryId).HasColumnName("ProductSubcategoryID");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SellEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellStartDate).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(5);

                entity.Property(e => e.SizeUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.StandardCost).HasColumnType("money");

                entity.Property(e => e.Style)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Product1>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_Product_ProductID");

                entity.ToTable("Product", "Production");

                entity.HasComment("Products sold or used in the manfacturing of sold products.");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Product_Name")
                    .IsUnique();

                entity.HasIndex(e => e.ProductNumber)
                    .HasName("AK_Product_ProductNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Product_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Primary key for Product records.");

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("H = High, M = Medium, L = Low");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .HasComment("Product color.");

                entity.Property(e => e.DaysToManufacture).HasComment("Number of days required to manufacture the product.");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was discontinued.");

                entity.Property(e => e.FinishedGoodsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is not a salable item. 1 = Product is salable.");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("money")
                    .HasComment("Selling price.");

                entity.Property(e => e.MakeFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the product.");

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("R = Road, M = Mountain, T = Touring, S = Standard");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasComment("Unique product identification number.");

                entity.Property(e => e.ProductSubcategoryId)
                    .HasColumnName("ProductSubcategoryID")
                    .HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");

                entity.Property(e => e.ReorderPoint).HasComment("Inventory level that triggers a purchase order or work order. ");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                entity.Property(e => e.SafetyStockLevel).HasComment("Minimum inventory quantity. ");

                entity.Property(e => e.SellEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was no longer available for sale.");

                entity.Property(e => e.SellStartDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was available for sale.");

                entity.Property(e => e.Size)
                    .HasMaxLength(5)
                    .HasComment("Product size.");

                entity.Property(e => e.SizeUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Unit of measure for Size column.");

                entity.Property(e => e.StandardCost)
                    .HasColumnType("money")
                    .HasComment("Standard cost of the product.");

                entity.Property(e => e.Style)
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasComment("W = Womens, M = Mens, U = Universal");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Product weight.");

                entity.Property(e => e.WeightUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength()
                    .HasComment("Unit of measure for Weight column.");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comments).HasMaxLength(3850);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductReviewId)
                    .HasColumnName("ProductReviewID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewerName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductReview1>(entity =>
            {
                entity.HasKey(e => e.ProductReviewId)
                    .HasName("PK_ProductReview_ProductReviewID");

                entity.ToTable("ProductReview", "Production");

                entity.HasComment("Customer reviews of products they have purchased.");

                entity.HasIndex(e => new { e.Comments, e.ProductId, e.ReviewerName })
                    .HasName("IX_ProductReview_ProductID_Name");

                entity.Property(e => e.ProductReviewId)
                    .HasColumnName("ProductReviewID")
                    .HasComment("Primary key for ProductReview records.");

                entity.Property(e => e.Comments)
                    .HasMaxLength(3850)
                    .HasComment("Reviewer's comments");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Reviewer's e-mail address.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                entity.Property(e => e.Rating).HasComment("Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date review was submitted.");

                entity.Property(e => e.ReviewerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Name of the reviewer.");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReview1)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
