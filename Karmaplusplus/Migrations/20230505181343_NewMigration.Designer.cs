﻿// <auto-generated />
using Karmaplusplus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Karmaplusplus.Migrations
{
    [DbContext(typeof(KarmaplusplusContext))]
    [Migration("20230505181343_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Karmaplusplus.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceId = 1,
                            Description = "Free English lessons",
                            Email = "english.lessons@gmail.com",
                            ServiceName = "lesson",
                            UserId = "123",
                            ZipCode = "98052"
                        },
                        new
                        {
                            ServiceId = 2,
                            Description = "Free haircuts for men, women and children",
                            Email = "free.haircuts@gmail.com",
                            ServiceName = "haircut",
                            UserId = "123",
                            ZipCode = "98040"
                        },
                        new
                        {
                            ServiceId = 3,
                            Description = "Free babysitting for single mothers at your home",
                            Email = "free.babysitting@gmail.com",
                            ServiceName = "babysitting",
                            UserId = "123",
                            ZipCode = "98033"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
