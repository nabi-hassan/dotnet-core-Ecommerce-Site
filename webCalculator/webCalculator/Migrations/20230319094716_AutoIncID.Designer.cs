﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webCalculator.Models;

#nullable disable

namespace webCalculator.Migrations
{
    [DbContext(typeof(ModelsContext))]
    [Migration("20230319094716_AutoIncID")]
    partial class AutoIncID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("webCalculator.Models.ProductData", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProdBrand")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProdCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProdDescription")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("ProdPrice")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProdQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProdTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
