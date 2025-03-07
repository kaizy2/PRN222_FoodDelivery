﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20250114041925_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            CartId = 1,
                            ProductId = 1,
                            Quantity = 2,
                            UserId = 1
                        },
                        new
                        {
                            CartId = 2,
                            ProductId = 2,
                            Quantity = 3,
                            UserId = 1
                        },
                        new
                        {
                            CartId = 3,
                            ProductId = 1,
                            Quantity = 1,
                            UserId = 2
                        },
                        new
                        {
                            CartId = 4,
                            ProductId = 2,
                            Quantity = 4,
                            UserId = 2
                        },
                        new
                        {
                            CartId = 5,
                            ProductId = 1,
                            Quantity = 5,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6669),
                            ImageUrl = "fruits.jpg",
                            IsActive = true,
                            Name = "Fruits"
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6686),
                            ImageUrl = "vegetables.jpg",
                            IsActive = true,
                            Name = "Vegetables"
                        });
                });

            modelBuilder.Entity("Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailsId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderDetailsId = 1,
                            OrderDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6895),
                            OrderNo = "ORD001",
                            PaymentId = 1,
                            ProductId = 1,
                            Quantity = 2,
                            Status = "Pending",
                            UserId = 1
                        },
                        new
                        {
                            OrderDetailsId = 2,
                            OrderDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6897),
                            OrderNo = "ORD002",
                            PaymentId = 1,
                            ProductId = 2,
                            Quantity = 3,
                            Status = "Completed",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNo")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("CvvNo")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PaymentMode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            Address = "123 Main St",
                            CardNo = "1234567812345678",
                            CvvNo = "123",
                            ExpiryDate = new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Doe",
                            PaymentMode = "Credit Card"
                        });
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6817),
                            Description = "Fresh red apples",
                            ImageUrl = "apple.jpg",
                            IsActive = true,
                            Name = "Apple",
                            Price = 1.50m,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6824),
                            Description = "Organic carrots",
                            ImageUrl = "carrot.jpg",
                            IsActive = true,
                            Name = "Carrot",
                            Price = 0.80m,
                            Quantity = 200
                        });
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6847),
                            Email = "admin@example.com",
                            IsEmailVerified = false,
                            Name = "Admin User",
                            Password = "admin123",
                            Role = "Admin",
                            Username = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedDate = new DateTime(2025, 1, 14, 11, 19, 24, 939, DateTimeKind.Local).AddTicks(6850),
                            Email = "user@example.com",
                            IsEmailVerified = false,
                            Name = "Regular User",
                            Password = "user123",
                            Role = "User",
                            Username = "user"
                        });
                });

            modelBuilder.Entity("Models.Cart", b =>
                {
                    b.HasOne("Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.HasOne("Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
