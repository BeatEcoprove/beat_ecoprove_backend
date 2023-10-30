﻿// <auto-generated />
using System;
using BeatEcoprove.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BeatEcoprove.Infrastructure.Migrations
{
    [DbContext(typeof(BeatEcoproveDbContext))]
    [Migration("20231029202451_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.Entities.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("avatar_url");

                    b.Property<DateOnly>("BornDate")
                        .HasColumnType("date")
                        .HasColumnName("born_date");

                    b.Property<Guid?>("Consumer")
                        .HasColumnType("uuid")
                        .HasColumnName("consumer_id");

                    b.Property<double>("EcoScore")
                        .HasColumnType("double precision")
                        .HasColumnName("eco_score");

                    b.Property<int>("Gender")
                        .HasColumnType("integer")
                        .HasColumnName("gender");

                    b.Property<bool>("IsMainProfile")
                        .HasColumnType("boolean")
                        .HasColumnName("is_main_profile");

                    b.Property<double>("SustainabilityPoints")
                        .HasColumnType("double precision")
                        .HasColumnName("sustainability_points");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.Property<double>("Xp")
                        .HasColumnType("double precision")
                        .HasColumnName("xp");

                    b.HasKey("Id");

                    b.HasIndex("Consumer");

                    b.ToTable("profiles", (string)null);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("avatar_url");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("password");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("app_users", (string)null);

                    b.HasDiscriminator<int>("Type");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.Entities.Consumer", b =>
                {
                    b.HasBaseType("BeatEcoprove.Domain.UserAggregator.User");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.Entities.Organization", b =>
                {
                    b.HasBaseType("BeatEcoprove.Domain.UserAggregator.User");

                    b.Property<int>("SustainabilityPoints")
                        .HasColumnType("integer")
                        .HasColumnName("sustainability_points");

                    b.Property<string>("TypeOption")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("type_option");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.Property<double>("Xp")
                        .HasColumnType("double precision")
                        .HasColumnName("xp");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.Entities.Profile", b =>
                {
                    b.HasOne("BeatEcoprove.Domain.UserAggregator.Entities.Consumer", null)
                        .WithMany("Profiles")
                        .HasForeignKey("Consumer");
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.User", b =>
                {
                    b.OwnsOne("BeatEcoprove.Domain.UserAggregator.ValueObjects.Phone", "Phone", b1 =>
                        {
                            b1.Property<Guid>("UserId")
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

                            b1.HasKey("UserId");

                            b1.ToTable("app_users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Phone")
                        .IsRequired();
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.Entities.Organization", b =>
                {
                    b.OwnsOne("BeatEcoprove.Domain.UserAggregator.ValueObjects.Address", "Address", b1 =>
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

                            b1.ToTable("app_users");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationId");

                            b1.OwnsOne("BeatEcoprove.Domain.UserAggregator.ValueObjects.PostalCode", "PostalCode", b2 =>
                                {
                                    b2.Property<Guid>("AddressOrganizationId")
                                        .HasColumnType("uuid");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(256)
                                        .HasColumnType("character varying(256)")
                                        .HasColumnName("postal_code");

                                    b2.HasKey("AddressOrganizationId");

                                    b2.ToTable("app_users");

                                    b2.WithOwner()
                                        .HasForeignKey("AddressOrganizationId");
                                });

                            b1.Navigation("PostalCode")
                                .IsRequired();
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("BeatEcoprove.Domain.UserAggregator.Entities.Consumer", b =>
                {
                    b.Navigation("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
