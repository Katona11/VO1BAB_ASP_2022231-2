﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VO1BAB_ASP_2022231.Data;

#nullable disable

namespace VO1BAB_ASP_2022231.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221204162750_addcars")]
    partial class addcars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "63472dcc-4a40-42c0-a971-604039d1120c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ab91da9-5c0b-4397-bdf7-d137a6a48f0b",
                            Email = "katona@katona.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "KATONA@KATONA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGNQs0l05chihejftvW75FN1kkMpJciseHZEUYKt3jHXOUcwdAmr/f5xMZCIUAFxlA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "771b156c-96d7-48d5-b2c9-f6cda80a2ff0",
                            TwoFactorEnabled = false,
                            UserName = "katona@katona.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "63472dcc-4a40-42c0-a971-604039d1120c",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("VO1BAB_ASP_2022231.Models.CarBrand", b =>
                {
                    b.Property<int>("CarBrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarBrandID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CarBrandID");

                    b.ToTable("carbrand");

                    b.HasData(
                        new
                        {
                            CarBrandID = 1,
                            Name = "BMW"
                        },
                        new
                        {
                            CarBrandID = 2,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            CarBrandID = 3,
                            Name = "Ford"
                        },
                        new
                        {
                            CarBrandID = 4,
                            Name = "Skoda"
                        },
                        new
                        {
                            CarBrandID = 5,
                            Name = "Audi"
                        },
                        new
                        {
                            CarBrandID = 6,
                            Name = "Kia"
                        },
                        new
                        {
                            CarBrandID = 7,
                            Name = "Opel"
                        });
                });

            modelBuilder.Entity("VO1BAB_ASP_2022231.Models.Cars", b =>
                {
                    b.Property<int>("CarsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarsID"), 1L, 1);

                    b.Property<int>("CarBrandID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicensePlateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerformanceInHP")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarsID");

                    b.HasIndex("CarBrandID");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            CarsID = 1,
                            CarBrandID = 1,
                            Image = "https://www.netcarshow.com/Hamann-BMW_5er_E60_545i-2005-1280-01.jpg",
                            LicensePlateNumber = "HFG-453",
                            PerformanceInHP = 310,
                            Type = "E60",
                            Year = 2004
                        },
                        new
                        {
                            CarsID = 2,
                            CarBrandID = 2,
                            Image = "https://www.netcarshow.com/Mercedes-Benz-CLS63_AMG-2015-1280-07.jpg",
                            LicensePlateNumber = "SNK-955",
                            PerformanceInHP = 605,
                            Type = "CLS-63",
                            Year = 2019
                        },
                        new
                        {
                            CarsID = 3,
                            CarBrandID = 3,
                            Image = "https://www.netcarshow.com/Ford-Mondeo-2011-1280-01.jpg",
                            LicensePlateNumber = "JPK-245",
                            PerformanceInHP = 110,
                            Type = "Mondeo",
                            Year = 2008
                        },
                        new
                        {
                            CarsID = 4,
                            CarBrandID = 3,
                            Image = "https://www.netcarshow.com/Ford-Mondeo_Concept-2007-1280-03.jpg",
                            LicensePlateNumber = "KLK-615",
                            PerformanceInHP = 130,
                            Type = "Mondeo",
                            Year = 2009
                        },
                        new
                        {
                            CarsID = 5,
                            CarBrandID = 4,
                            Image = "https://www.netcarshow.com/Skoda-Octavia_Combi_RS-2014-1280-04.jpg",
                            LicensePlateNumber = "MIH-400",
                            PerformanceInHP = 150,
                            Type = "Ocatavia",
                            Year = 2014
                        },
                        new
                        {
                            CarsID = 6,
                            CarBrandID = 5,
                            Image = "https://www.netcarshow.com/Audi-A3_Sportback_e-tron-2017-1280-01.jpg",
                            LicensePlateNumber = "P-55332",
                            PerformanceInHP = 150,
                            Type = "A3",
                            Year = 2016
                        },
                        new
                        {
                            CarsID = 7,
                            CarBrandID = 5,
                            Image = "https://www.netcarshow.com/Audi-A3_Sportback_e-tron-2017-1280-02.jpg",
                            LicensePlateNumber = "P-55456",
                            PerformanceInHP = 150,
                            Type = "A3",
                            Year = 2016
                        },
                        new
                        {
                            CarsID = 8,
                            CarBrandID = 6,
                            Image = "https://www.netcarshow.com/Kia-Ceed_SW_GT-Line-2016-1280-01.jpg",
                            LicensePlateNumber = "SEZ-488",
                            PerformanceInHP = 190,
                            Type = "Ceed",
                            Year = 2016
                        },
                        new
                        {
                            CarsID = 9,
                            CarBrandID = 4,
                            Image = "https://www.netcarshow.com/Skoda-Kodiaq_Sportline-2018-1280-03.jpg",
                            LicensePlateNumber = "SBC-888",
                            PerformanceInHP = 200,
                            Type = "Kodiaq",
                            Year = 2018
                        },
                        new
                        {
                            CarsID = 10,
                            CarBrandID = 4,
                            Image = "https://www.netcarshow.com/Skoda-Superb_Combi_4x4-2010-1280-02.jpg",
                            LicensePlateNumber = "HCD-104",
                            PerformanceInHP = 200,
                            Type = "Superb",
                            Year = 2010
                        },
                        new
                        {
                            CarsID = 11,
                            CarBrandID = 7,
                            Image = "https://www.netcarshow.com/Vauxhall-Astra_VXR-2005-1280-02.jpg",
                            LicensePlateNumber = "PET-555",
                            PerformanceInHP = 90,
                            Type = "Astra",
                            Year = 2004
                        },
                        new
                        {
                            CarsID = 12,
                            CarBrandID = 4,
                            Image = "https://www.netcarshow.com/Skoda-Octavia_Combi-2004-1280-12.jpg",
                            LicensePlateNumber = "JKL-256",
                            PerformanceInHP = 80,
                            Type = "Octavia",
                            Year = 2004
                        },
                        new
                        {
                            CarsID = 13,
                            CarBrandID = 1,
                            Image = "https://www.netcarshow.com/BMW-M5_CS-2022-1280-01.jpg",
                            LicensePlateNumber = "KCI-442",
                            PerformanceInHP = 190,
                            Type = "530D",
                            Year = 2011
                        },
                        new
                        {
                            CarsID = 14,
                            CarBrandID = 2,
                            Image = "https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg",
                            LicensePlateNumber = "ONS-875",
                            PerformanceInHP = 220,
                            Type = "CLA",
                            Year = 2017
                        },
                        new
                        {
                            CarsID = 15,
                            CarBrandID = 2,
                            Image = "https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg",
                            LicensePlateNumber = "OCC-325",
                            PerformanceInHP = 220,
                            Type = "CLA",
                            Year = 2017
                        },
                        new
                        {
                            CarsID = 16,
                            CarBrandID = 2,
                            Image = "https://www.netcarshow.com/Mercedes-Benz-GLE-2016-1280-01.jpg",
                            LicensePlateNumber = "OBS-432",
                            PerformanceInHP = 220,
                            Type = "CLA",
                            Year = 2017
                        },
                        new
                        {
                            CarsID = 17,
                            CarBrandID = 4,
                            Image = "https://www.netcarshow.com/Skoda-Octavia_RS-2020-1280-01.jpg",
                            LicensePlateNumber = "PRS-564",
                            PerformanceInHP = 150,
                            Type = "Octvia",
                            Year = 2018
                        },
                        new
                        {
                            CarsID = 18,
                            CarBrandID = 5,
                            Image = "https://www.netcarshow.com/Audi-SQ8_e-tron_quattro-2024-1280-01.jpg",
                            LicensePlateNumber = "AA-AA-343",
                            PerformanceInHP = 400,
                            Type = "E-TRON",
                            Year = 2022
                        },
                        new
                        {
                            CarsID = 19,
                            CarBrandID = 4,
                            Image = "https://www.netcarshow.com/Skoda-Kodiaq-2017-1280-01.jpg",
                            LicensePlateNumber = "AA-AY-789",
                            PerformanceInHP = 160,
                            Type = "Kodiaq",
                            Year = 2022
                        },
                        new
                        {
                            CarsID = 20,
                            CarBrandID = 1,
                            Image = "https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg",
                            LicensePlateNumber = "AA-AV-121",
                            PerformanceInHP = 700,
                            Type = "M5",
                            Year = 2022
                        },
                        new
                        {
                            CarsID = 21,
                            CarBrandID = 1,
                            Image = "https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg",
                            LicensePlateNumber = "HFG-453",
                            PerformanceInHP = 310,
                            Type = "E60",
                            Year = 2004
                        },
                        new
                        {
                            CarsID = 22,
                            CarBrandID = 1,
                            Image = "https://www.netcarshow.com/BMW-M5-2005-1280-01.jpg",
                            LicensePlateNumber = "HFG-453",
                            PerformanceInHP = 310,
                            Type = "E60",
                            Year = 2004
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VO1BAB_ASP_2022231.Models.Cars", b =>
                {
                    b.HasOne("VO1BAB_ASP_2022231.Models.CarBrand", "carbrand")
                        .WithMany("cars")
                        .HasForeignKey("CarBrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("carbrand");
                });

            modelBuilder.Entity("VO1BAB_ASP_2022231.Models.CarBrand", b =>
                {
                    b.Navigation("cars");
                });
#pragma warning restore 612, 618
        }
    }
}
