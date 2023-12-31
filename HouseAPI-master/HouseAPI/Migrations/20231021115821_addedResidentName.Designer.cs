﻿// <auto-generated />
using System;
using HouseAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HouseAPI.Migrations
{
    [DbContext(typeof(CommunityGateDatabaseContext))]
    [Migration("20231021115821_addedResidentName")]
    partial class addedResidentName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HouseAPI.Models.Complaints", b =>
                {
                    b.Property<int>("ComplaintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("ComplaintRegarding")
                        .HasColumnType("text");

                    b.Property<string>("ComplaintStatus")
                        .HasColumnType("text");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("integer");

                    b.HasKey("ComplaintId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("HouseAPI.Models.DashBoardPosts", b =>
                {
                    b.Property<int>("DashItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("DashBody")
                        .HasColumnType("text");

                    b.Property<string>("DashIntendedFor")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DashTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DashTitle")
                        .HasColumnType("text");

                    b.Property<string>("DashType")
                        .HasColumnType("text");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("integer");

                    b.Property<string>("ResidentName")
                        .HasColumnType("text");

                    b.HasKey("DashItemId");

                    b.HasIndex("ResidentId");

                    b.ToTable("DashBoardPosts");
                });

            modelBuilder.Entity("HouseAPI.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("EmployeeDept")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeEmail")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeMobile")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("text");

                    b.Property<string>("EmployeePassword")
                        .HasColumnType("text");

                    b.Property<int?>("EmployeeRating")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployeeWallet")
                        .HasColumnType("integer");

                    b.Property<string>("IsApproved")
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HouseAPI.Models.FriendsAndFamily", b =>
                {
                    b.Property<int>("FaFid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("FaFname")
                        .HasColumnType("text");

                    b.Property<string>("Relation")
                        .HasColumnType("text");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("integer");

                    b.HasKey("FaFid");

                    b.HasIndex("ResidentId");

                    b.ToTable("FriendsAndFamily");
                });

            modelBuilder.Entity("HouseAPI.Models.HouseList", b =>
                {
                    b.Property<int>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("IsFree")
                        .HasColumnType("text");

                    b.HasKey("HouseId");

                    b.ToTable("HouseList");
                });

            modelBuilder.Entity("HouseAPI.Models.Payments", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int?>("Amount")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentFor")
                        .HasColumnType("text");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("text");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("integer");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("PaymentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ResidentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("HouseAPI.Models.Residents", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("IsApproved")
                        .HasColumnType("text");

                    b.Property<string>("ResidentEmail")
                        .HasColumnType("text");

                    b.Property<int?>("ResidentHouseNo")
                        .HasColumnType("integer");

                    b.Property<int?>("ResidentHouseNoNavigationHouseId")
                        .HasColumnType("integer");

                    b.Property<string>("ResidentMobileNo")
                        .HasColumnType("text");

                    b.Property<string>("ResidentName")
                        .HasColumnType("text");

                    b.Property<string>("ResidentPassword")
                        .HasColumnType("text");

                    b.Property<string>("ResidentType")
                        .HasColumnType("text");

                    b.Property<int?>("ResidentWallet")
                        .HasColumnType("integer");

                    b.HasKey("ResidentId");

                    b.HasIndex("ResidentHouseNoNavigationHouseId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("HouseAPI.Models.Services", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime?>("AppointmentTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceMessage")
                        .HasColumnType("text");

                    b.Property<int?>("ServicePrice")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceStatus")
                        .HasColumnType("text");

                    b.Property<string>("ServiceType")
                        .HasColumnType("text");

                    b.HasKey("ServiceId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("HouseAPI.Models.Visitors", b =>
                {
                    b.Property<int>("VisitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("VisitEndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("VisitStartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("VisitorEntryStatus")
                        .HasColumnType("text");

                    b.Property<string>("VisitorName")
                        .HasColumnType("text");

                    b.Property<string>("VisitorResaon")
                        .HasColumnType("text");

                    b.HasKey("VisitorId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("HouseAPI.Models.Complaints", b =>
                {
                    b.HasOne("HouseAPI.Models.Residents", "Resident")
                        .WithMany("Complaints")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("HouseAPI.Models.DashBoardPosts", b =>
                {
                    b.HasOne("HouseAPI.Models.Residents", "Resident")
                        .WithMany("DashBoardPosts")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("HouseAPI.Models.FriendsAndFamily", b =>
                {
                    b.HasOne("HouseAPI.Models.Residents", "Resident")
                        .WithMany("FriendsAndFamily")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("HouseAPI.Models.Payments", b =>
                {
                    b.HasOne("HouseAPI.Models.Employees", "Employee")
                        .WithMany("Payments")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("HouseAPI.Models.Residents", "Resident")
                        .WithMany("Payments")
                        .HasForeignKey("ResidentId");

                    b.HasOne("HouseAPI.Models.Services", "Service")
                        .WithMany("Payments")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("HouseAPI.Models.Residents", b =>
                {
                    b.HasOne("HouseAPI.Models.HouseList", "ResidentHouseNoNavigation")
                        .WithMany("Residents")
                        .HasForeignKey("ResidentHouseNoNavigationHouseId");
                });

            modelBuilder.Entity("HouseAPI.Models.Services", b =>
                {
                    b.HasOne("HouseAPI.Models.Employees", "Employee")
                        .WithMany("Services")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("HouseAPI.Models.Residents", "Resident")
                        .WithMany("Services")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("HouseAPI.Models.Visitors", b =>
                {
                    b.HasOne("HouseAPI.Models.Employees", "Employee")
                        .WithMany("Visitors")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("HouseAPI.Models.Residents", "Resident")
                        .WithMany("Visitors")
                        .HasForeignKey("ResidentId");
                });
#pragma warning restore 612, 618
        }
    }
}
