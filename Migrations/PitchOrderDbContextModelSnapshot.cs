﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApiPitchOrder.Data;

#nullable disable

namespace TestApiPitchOrder.Migrations
{
    [DbContext(typeof(PitchOrderDbContext))]
    partial class PitchOrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestApiPitchOrder.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountTypeId = 1,
                            Address = "Admin Address",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6864),
                            Email = "admin@gmail.com",
                            Name = "Admin1",
                            Password = "8ddcff3a80f4189ca1c9d4d902c3c909",
                            Phone = "1234567890",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6861)
                        },
                        new
                        {
                            Id = 2,
                            AccountTypeId = 2,
                            Address = "Ha Noi",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6867),
                            Email = "dmh@example.com",
                            Name = "Duc Minh Hoang",
                            Password = "25d55ad283aa400af464c76d713c07ad",
                            Phone = "0987654321",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6866)
                        },
                        new
                        {
                            Id = 3,
                            AccountTypeId = 2,
                            Address = "Ha Noi",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6869),
                            Email = "vtq@gamil.com",
                            Name = "Vu Tung Quan",
                            Password = "25d55ad283aa400af464c76d713c07ad",
                            Phone = "0987654322",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6868)
                        },
                        new
                        {
                            Id = 4,
                            AccountTypeId = 2,
                            Address = "Ha Noi",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6871),
                            Email = "vmd@gmail.com",
                            Name = "Vu Minh Duc",
                            Password = "25d55ad283aa400af464c76d713c07ad",
                            Phone = "0987654324",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6870)
                        },
                        new
                        {
                            Id = 5,
                            AccountTypeId = 2,
                            Address = "Ha Noi",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6873),
                            Email = "nad@gmail.com",
                            Name = "Nguyen Ai Dan",
                            Password = "25d55ad283aa400af464c76d713c07ad",
                            Phone = "0987654325",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6872)
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AccountTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6428),
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6421)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6431),
                            Name = "User",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6430)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6432),
                            Name = "Guest",
                            UpdatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6432)
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Banks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankNumber = "123456789",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6732),
                            Image = "Resources\\Banks\\vcb.jpg",
                            Name = "Vietcombank"
                        },
                        new
                        {
                            Id = 2,
                            BankNumber = "987654321",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6735),
                            Image = "Resources\\Banks\\mbbank.jpg",
                            Name = "Mbbank"
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("UsageLimit")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 10,
                            Code = "Group5MaiDinh",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6760),
                            EndDate = new DateTime(2024, 9, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6755),
                            UsageLimit = 1000000.0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 20,
                            Code = "Deptraicogisai",
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6763),
                            EndDate = new DateTime(2024, 10, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6762),
                            UsageLimit = 500000.0
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.FootballPitch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMaintenance")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("PitchTypeId")
                        .HasColumnType("int");

                    b.Property<double>("PricePerHour")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("TimeEnd")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TimeStart")
                        .HasColumnType("time");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PitchTypeId");

                    b.ToTable("FootballPitches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6834),
                            Description = "Standard Pitch",
                            IsMaintenance = false,
                            Name = "Sân bóng Thành Đô",
                            PitchTypeId = 2,
                            PricePerHour = 700000.0,
                            TimeEnd = new TimeSpan(0, 23, 0, 0, 0),
                            TimeStart = new TimeSpan(0, 6, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6838),
                            Description = "Normal Pitch",
                            IsMaintenance = false,
                            Name = "Sân bóng Lai Xá",
                            PitchTypeId = 1,
                            PricePerHour = 500000.0,
                            TimeEnd = new TimeSpan(0, 23, 0, 0, 0),
                            TimeStart = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6839),
                            Description = "Advanced Pitch",
                            IsMaintenance = true,
                            Name = "Sân bóng Nguyên Xá",
                            PitchTypeId = 4,
                            PricePerHour = 900000.0,
                            TimeEnd = new TimeSpan(0, 17, 0, 0, 0),
                            TimeStart = new TimeSpan(0, 6, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6841),
                            Description = "Advanced Pitch",
                            IsMaintenance = false,
                            Name = "Sân bóng Mai Dịch",
                            PitchTypeId = 3,
                            PricePerHour = 750000.0,
                            TimeEnd = new TimeSpan(0, 23, 0, 0, 0),
                            TimeStart = new TimeSpan(0, 5, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6843),
                            Description = "Advanced Pitch",
                            IsMaintenance = false,
                            Name = "Sân bóng Minh Khai",
                            PitchTypeId = 2,
                            PricePerHour = 700000.0,
                            TimeEnd = new TimeSpan(0, 17, 0, 0, 0),
                            TimeStart = new TimeSpan(0, 8, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<double>("Deposit")
                        .HasColumnType("float");

                    b.Property<int?>("DiscountId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FootballPitchId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BankId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("FootballPitchId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 2,
                            BankId = 1,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6926),
                            Deposit = 100000.0,
                            Email = "dmh@gamil.com",
                            EndAt = new DateTime(2024, 8, 13, 13, 8, 57, 206, DateTimeKind.Local).AddTicks(6924),
                            FootballPitchId = 1,
                            Name = "Order_1",
                            Phone = "1234567890",
                            StartAt = new DateTime(2024, 8, 13, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6919),
                            Status = 3,
                            Total = 1000000.0
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 3,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6931),
                            Deposit = 150000.0,
                            DiscountId = 2,
                            Email = "order2@example.com",
                            EndAt = new DateTime(2024, 8, 15, 13, 8, 57, 206, DateTimeKind.Local).AddTicks(6929),
                            FootballPitchId = 2,
                            Name = "Order_2",
                            Phone = "0987654321",
                            StartAt = new DateTime(2024, 8, 15, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6928),
                            Status = 0,
                            Total = 700000.0
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 1,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6933),
                            Deposit = 150000.0,
                            DiscountId = 2,
                            Email = "order2@example.com",
                            EndAt = new DateTime(2024, 8, 16, 13, 8, 57, 206, DateTimeKind.Local).AddTicks(6932),
                            FootballPitchId = 2,
                            Name = "Order_3",
                            Phone = "0987654321",
                            StartAt = new DateTime(2024, 8, 16, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6932),
                            Status = 2,
                            Total = 700000.0
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 3,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6936),
                            Deposit = 150000.0,
                            DiscountId = 2,
                            Email = "order2@example.com",
                            EndAt = new DateTime(2024, 8, 16, 13, 8, 57, 206, DateTimeKind.Local).AddTicks(6935),
                            FootballPitchId = 2,
                            Name = "Order_4",
                            Phone = "0987654321",
                            StartAt = new DateTime(2024, 8, 17, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6935),
                            Status = 1,
                            Total = 700000.0
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.PitchImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FootballPitchId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FootballPitchId");

                    b.ToTable("PitchImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FootballPitchId = 1,
                            Image = "Resources\\PitchImages\\p1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            FootballPitchId = 1,
                            Image = "Resources\\PitchImages\\p2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            FootballPitchId = 1,
                            Image = "Resources\\PitchImages\\p3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            FootballPitchId = 1,
                            Image = "Resources\\PitchImages\\p4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            FootballPitchId = 2,
                            Image = "Resources\\PitchImages\\p5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            FootballPitchId = 2,
                            Image = "Resources\\PitchImages\\p6.jpg"
                        },
                        new
                        {
                            Id = 7,
                            FootballPitchId = 2,
                            Image = "Resources\\PitchImages\\p7.jpg"
                        },
                        new
                        {
                            Id = 8,
                            FootballPitchId = 2,
                            Image = "Resources\\PitchImages\\p8.jpg"
                        },
                        new
                        {
                            Id = 9,
                            FootballPitchId = 2,
                            Image = "Resources\\PitchImages\\p9.jpg"
                        },
                        new
                        {
                            Id = 10,
                            FootballPitchId = 3,
                            Image = "Resources\\PitchImages\\p10.jpg"
                        },
                        new
                        {
                            Id = 11,
                            FootballPitchId = 3,
                            Image = "Resources\\PitchImages\\p11.jpg"
                        },
                        new
                        {
                            Id = 12,
                            FootballPitchId = 4,
                            Image = "Resources\\PitchImages\\p12.jpg"
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.PitchType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PitchTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6706),
                            Description = "5v5",
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6709),
                            Description = "7v7",
                            Quantity = 7
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6710),
                            Description = "9v9",
                            Quantity = 9
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 8, 14, 11, 8, 57, 206, DateTimeKind.Local).AddTicks(6711),
                            Description = "11v11",
                            Quantity = 11
                        });
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Account", b =>
                {
                    b.HasOne("TestApiPitchOrder.Models.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.FootballPitch", b =>
                {
                    b.HasOne("TestApiPitchOrder.Models.PitchType", "PitchType")
                        .WithMany("FootballPitches")
                        .HasForeignKey("PitchTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PitchType");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Order", b =>
                {
                    b.HasOne("TestApiPitchOrder.Models.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestApiPitchOrder.Models.Bank", "Bank")
                        .WithMany("Orders")
                        .HasForeignKey("BankId");

                    b.HasOne("TestApiPitchOrder.Models.Discount", "Discount")
                        .WithMany("Orders")
                        .HasForeignKey("DiscountId");

                    b.HasOne("TestApiPitchOrder.Models.FootballPitch", "FootballPitch")
                        .WithMany("Orders")
                        .HasForeignKey("FootballPitchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Bank");

                    b.Navigation("Discount");

                    b.Navigation("FootballPitch");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.PitchImage", b =>
                {
                    b.HasOne("TestApiPitchOrder.Models.FootballPitch", "FootballPitch")
                        .WithMany("PitchImages")
                        .HasForeignKey("FootballPitchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FootballPitch");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Account", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Bank", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.Discount", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.FootballPitch", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PitchImages");
                });

            modelBuilder.Entity("TestApiPitchOrder.Models.PitchType", b =>
                {
                    b.Navigation("FootballPitches");
                });
#pragma warning restore 612, 618
        }
    }
}
