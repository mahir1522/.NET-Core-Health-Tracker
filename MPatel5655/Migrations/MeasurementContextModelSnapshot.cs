﻿// <auto-generated />
using System;
using MPatel5655.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MPatel5655.Migrations
{
    [DbContext(typeof(MeasurementContext))]
    partial class MeasurementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MPatel5655.Models.Measurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Diastolic")
                        .HasColumnType("int");

                    b.Property<string>("PositionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Systolic")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Measurements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2003, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Diastolic = 79,
                            PositionId = "2",
                            Systolic = 122
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(1923, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Diastolic = 92,
                            PositionId = "3",
                            Systolic = 142
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2013, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Diastolic = 121,
                            PositionId = "1",
                            Systolic = 181
                        });
                });

            modelBuilder.Entity("MPatel5655.Models.Position", b =>
                {
                    b.Property<string>("PositionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = "1",
                            Name = "Standing"
                        },
                        new
                        {
                            PositionId = "2",
                            Name = "Sitting"
                        },
                        new
                        {
                            PositionId = "3",
                            Name = "Lying down"
                        });
                });

            modelBuilder.Entity("MPatel5655.Models.Measurement", b =>
                {
                    b.HasOne("MPatel5655.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
