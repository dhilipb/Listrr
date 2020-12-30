﻿// <auto-generated />
using System;
using Listrr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Listrr.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201230013022_Added IMDB Ratings")]
    partial class AddedIMDBRatings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Listrr.Data.CountryCode", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name", "Code");

                    b.HasIndex("Code");

                    b.ToTable("CountryCodes");
                });

            modelBuilder.Entity("Listrr.Data.IMDb.IMDbRating", b =>
                {
                    b.Property<string>("IMDbId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Votes")
                        .HasColumnType("int");

                    b.HasKey("IMDbId");

                    b.HasIndex("IMDbId")
                        .IsUnique();

                    b.ToTable("ImDbRatings");
                });

            modelBuilder.Entity("Listrr.Data.LanguageCode", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name", "Code");

                    b.HasIndex("Code");

                    b.ToTable("LanguageCodes");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktList", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<string>("Filter_Certifications_Movie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Certifications_Show")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Genres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Networks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Ratings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Runtimes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Translations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filter_Years")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Items")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastProcessed")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Process")
                        .HasColumnType("bit");

                    b.Property<string>("Query")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Certifications_Movie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Certifications_Show")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Countries")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Genres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Networks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverseFilter_Translations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScanState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<bool>("SearchByAlias")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByBiography")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByDescription")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByName")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByOverview")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByPeople")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByTagline")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByTitle")
                        .HasColumnType("bit");

                    b.Property<bool>("SearchByTranslations")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("Slug", "Name")
                        .IsUnique()
                        .HasFilter("[Slug] IS NOT NULL AND [Name] IS NOT NULL");

                    b.ToTable("TraktLists");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktMovieCertification", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktMovieCertifications");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktMovieGenre", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktMovieGenres");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowCertification", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktShowCertifications");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowGenre", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktShowGenres");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowNetwork", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TraktShowNetworks");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowStatus", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TraktShowStatuses");
                });

            modelBuilder.Entity("Listrr.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktList", b =>
                {
                    b.HasOne("Listrr.Data.User", "Owner")
                        .WithMany("TraktLists")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Listrr.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Listrr.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Listrr.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Listrr.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
