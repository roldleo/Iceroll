﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IceRoll.Data.Migrations
{
    [DbContext(typeof(RolliceContext))]
    [Migration("20221207050026_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("IceRoll.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("ImageFileName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Delicious chocolate that melts in the mouth",
                            ImageName = "chocoa.jpeg",
                            Name = "Chocoa Ice.Roll",
                            Price = 24.000m
                        },
                        new
                        {
                            Id = 2,
                            Description = "delicious bananas with unrivaled tenderness",
                            ImageName = "banana.jpeg",
                            Name = "Banana Ice.Roll",
                            Price = 22.000m
                        },
                        new
                        {
                            Id = 3,
                            Description = "very tempting fragrance with fresh fruit",
                            ImageName = "manggo.jpeg",
                            Name = "Mango Ice.Roll",
                            Price = 26.000m
                        },
                        new
                        {
                            Id = 4,
                            Description = "so tempting sweet with delicious taste",
                            ImageName = "orange.jpeg",
                            Name = "orange Ice.Roll",
                            Price = 23.000m
                        },
                        new
                        {
                            Id = 5,
                            Description = "So delicious crunchy",
                            ImageName = "oreo.jpeg",
                            Name = "Oreo Ice.Roll",
                            Price = 28.000m
                        },
                        new
                        {
                            Id = 6,
                            Description = "delicious taste with fresh fruit topping",
                            ImageName = "strawberry.jpeg",
                            Name = "Strawberry Ice.Roll",
                            Price = 26.000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
