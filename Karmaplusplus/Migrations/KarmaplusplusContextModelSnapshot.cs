﻿// <auto-generated />
using Karmaplusplus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Karmaplusplus.Migrations
{
    [DbContext(typeof(KarmaplusplusContext))]
    partial class KarmaplusplusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<float>("ZipCode")
                        .HasColumnType("float");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceId = 1,
                            Description = "Free English lessons",
                            Email = "english.lessons@gmail.com",
                            ServiceName = "lesson",
                            ZipCode = 98052f
                        },
                        new
                        {
                            ServiceId = 2,
                            Description = "Free haircuts for men, women and children",
                            Email = "free.haircuts@gmail.com",
                            ServiceName = "haircut",
                            ZipCode = 98040f
                        },
                        new
                        {
                            ServiceId = 3,
                            Description = "Free babysitting for single mothers at your home",
                            Email = "free.babysitting@gmail.com",
                            ServiceName = "babysitting",
                            ZipCode = 98033f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}