﻿// <auto-generated />
using System;
using HoodAidReact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HoodAidReact.Migrations
{
    [DbContext(typeof(HoodAidContext))]
    partial class HoodAidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("HoodAidReact.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nachname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ort")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plz")
                        .HasColumnType("TEXT");

                    b.Property<string>("Strasse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vorname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Nachname = "Lelaire",
                            Ort = "Kaltenkirchen",
                            Plz = "24568",
                            Strasse = "Rosmarinweg 5",
                            Vorname = "Thomas"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
