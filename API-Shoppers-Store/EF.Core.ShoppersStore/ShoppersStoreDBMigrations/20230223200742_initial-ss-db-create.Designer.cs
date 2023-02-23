﻿// <auto-generated />
using System;
using EF.Core.ShoppersStore.ShoppersStoreDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.Core.ShoppersStore.ShoppersStoreDBMigrations
{
    [DbContext(typeof(ShoppersStoreContext))]
    [Migration("20230223200742_initial-ss-db-create")]
    partial class initialssdbcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.DiscountHistory", b =>
                {
                    b.Property<int>("DiscountHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiscountEffectiveBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DiscountEffectiveEnd")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("DiscountHistoryId");

                    b.ToTable("DiscountHistories");
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillRefCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardCVV")
                        .HasColumnType("int");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ValidMonth")
                        .HasColumnType("int");

                    b.Property<int>("ValidYear")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductFileId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.ProductFile", b =>
                {
                    b.Property<int>("ProductFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductFileId");

                    b.ToTable("ProductFiles");
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.ProductSell", b =>
                {
                    b.Property<int>("SellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BillQty")
                        .HasColumnType("int");

                    b.Property<string>("BillRefCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("SellId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSells");
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.Product", b =>
                {
                    b.HasOne("EF.Core.ShoppersStore.ShoppersStoreDB.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Core.ShoppersStore.ShoppersStoreDB.Models.ProductSell", b =>
                {
                    b.HasOne("EF.Core.ShoppersStore.ShoppersStoreDB.Models.Product", "Product")
                        .WithMany("ProductSells")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}