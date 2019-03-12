﻿// <auto-generated />
using System;
using Cuscuzeria.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cuscuzeria.Infra.Data.Migrations
{
    [DbContext(typeof(CuscuzeriaContext))]
    [Migration("20190312040230_InsertingSampleDataUsers2")]
    partial class InsertingSampleDataUsers2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("OrderId");

                    b.HasKey("DrinkId");

                    b.HasIndex("OrderId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Accompaniment", b =>
                {
                    b.Property<int>("AccompanimentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccompanimentName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("CuscuzId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("AccompanimentId");

                    b.HasIndex("CuscuzId");

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

                    b.Property<int>("OrderId");

                    b.HasKey("BeverageId");

                    b.HasIndex("OrderId");

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

                    b.Property<int>("OrderId");

                    b.Property<int>("TypeId");

                    b.HasKey("CuscuzId");

                    b.HasIndex("OrderId");

                    b.HasIndex("TypeId")
                        .IsUnique();

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

                    b.Property<int>("OrderId");

                    b.Property<DateTime?>("StartDate");

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

                    b.HasIndex("CuscuzeiroId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

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

                    b.Property<DateTime?>("EndsAt");

                    b.Property<int>("OrderId");

                    b.Property<string>("PromoTitle")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("StartsAt");

                    b.HasKey("PromoId");

                    b.HasIndex("OrderId");

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

                    b.Property<DateTime?>("LastOrder");

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

                    b.ToTable("Clients");

                    b.HasData(
                        new { UserId = 1, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 220, DateTimeKind.Local), Email = "mihai@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "mihai" },
                        new { UserId = 2, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "yjqom@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "yjqom" },
                        new { UserId = 3, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "ojbzg@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "ojbzg " },
                        new { UserId = 4, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "sgdxp@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "sgdxp" },
                        new { UserId = 5, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "tkolf@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "tkolf" },
                        new { UserId = 6, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "jkgvb@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "jkgvb" },
                        new { UserId = 7, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "wkint@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "wkint" },
                        new { UserId = 8, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "zeozf@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "zeozf" },
                        new { UserId = 9, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "ywabo@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "ywabo" },
                        new { UserId = 10, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "qcrlf@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "qcrlf" },
                        new { UserId = 11, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "wfqyd@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "wfqyd" },
                        new { UserId = 12, CreatedAt = new DateTime(2019, 3, 12, 1, 2, 30, 221, DateTimeKind.Local), Email = "ekspr@email.com", LastOrder = new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), Password = "SZ@111222", Phone = "+55719988-7733", Username = "ekspr" }
                    );
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Drink", b =>
                {
                    b.HasOne("Cuscuzeria.Domain.Entities.Order", "Order")
                        .WithMany("Drinks")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Accompaniment", b =>
                {
                    b.HasOne("Cuscuzeria.Domain.Entities.Cuscuz", "Cuscuz")
                        .WithMany("Accompaniments")
                        .HasForeignKey("CuscuzId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Beverage", b =>
                {
                    b.HasOne("Cuscuzeria.Domain.Entities.Order", "Order")
                        .WithMany("Beverages")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Cuscuz", b =>
                {
                    b.HasOne("Cuscuzeria.Domain.Entities.Order", "Order")
                        .WithMany("Cuscuzes")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cuscuzeria.Domain.Entities.Type", "Type")
                        .WithOne("Cuscuz")
                        .HasForeignKey("Cuscuzeria.Domain.Entities.Cuscuz", "TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Order", b =>
                {
                    b.HasOne("Cuscuzeria.Domain.Entities.Cuscuzeiro", "Cuscuzeiro")
                        .WithOne("Order")
                        .HasForeignKey("Cuscuzeria.Domain.Entities.Order", "CuscuzeiroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cuscuzeria.Domain.Entities.User", "User")
                        .WithOne("Order")
                        .HasForeignKey("Cuscuzeria.Domain.Entities.Order", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cuscuzeria.Domain.Entities.Promo", b =>
                {
                    b.HasOne("Cuscuzeria.Domain.Entities.Order", "Order")
                        .WithMany("Promo")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
