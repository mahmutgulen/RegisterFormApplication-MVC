﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RFA.DAL.Concrete.EntityFramework;

#nullable disable

namespace RFA.DAL.Migrations
{
    [DbContext(typeof(RFAContext))]
    [Migration("20230929101416_mako")]
    partial class mako
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RFA.ENTITY.Concrete.PaymentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccommodationFee")
                        .HasColumnType("int");

                    b.Property<int?>("CourseFee")
                        .HasColumnType("int");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<int?>("GalaFee")
                        .HasColumnType("int");

                    b.Property<int?>("ParticipationFee")
                        .HasColumnType("int");

                    b.Property<int?>("RegistrationInfoId")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PaymentInfos");
                });

            modelBuilder.Entity("RFA.ENTITY.Concrete.RegistrationInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte?>("AccomodationType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Commitee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("CompanionGalaType")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("CompanionType")
                        .HasColumnType("tinyint");

                    b.Property<string>("CompoanionFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("GalaType")
                        .HasColumnType("tinyint");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("PostCourseType")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("PreCourseType")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("RegistrationType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RegistrationInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
