﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _3033_1_HW3_.Data;

#nullable disable

namespace _3033_1_HW3_.Migrations
{
    [DbContext(typeof(DBCon))]
    [Migration("20221011145046_create_db_receipt_2")]
    partial class create_db_receipt_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("_3033_1_HW3_.Receipt", b =>
                {
                    b.Property<string>("ReceiptID")
                        .HasColumnType("TEXT");

                    b.Property<int>("CogQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GearQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("ReceiptID");

                    b.ToTable("receipts");
                });
#pragma warning restore 612, 618
        }
    }
}
