﻿// <auto-generated />
using System;
using Inventory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20220612204328_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContainerStock", b =>
                {
                    b.Property<int>("ContainersId")
                        .HasColumnType("int");

                    b.Property<int>("StocksId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContainersId", "StocksId");

                    b.HasIndex("StocksId");

                    b.ToTable("ContainerStock");
                });

            modelBuilder.Entity("Inventory.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Inventory.Data.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ParentId");

                    b.HasIndex("SizeId");

                    b.ToTable("Container");
                });

            modelBuilder.Entity("Inventory.Data.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContainerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.HasIndex("ItemId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Inventory.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SizeId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Inventory.Data.SIUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SIUnit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 6, 12, 22, 43, 27, 808, DateTimeKind.Local).AddTicks(4568),
                            Name = "centimeter",
                            Symbol = "cm",
                            UpdatedDate = new DateTime(2022, 6, 12, 22, 43, 27, 808, DateTimeKind.Local).AddTicks(4603)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 6, 12, 22, 43, 27, 808, DateTimeKind.Local).AddTicks(4607),
                            Name = "liter",
                            Symbol = "l",
                            UpdatedDate = new DateTime(2022, 6, 12, 22, 43, 27, 808, DateTimeKind.Local).AddTicks(4609)
                        });
                });

            modelBuilder.Entity("Inventory.Data.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Depth")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<double?>("Diameter")
                        .HasColumnType("float");

                    b.Property<double?>("Heigth")
                        .HasColumnType("float");

                    b.Property<double?>("Length")
                        .HasColumnType("float");

                    b.Property<int>("LengthUnitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Volume")
                        .HasColumnType("float");

                    b.Property<int>("VolumeUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LengthUnitId");

                    b.HasIndex("VolumeUnitId");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Inventory.Data.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("Inventory.Data.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("TagId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Inventory.Data.StockCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("StockCount");
                });

            modelBuilder.Entity("Inventory.Data.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("Name")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("StateStock", b =>
                {
                    b.Property<int>("StatesId")
                        .HasColumnType("int");

                    b.Property<int>("StocksId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StatesId", "StocksId");

                    b.HasIndex("StocksId");

                    b.ToTable("StateStock");
                });

            modelBuilder.Entity("ContainerStock", b =>
                {
                    b.HasOne("Inventory.Data.Container", null)
                        .WithMany()
                        .HasForeignKey("ContainersId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Stock", null)
                        .WithMany()
                        .HasForeignKey("StocksId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Inventory.Data.Category", b =>
                {
                    b.HasOne("Inventory.Data.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Inventory.Data.Container", b =>
                {
                    b.HasOne("Inventory.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Container", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Inventory.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("Category");

                    b.Navigation("Parent");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Inventory.Data.Image", b =>
                {
                    b.HasOne("Inventory.Data.Container", null)
                        .WithMany("Images")
                        .HasForeignKey("ContainerId");

                    b.HasOne("Inventory.Data.Item", "Item")
                        .WithMany("Images")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Inventory.Data.Item", b =>
                {
                    b.HasOne("Inventory.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("Category");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Inventory.Data.Size", b =>
                {
                    b.HasOne("Inventory.Data.SIUnit", "LengthUnit")
                        .WithMany()
                        .HasForeignKey("LengthUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inventory.Data.SIUnit", "VolumeUnit")
                        .WithMany()
                        .HasForeignKey("VolumeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LengthUnit");

                    b.Navigation("VolumeUnit");
                });

            modelBuilder.Entity("Inventory.Data.State", b =>
                {
                    b.HasOne("Inventory.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Inventory.Data.Stock", b =>
                {
                    b.HasOne("Inventory.Data.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");

                    b.Navigation("Item");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Inventory.Data.StockCount", b =>
                {
                    b.HasOne("Inventory.Data.Stock", "Stock")
                        .WithMany("StockCounts")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StateStock", b =>
                {
                    b.HasOne("Inventory.Data.State", null)
                        .WithMany()
                        .HasForeignKey("StatesId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Inventory.Data.Stock", null)
                        .WithMany()
                        .HasForeignKey("StocksId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Inventory.Data.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Inventory.Data.Container", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Inventory.Data.Item", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Inventory.Data.Stock", b =>
                {
                    b.Navigation("StockCounts");
                });
#pragma warning restore 612, 618
        }
    }
}
