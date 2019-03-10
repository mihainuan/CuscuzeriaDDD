﻿// <auto-generated />
using System;
using Cuscuzeria.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cuscuzeria.Infra.Data.Migrations
{
    [DbContext(typeof(CuscuzeriaContext))]
    partial class CuscuzeriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cuscuzeria.Domain.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("DrinkName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Accompaniment", b =>
                {
                    b.Property<int>("AccompanimentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccompanimentName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("AccompanimentId");

                    b.ToTable("Accompaniments");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Beverage", b =>
                {
                    b.Property<int>("BeverageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BeverageName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("BeverageId");

                    b.ToTable("Beverages");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Cuscuz", b =>
                {
                    b.Property<int>("CuscuzId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccompanimentId");

                    b.Property<string>("CuscuzName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("TypeId");

                    b.HasKey("CuscuzId");

                    b.ToTable("Cuscuz");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Cuscuzeiro", b =>
                {
                    b.Property<int>("CuscuzeiroId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age")
                        .HasColumnName("YearsOfExperience");

                    b.Property<string>("CuscuzeiroName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("UrlImg")
                        .HasMaxLength(500);

                    b.HasKey("CuscuzeiroId");

                    b.ToTable("Cuscuzeiros");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BeverageId");

                    b.Property<int>("CuscuzId");

                    b.Property<int>("CuscuzeiroId");

                    b.Property<bool>("Delivered");

                    b.Property<int>("DrinkId");

                    b.Property<DateTime>("OrderCreation");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("PromoId");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Promo", b =>
                {
                    b.Property<int>("PromoId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("EndsAt");

                    b.Property<string>("PromoTitle")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartsAt");

                    b.HasKey("PromoId");

                    b.ToTable("Promos");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("TypeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("LastOrder");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("UrlImg")
                        .HasMaxLength(500);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(150);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
