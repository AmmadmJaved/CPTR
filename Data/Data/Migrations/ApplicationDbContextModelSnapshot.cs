﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Data.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Data.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Data.Model.Diagnose", b =>
                {
                    b.Property<int>("DiagnoseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Biopsies");

                    b.Property<string>("Bloodtest");

                    b.Property<string>("ImagingScans");

                    b.Property<string>("Laboratorytest");

                    b.Property<string>("Spinaltap_lumbarPuncture");

                    b.Property<string>("Stoolsample");

                    b.Property<string>("Throatswab");

                    b.Property<string>("Urinetest");

                    b.HasKey("DiagnoseId");

                    b.ToTable("Diagnose");
                });

            modelBuilder.Entity("Data.Model.DiseasePrevalence", b =>
                {
                    b.Property<int>("DiseasePrevalenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Effectiviness");

                    b.Property<double>("HealthyArea");

                    b.Property<double>("TotalBodyHealth");

                    b.HasKey("DiseasePrevalenceId");

                    b.ToTable("DiseasePrevalence");
                });

            modelBuilder.Entity("Data.Model.Fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("FruitName");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("Data.Model.PatientDisease", b =>
                {
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DiagnoseId");

                    b.Property<int?>("DiseasePrevalenceId");

                    b.Property<string>("Medicine");

                    b.Property<int>("PatientUserId");

                    b.Property<string>("Treatment");

                    b.HasKey("DiseaseId");

                    b.HasIndex("DiagnoseId");

                    b.HasIndex("DiseasePrevalenceId");

                    b.HasIndex("PatientUserId");

                    b.ToTable("PatientDisease");
                });

            modelBuilder.Entity("Data.Model.PatientUser", b =>
                {
                    b.Property<int>("PatientUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("CNIC");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("PatientUserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("PatientUsers");
                });

            modelBuilder.Entity("Data.Model.Physician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("CNIC");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("Experience");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Qualification");

                    b.Property<int>("RegistrationNo");

                    b.Property<string>("Specialist");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Physicians");
                });

            modelBuilder.Entity("Data.Model.Vegetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<double>("Price");

                    b.Property<string>("vegetableName");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Vegetables");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Data.Model.Fruit", b =>
                {
                    b.HasOne("Data.Model.Category")
                        .WithMany("Fruits")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Data.Model.PatientDisease", b =>
                {
                    b.HasOne("Data.Model.Diagnose", "Diagnose")
                        .WithMany()
                        .HasForeignKey("DiagnoseId");

                    b.HasOne("Data.Model.DiseasePrevalence", "DiseasePrevalence")
                        .WithMany()
                        .HasForeignKey("DiseasePrevalenceId");

                    b.HasOne("Data.Model.PatientUser", "PatientUser")
                        .WithMany("PatientDiseases")
                        .HasForeignKey("PatientUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Data.Model.PatientUser", b =>
                {
                    b.HasOne("Data.ApplicationUser", "ApplicationUser")
                        .WithMany("PatientUsers")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Data.Model.Physician", b =>
                {
                    b.HasOne("Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Physicians")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Data.Model.Vegetable", b =>
                {
                    b.HasOne("Data.Model.Category")
                        .WithMany("Vegetables")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
