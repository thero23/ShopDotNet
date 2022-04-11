﻿// <auto-generated />
using System;
using IS.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IS.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220411080215_Update1")]
    partial class Update1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IS.DAL.Entities.BasketEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("IS.DAL.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("IS.DAL.Entities.CurrencyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sign")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BYN",
                            Sign = "BYN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "USD",
                            Sign = "$"
                        },
                        new
                        {
                            Id = 3,
                            Name = "EUR",
                            Sign = "€"
                        });
                });

            modelBuilder.Entity("IS.DAL.Entities.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IS.DAL.Entities.OrderProductEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersProducts");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProductBasketEntity", b =>
                {
                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("BasketId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsBaskets");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProviderCountryId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ProviderCountryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProviderCountryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProviderCountries");
                });

            modelBuilder.Entity("IS.DAL.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("BasketId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "d9ad2745-01df-41e3-9951-27f7f09bc150",
                            ConcurrencyStamp = "33144623-4fed-4f32-99e7-25cbec62ea16",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "6390ea22-cc5e-4894-b5d8-dab3bc1482b7",
                            ConcurrencyStamp = "a51a5968-3970-4ddf-8f97-75a5bc941f1f",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("IS.DAL.Entities.BasketEntity", b =>
                {
                    b.HasOne("IS.DAL.Entities.UserEntity", "User")
                        .WithOne("Basket")
                        .HasForeignKey("IS.DAL.Entities.BasketEntity", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IS.DAL.Entities.OrderEntity", b =>
                {
                    b.HasOne("IS.DAL.Entities.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IS.DAL.Entities.OrderProductEntity", b =>
                {
                    b.HasOne("IS.DAL.Entities.OrderEntity", "Order")
                        .WithMany("OrderProductEntities")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IS.DAL.Entities.ProductEntity", "Product")
                        .WithMany("OrderProductEntities")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProductBasketEntity", b =>
                {
                    b.HasOne("IS.DAL.Entities.BasketEntity", "Basket")
                        .WithMany("ProductBasketEntities")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IS.DAL.Entities.ProductEntity", "Product")
                        .WithMany("ProductBasketEntities")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProductEntity", b =>
                {
                    b.HasOne("IS.DAL.Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IS.DAL.Entities.CurrencyEntity", "Currency")
                        .WithMany("Products")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IS.DAL.Entities.ProviderCountryEntity", "ProviderCountry")
                        .WithMany("Products")
                        .HasForeignKey("ProviderCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Currency");

                    b.Navigation("ProviderCountry");
                });

            modelBuilder.Entity("IS.DAL.Entities.BasketEntity", b =>
                {
                    b.Navigation("ProductBasketEntities");
                });

            modelBuilder.Entity("IS.DAL.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IS.DAL.Entities.CurrencyEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IS.DAL.Entities.OrderEntity", b =>
                {
                    b.Navigation("OrderProductEntities");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProductEntity", b =>
                {
                    b.Navigation("OrderProductEntities");

                    b.Navigation("ProductBasketEntities");
                });

            modelBuilder.Entity("IS.DAL.Entities.ProviderCountryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("IS.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("Basket");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
