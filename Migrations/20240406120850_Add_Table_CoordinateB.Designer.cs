﻿// <auto-generated />
using System;
using MakeSense.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MakeSense.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240406120850_Add_Table_CoordinateB")]
    partial class Add_Table_CoordinateB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakeSense.Models.Coordinate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("MakeSense.Models.CoordinateB", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("CoordinateB");
                });
#pragma warning restore 612, 618
        }
    }
}
