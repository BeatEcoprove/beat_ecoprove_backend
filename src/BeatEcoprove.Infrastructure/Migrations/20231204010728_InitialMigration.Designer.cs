﻿// <auto-generated />
using System;
using BeatEcoprove.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    [DbContext(typeof(BeatEcoproveDbContext))]
    [Migration("20231204010728_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BeatEcoprove.Domain.AuthAggregator.Auth", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("is_enabled");

                    b.Property<Guid>("MainProfileId")
                        .HasColumnType("uuid")
                        .HasColumnName("main_profile_id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("password");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("salt");

                    b.HasKey("Id");

                    b.ToTable("auths", (string)null);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ClosetAggregator.Bucket", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("buckets", (string)null);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ClosetAggregator.Cloth", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("Brand")
                        .HasColumnType("uuid")
                        .HasColumnName("brand");

                    b.Property<string>("ClothAvatar")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("cloth_avatar");

                    b.Property<Guid>("Color")
                        .HasColumnType("uuid")
                        .HasColumnName("color");

                    b.Property<int>("EcoScore")
                        .HasColumnType("integer")
                        .HasColumnName("eco_score");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<int>("Size")
                        .HasColumnType("integer")
                        .HasColumnName("size");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("Brand");

                    b.HasIndex("Color");

                    b.ToTable("cloths", (string)null);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<Guid>("AuthId")
                        .HasColumnType("uuid")
                        .HasColumnName("auth_id");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("avatar_url");

                    b.Property<int>("EcoScore")
                        .HasColumnType("integer")
                        .HasColumnName("eco_score");

                    b.Property<int>("SustainabilityPoints")
                        .HasColumnType("integer")
                        .HasColumnName("sustainability_points");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("user_name");

                    b.Property<double>("XP")
                        .HasColumnType("double precision")
                        .HasColumnName("xp");

                    b.HasKey("Id");

                    b.HasIndex("AuthId");

                    b.ToTable("profiles", (string)null);

                    b.HasDiscriminator<int>("Type");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BeatEcoprove.Domain.Shared.Entities.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("BrandAvatar")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("brand_avatar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("brands", (string)null);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.Shared.Entities.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Hex")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("hex");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("colors", (string)null);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Consumer", b =>
                {
                    b.HasBaseType("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Profile");

                    b.Property<DateOnly>("BornDate")
                        .HasColumnType("date")
                        .HasColumnName("born_date");

                    b.Property<int>("Gender")
                        .HasColumnType("integer")
                        .HasColumnName("gender");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Organization", b =>
                {
                    b.HasBaseType("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Profile");

                    b.Property<int>("TypeOption")
                        .HasColumnType("integer")
                        .HasColumnName("type_option");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ClosetAggregator.Bucket", b =>
                {
                    b.OwnsMany("BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths.BucketClothEntry", "BucketClothEntries", b1 =>
                        {
                            b1.Property<Guid>("BucketId")
                                .HasColumnType("uuid")
                                .HasColumnName("bucket_id");

                            b1.Property<Guid>("ClothId")
                                .HasColumnType("uuid")
                                .HasColumnName("cloth_id");

                            b1.HasKey("BucketId", "ClothId");

                            b1.HasIndex("ClothId");

                            b1.ToTable("bucket_cloths", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("BucketId");

                            b1.HasOne("BeatEcoprove.Domain.ClosetAggregator.Cloth", null)
                                .WithMany()
                                .HasForeignKey("ClothId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                    b.Navigation("BucketClothEntries");
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ClosetAggregator.Cloth", b =>
                {
                    b.HasOne("BeatEcoprove.Domain.Shared.Entities.Brand", null)
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeatEcoprove.Domain.Shared.Entities.Color", null)
                        .WithMany()
                        .HasForeignKey("Color")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Profile", b =>
                {
                    b.HasOne("BeatEcoprove.Domain.AuthAggregator.Auth", null)
                        .WithMany()
                        .HasForeignKey("AuthId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsMany("BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths.BucketEntry", "BucketEntries", b1 =>
                        {
                            b1.Property<Guid>("ProfileId")
                                .HasColumnType("uuid")
                                .HasColumnName("profile_id");

                            b1.Property<Guid>("BucketId")
                                .HasColumnType("uuid")
                                .HasColumnName("bucket_id");

                            b1.Property<bool>("IsBlocked")
                                .HasColumnType("boolean")
                                .HasColumnName("is_blocked");

                            b1.HasKey("ProfileId", "BucketId");

                            b1.ToTable("bucket_entries", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProfileId");
                        });

                    b.OwnsMany("BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths.ClothEntry", "ClothEntries", b1 =>
                        {
                            b1.Property<Guid>("ProfileId")
                                .HasColumnType("uuid")
                                .HasColumnName("profile_id");

                            b1.Property<Guid>("ClothId")
                                .HasColumnType("uuid")
                                .HasColumnName("cloth_id");

                            b1.Property<bool>("IsBlocked")
                                .HasColumnType("boolean")
                                .HasColumnName("is_blocked");

                            b1.HasKey("ProfileId", "ClothId");

                            b1.HasIndex("ClothId");

                            b1.ToTable("cloth_entries", (string)null);

                            b1.HasOne("BeatEcoprove.Domain.ClosetAggregator.Cloth", null)
                                .WithMany()
                                .HasForeignKey("ClothId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("ProfileId");
                        });

                    b.OwnsOne("BeatEcoprove.Domain.ProfileAggregator.ValueObjects.Phone", "Phone", b1 =>
                        {
                            b1.Property<Guid>("ProfileId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Code")
                                .IsRequired()
                                .HasMaxLength(4)
                                .HasColumnType("character varying(4)")
                                .HasColumnName("phone_country_code");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)")
                                .HasColumnName("phone");

                            b1.HasKey("ProfileId");

                            b1.ToTable("profiles");

                            b1.WithOwner()
                                .HasForeignKey("ProfileId");
                        });

                    b.Navigation("BucketEntries");

                    b.Navigation("ClothEntries");

                    b.Navigation("Phone")
                        .IsRequired();
                });

            modelBuilder.Entity("BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles.Organization", b =>
                {
                    b.OwnsOne("BeatEcoprove.Domain.ProfileAggregator.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("OrganizationId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Locality")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)")
                                .HasColumnName("locality");

                            b1.Property<int>("Port")
                                .HasColumnType("integer")
                                .HasColumnName("port");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)")
                                .HasColumnName("street");

                            b1.HasKey("OrganizationId");

                            b1.ToTable("profiles");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationId");

                            b1.OwnsOne("BeatEcoprove.Domain.ProfileAggregator.ValueObjects.PostalCode", "PostalCode", b2 =>
                                {
                                    b2.Property<Guid>("AddressOrganizationId")
                                        .HasColumnType("uuid");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(256)
                                        .HasColumnType("character varying(256)")
                                        .HasColumnName("postal_code");

                                    b2.HasKey("AddressOrganizationId");

                                    b2.ToTable("profiles");

                                    b2.WithOwner()
                                        .HasForeignKey("AddressOrganizationId");
                                });

                            b1.Navigation("PostalCode")
                                .IsRequired();
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
