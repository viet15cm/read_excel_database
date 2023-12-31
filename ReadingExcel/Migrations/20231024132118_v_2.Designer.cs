﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadingExcel.DbContextLayer;

#nullable disable

namespace ReadingExcel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231024132118_v_2")]
    partial class v_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReadingExcel.Entitiy.Commodity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Commodities");
                });

            modelBuilder.Entity("ReadingExcel.Entitiy.CommodityGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommodityGroups");
                });

            modelBuilder.Entity("ReadingExcel.Entitiy.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("CapitalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommodidyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommodityGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HangHoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhomHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrlImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommodidyId");

                    b.HasIndex("CommodityGroupId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ReadingExcel.Entitiy.Product", b =>
                {
                    b.HasOne("ReadingExcel.Entitiy.Commodity", "Commodity")
                        .WithMany("Products")
                        .HasForeignKey("CommodidyId");

                    b.HasOne("ReadingExcel.Entitiy.CommodityGroup", "CommodityGroup")
                        .WithMany("Products")
                        .HasForeignKey("CommodityGroupId");

                    b.Navigation("Commodity");

                    b.Navigation("CommodityGroup");
                });

            modelBuilder.Entity("ReadingExcel.Entitiy.Commodity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ReadingExcel.Entitiy.CommodityGroup", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
