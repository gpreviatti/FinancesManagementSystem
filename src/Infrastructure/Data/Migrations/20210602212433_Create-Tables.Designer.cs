﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210602212433_Create-Tables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 165, DateTimeKind.Local).AddTicks(4695));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 165, DateTimeKind.Local).AddTicks(5011));

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("18301de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Salary",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18341de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Loans",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18351de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Other Earnings",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18361de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Investiments",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18371de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Food",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18381de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Transport",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18391de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Services",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18401de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Health",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18411de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Education",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18421de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Travel",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18431de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Work",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18441de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gifts",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18451de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Home",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("18461de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Other Expanses",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Entrance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 169, DateTimeKind.Local).AddTicks(4737));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Observation")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Ticker")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 169, DateTimeKind.Local).AddTicks(5098));

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<Guid>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WalletId");

                    b.HasIndex("Id", "CategoryId")
                        .IsClustered(false);

                    b.ToTable("Entrances");

                    b.HasData(
                        new
                        {
                            Id = new Guid("88ee76b4-e159-44ff-81a8-922ee1f5172b"),
                            CategoryId = new Guid("18411de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 718.0,
                            WalletId = new Guid("041cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("77e77c02-e763-4eff-afa4-d5b37f48436b"),
                            CategoryId = new Guid("18391de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 772.0,
                            WalletId = new Guid("040cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("484165aa-cb5a-41a6-9a2c-351b54f406ed"),
                            CategoryId = new Guid("18431de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 499.0,
                            WalletId = new Guid("041cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("420a0164-097e-4fe0-9d4d-d5bec5a0d6f4"),
                            CategoryId = new Guid("18411de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 500.0,
                            WalletId = new Guid("040cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("8cbc6a55-3f53-46e2-9159-31646126d285"),
                            CategoryId = new Guid("18381de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 672.0,
                            WalletId = new Guid("041cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("f401cadb-b05d-4c36-aee0-151f0f6469ac"),
                            CategoryId = new Guid("18411de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 377.0,
                            WalletId = new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("f3e72eb0-47e4-4cce-ace0-40455baf9d78"),
                            CategoryId = new Guid("18461de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 976.0,
                            WalletId = new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("83d080a9-07b2-4db6-9a96-443953c97b55"),
                            CategoryId = new Guid("18421de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 771.0,
                            WalletId = new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("9b862cec-5971-4ffc-b82e-934fbb0af755"),
                            CategoryId = new Guid("18411de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 524.0,
                            WalletId = new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f")
                        },
                        new
                        {
                            Id = new Guid("a60f23ae-0c03-4d9c-8e31-8a4d8a73c478"),
                            CategoryId = new Guid("18371de4-a10f-404e-8ce7-836f297382bb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem Ipsum",
                            Observation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Type = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 162.0,
                            WalletId = new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Propperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 172, DateTimeKind.Local).AddTicks(6436));

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 144, DateTimeKind.Local).AddTicks(7345));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 152, DateTimeKind.Local).AddTicks(8709));

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "$2a$11$k8al7XOOgrZwu25tOY30POrA75n7XXHJlozGDK1TtwDXjp0IrsQQ6",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("cb43d078-87f1-4864-853a-e626922b8109"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "testUser01@email.com",
                            Name = "Test-User-01",
                            Password = "$2a$11$Dxf4l/m622igWPFwxyPvxOGtW77NlipYXh.E4V0CEw4nmrP/4lFZK",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 163, DateTimeKind.Local).AddTicks(2682));

                    b.Property<double>("CurrentValue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 163, DateTimeKind.Local).AddTicks(3566));

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WalletTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletTypeId");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("040cc3ad-2159-4b8e-894e-e700a121b48f"),
                            CloseDate = new DateTime(2021, 6, 2, 18, 24, 33, 443, DateTimeKind.Local).AddTicks(6918),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentValue = 500.0,
                            Description = "Main Account",
                            DueDate = new DateTime(2021, 6, 17, 18, 24, 33, 443, DateTimeKind.Local).AddTicks(7272),
                            Name = "Main Card",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            WalletTypeId = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e37")
                        },
                        new
                        {
                            Id = new Guid("041cc3ad-2159-4b8e-894e-e700a121b48f"),
                            CloseDate = new DateTime(2021, 6, 2, 18, 24, 33, 443, DateTimeKind.Local).AddTicks(7707),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentValue = 500.0,
                            Description = "Credit Card Account",
                            DueDate = new DateTime(2021, 6, 17, 18, 24, 33, 443, DateTimeKind.Local).AddTicks(7711),
                            Name = "Credit",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            WalletTypeId = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e38")
                        },
                        new
                        {
                            Id = new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f"),
                            CloseDate = new DateTime(2021, 6, 2, 18, 24, 33, 443, DateTimeKind.Local).AddTicks(7721),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentValue = 1000.0,
                            Description = "My Savings",
                            DueDate = new DateTime(2021, 6, 17, 18, 24, 33, 443, DateTimeKind.Local).AddTicks(7721),
                            Name = "Saving",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            WalletTypeId = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e39")
                        });
                });

            modelBuilder.Entity("Domain.Entities.WalletType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 162, DateTimeKind.Local).AddTicks(938));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 6, 2, 18, 24, 33, 162, DateTimeKind.Local).AddTicks(1362));

                    b.HasKey("Id");

                    b.ToTable("WalletTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e37"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Checking Account",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e38"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Credit",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e39"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Saving",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e40"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Investiments",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e41"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Stocks",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.HasOne("Domain.Entities.Category", "CustomCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("UserId");

                    b.Navigation("CustomCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Entrance", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Entrances")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Wallet", "Wallet")
                        .WithMany("Entrances")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("Domain.Entities.Wallet", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.WalletType", "WalletType")
                        .WithMany("Wallets")
                        .HasForeignKey("WalletTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("WalletType");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Entrances");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("Domain.Entities.Wallet", b =>
                {
                    b.Navigation("Entrances");
                });

            modelBuilder.Entity("Domain.Entities.WalletType", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}