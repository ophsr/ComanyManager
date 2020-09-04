﻿// <auto-generated />
using System;
using ComanyManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComanyManager.Migrations
{
    [DbContext(typeof(ComanyManagerContext))]
    [Migration("20200904032443_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComanyManager.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("ComanyManager.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameCompany")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("URL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("ComanyManager.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ComanyManager.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ComanyManager.Models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Profession");
                });

            modelBuilder.Entity("ComanyManager.Models.Admin", b =>
                {
                    b.HasOne("ComanyManager.Models.Company", "Company")
                        .WithMany("CompanyAdmin")
                        .HasForeignKey("CompanyId");

                    b.HasOne("ComanyManager.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("ComanyManager.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId");
                });

            modelBuilder.Entity("ComanyManager.Models.Department", b =>
                {
                    b.HasOne("ComanyManager.Models.Company", "Company")
                        .WithMany("DepartmentsList")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComanyManager.Models.Employee", b =>
                {
                    b.HasOne("ComanyManager.Models.Company", "Company")
                        .WithMany("CompanyEmployee")
                        .HasForeignKey("CompanyId");

                    b.HasOne("ComanyManager.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("ComanyManager.Models.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId");
                });

            modelBuilder.Entity("ComanyManager.Models.Profession", b =>
                {
                    b.HasOne("ComanyManager.Models.Company", "Company")
                        .WithMany("ProfessionsList")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
