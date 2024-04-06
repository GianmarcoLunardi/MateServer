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
    [Migration("20240406172506_Aggiungi_tabella_Image")]
    partial class Aggiungi_tabella_Image
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakeSense.Models.Annotation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("Area")
                        .HasColumnType("real");

                    b.Property<string>("bbbox_string")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("category_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("image_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("iscrowd")
                        .HasColumnType("bit");

                    b.Property<string>("segmentation_text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Annotations");
                });

            modelBuilder.Entity("MakeSense.Models.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MakeSense.Models.Coordinate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnnotationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AnnotationId");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("MakeSense.Models.CoordinateB", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnnotationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AnnotationId");

                    b.ToTable("CoordinateB");
                });

            modelBuilder.Entity("MakeSense.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DonationBy")
                        .HasColumnType("datetime2");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("MakeSense.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MakeSense.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prog")
                        .HasColumnType("int");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Submitted")
                        .HasColumnType("datetime2");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("MakeSense.Models.Coordinate", b =>
                {
                    b.HasOne("MakeSense.Models.Annotation", null)
                        .WithMany("Segmentations")
                        .HasForeignKey("AnnotationId");
                });

            modelBuilder.Entity("MakeSense.Models.CoordinateB", b =>
                {
                    b.HasOne("MakeSense.Models.Annotation", null)
                        .WithMany("Bbox")
                        .HasForeignKey("AnnotationId");
                });

            modelBuilder.Entity("MakeSense.Models.User", b =>
                {
                    b.HasOne("MakeSense.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MakeSense.Models.Annotation", b =>
                {
                    b.Navigation("Bbox");

                    b.Navigation("Segmentations");
                });
#pragma warning restore 612, 618
        }
    }
}
