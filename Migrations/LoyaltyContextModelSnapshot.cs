﻿// <auto-generated />
using System;
using KmaOoad18.Assignments.Week4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace assignmentw4.Migrations
{
    [DbContext(typeof(LoyaltyContext))]
    partial class LoyaltyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("KmaOoad18.Assignments.Week4.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("LoyaltyBalance");

                    b.Property<string>("LoyaltyCardId");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("KmaOoad18.Assignments.Week4.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Sku");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KmaOoad18.Assignments.Week4.Data.SpecialOffering", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Extra");

                    b.Property<int?>("ProductId");

                    b.Property<int>("PromotionType");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("SpecialOfferings");
                });

            modelBuilder.Entity("KmaOoad18.Assignments.Week4.Data.SpecialOffering", b =>
                {
                    b.HasOne("KmaOoad18.Assignments.Week4.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
