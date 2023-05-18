﻿// <auto-generated />
using System;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    [Migration("20230510090342_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.Models.Booking", b =>
                {
                    b.Property<int>("Booking_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Booking_Id"));

                    b.Property<DateTime>("End_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("Machine_Id")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Booking_Id");

                    b.HasIndex("Machine_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Machine", b =>
                {
                    b.Property<int>("Machine_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Machine_Id"));

                    b.Property<int>("Brand_Id")
                        .HasColumnType("int");

                    b.Property<string>("Brand_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Machine_Available")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Machine_Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Model_Id")
                        .HasColumnType("int");

                    b.Property<string>("Model_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Machine_Id");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Market", b =>
                {
                    b.Property<int>("Prodect_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Prodect_Id"));

                    b.Property<string>("Product_Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Prodect_Id");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("DataAccessLayer.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<int>("Aadhar_No")
                        .HasColumnType("int");

                    b.Property<int>("Contact_No")
                        .HasColumnType("int");

                    b.Property<string>("Father_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Booking", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("Machine_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
