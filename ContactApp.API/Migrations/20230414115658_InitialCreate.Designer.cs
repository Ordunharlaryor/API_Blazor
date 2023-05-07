﻿// <auto-generated />
using System;
using ContactApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactApp.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230414115658_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactAppModels.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Doe",
                            Occupation = "Engineer",
                            PhotoPath = "Images/john.jpg"
                        },
                        new
                        {
                            Id = 1002,
                            DateOfBirth = new DateTime(1985, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarahj@example.com",
                            FirstName = "Sarah",
                            Gender = 1,
                            LastName = "Johnson",
                            Occupation = "Entrepreneur",
                            PhotoPath = "Images/sarah.jpg"
                        },
                        new
                        {
                            Id = 1003,
                            DateOfBirth = new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michaels@example.com",
                            FirstName = "Michael",
                            Gender = 0,
                            LastName = "Smith",
                            Occupation = "Doctor",
                            PhotoPath = "Images/michael.jpeg"
                        },
                        new
                        {
                            Id = 1004,
                            DateOfBirth = new DateTime(1989, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mauriceg@example.com",
                            FirstName = "Maurice",
                            Gender = 0,
                            LastName = "Gray",
                            Occupation = "Banker",
                            PhotoPath = "Images/maurice.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}