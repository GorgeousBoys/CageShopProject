using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessObject.Models
{
    public partial class CageShopUniContext : DbContext
    {
        public CageShopUniContext()
        {
        }

        public CageShopUniContext(DbContextOptions<CageShopUniContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cage> Cages { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;User ID=sa;Password=12345;Database=CageShopUni;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cage>(entity =>
            {
                entity.ToTable("Cage");

                entity.Property(e => e.CageId).HasColumnName("CageID");

                entity.Property(e => e.CageImg)
                    .HasColumnType("image")
                    .HasColumnName("CageIMG");

                entity.Property(e => e.CageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.Material).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Cages)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Cage__CategoryID__59063A47");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.Cages)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK__Cage__DiscountID__59FA5E80");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.Discount1)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("Discount");

                entity.Property(e => e.DiscountFinish).HasColumnType("date");

                entity.Property(e => e.DiscountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountStart).HasColumnType("date");

                entity.Property(e => e.DiscountStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.CageId).HasColumnName("CageID");

                entity.Property(e => e.FeedBackContent).HasColumnType("text");

                entity.Property(e => e.FeedBackName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Cage)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.CageId)
                    .HasConstraintName("FK__Feedback__CageID__5AEE82B9");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Feedback__OrderI__5BE2A6F2");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK__Feedback__Rating__5CD6CB2B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Feedback__UserID__5DCAEF64");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderAdress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Payment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserID__60A75C0F");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK__OrderDet__135C314DF7E5026F");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.CageId).HasColumnName("CageID");

                entity.Property(e => e.DetailPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Cage)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.CageId)
                    .HasConstraintName("FK__OrderDeta__CageI__5EBF139D");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__5FB337D6");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.Property(e => e.RatingId).HasColumnName("RatingID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserImg)
                    .HasColumnType("image")
                    .HasColumnName("UserIMG");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleID__619B8048");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
