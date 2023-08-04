﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kheoom.Models;

#nullable disable

namespace kheoom.Migrations
{
    [DbContext(typeof(dataContext))]
    [Migration("20230714134340_four")]
    partial class four
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("kheoom.Models.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlockId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("kheoom.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("ConsumptionValue_Sanitation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ConsumptionValue_Water")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Consumption_Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Invoice_All_Value_")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Invoice_Value_")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LastRead")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NowRead")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sanitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Service_Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SubscriberID")
                        .HasColumnType("int");

                    b.Property<string>("SubscriberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubscriptionID")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax_rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("subscription_BlockNumbers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("kheoom.Models.Slice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlockNumbers")
                        .HasColumnType("int");

                    b.Property<decimal>("ConsumptionValue_Slice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price_Sanitation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Slice_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price_liter")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Slices");
                });

            modelBuilder.Entity("kheoom.Models.SubScriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IdIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubScribers");
                });

            modelBuilder.Entity("kheoom.Models.SubScribption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlockNumbers")
                        .HasColumnType("int");

                    b.Property<string>("BlockType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sanitation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubscriberID")
                        .HasColumnType("int");

                    b.Property<string>("SubscriberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SystemsubsriptionId")
                        .HasColumnType("int");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubscriberID");

                    b.ToTable("SubScribptions");
                });

            modelBuilder.Entity("kheoom.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "123",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("kheoom.Models.SubScribption", b =>
                {
                    b.HasOne("kheoom.Models.SubScriber", "SubScriber")
                        .WithMany("SubScribptions")
                        .HasForeignKey("SubscriberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubScriber");
                });

            modelBuilder.Entity("kheoom.Models.SubScriber", b =>
                {
                    b.Navigation("SubScribptions");
                });
#pragma warning restore 612, 618
        }
    }
}
