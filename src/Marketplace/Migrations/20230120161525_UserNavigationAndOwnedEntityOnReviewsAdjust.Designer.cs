﻿// <auto-generated />
using System;
using Marketplace.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Marketplace.Migrations
{
    [DbContext(typeof(MarketplaceContext))]
    [Migration("20230120161525_UserNavigationAndOwnedEntityOnReviewsAdjust")]
    partial class UserNavigationAndOwnedEntityOnReviewsAdjust
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategoryItem", b =>
                {
                    b.Property<Guid>("CategoriesCategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ItemsItemId")
                        .HasColumnType("uuid");

                    b.HasKey("CategoriesCategoryId", "ItemsItemId");

                    b.HasIndex("ItemsItemId");

                    b.ToTable("CategoryItem");
                });

            modelBuilder.Entity("ItemStore", b =>
                {
                    b.Property<Guid>("ItemsItemId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StoresStoreId")
                        .HasColumnType("uuid");

                    b.HasKey("ItemsItemId", "StoresStoreId");

                    b.HasIndex("StoresStoreId");

                    b.ToTable("ItemStore");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.Item", b =>
                {
                    b.Property<Guid>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.ItemReview", b =>
                {
                    b.Property<Guid>("ItemReviewId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("ItemReviewId");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("ItemReviews");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.Store", b =>
                {
                    b.Property<Guid>("StoreId")
                        .HasColumnType("uuid");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("StoreId");

                    b.HasIndex("Cnpj");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.StoreReview", b =>
                {
                    b.Property<Guid>("StoreReviewId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("StoreReviewId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("StoreReviews");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("UserRole")
                        .HasColumnType("smallint");

                    b.HasKey("UserId");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CategoryItem", b =>
                {
                    b.HasOne("Marketplace.Models.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marketplace.Models.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemStore", b =>
                {
                    b.HasOne("Marketplace.Models.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marketplace.Models.Entities.Store", null)
                        .WithMany()
                        .HasForeignKey("StoresStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marketplace.Models.Entities.ItemReview", b =>
                {
                    b.HasOne("Marketplace.Models.Entities.Item", "Item")
                        .WithMany("ItemReviews")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marketplace.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Marketplace.Models.Entities.Review", "Review", b1 =>
                        {
                            b1.Property<Guid>("ItemReviewId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Content")
                                .HasColumnType("text");

                            b1.Property<double>("Rating")
                                .HasColumnType("double precision");

                            b1.HasKey("ItemReviewId");

                            b1.ToTable("ItemReviews");

                            b1.WithOwner()
                                .HasForeignKey("ItemReviewId");
                        });

                    b.Navigation("Item");

                    b.Navigation("Review")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.Store", b =>
                {
                    b.HasOne("Marketplace.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.StoreReview", b =>
                {
                    b.HasOne("Marketplace.Models.Entities.Store", "Store")
                        .WithMany("ItemReviews")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marketplace.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Marketplace.Models.Entities.Review", "Review", b1 =>
                        {
                            b1.Property<Guid>("StoreReviewId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Content")
                                .HasColumnType("text");

                            b1.Property<double>("Rating")
                                .HasColumnType("double precision");

                            b1.HasKey("StoreReviewId");

                            b1.ToTable("StoreReviews");

                            b1.WithOwner()
                                .HasForeignKey("StoreReviewId");
                        });

                    b.Navigation("Review")
                        .IsRequired();

                    b.Navigation("Store");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.Item", b =>
                {
                    b.Navigation("ItemReviews");
                });

            modelBuilder.Entity("Marketplace.Models.Entities.Store", b =>
                {
                    b.Navigation("ItemReviews");
                });
#pragma warning restore 612, 618
        }
    }
}