﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afe84d2d-3cfb-45f2-af1a-9cb1dcdead56"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5341),
                            Name = "Salary",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5347)
                        },
                        new
                        {
                            Id = new Guid("5a207b72-66b5-4621-b304-30cf1a6b472d"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5362),
                            Name = "Loans",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5363)
                        },
                        new
                        {
                            Id = new Guid("19f0a471-e247-4c52-b7b5-6503561cef10"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5365),
                            Name = "Other Earnings",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5365)
                        },
                        new
                        {
                            Id = new Guid("3cf74692-98cc-4519-aff5-ea887aa4764c"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5367),
                            Name = "Investiments",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5367)
                        },
                        new
                        {
                            Id = new Guid("fdff15a0-efac-496f-8065-2ec89a72fae0"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5369),
                            Name = "Food",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5370)
                        },
                        new
                        {
                            Id = new Guid("bd2abc15-5a49-4526-a8d2-3c6ca85c99da"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5373),
                            Name = "Transport",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5374)
                        },
                        new
                        {
                            Id = new Guid("fe0ff864-b8f0-4f2f-8a66-55e7a64ffa5d"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5375),
                            Name = "Services",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5376)
                        },
                        new
                        {
                            Id = new Guid("4b5da34a-5317-4c5c-af76-2dac83e67a41"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5413),
                            Name = "Health",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5414)
                        },
                        new
                        {
                            Id = new Guid("3c94fc52-f3b0-4013-80c3-ebf7ea0dd19c"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5416),
                            Name = "Education",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5417)
                        },
                        new
                        {
                            Id = new Guid("636cf9fe-ddc3-4b38-a080-6cc2f9dc1c3d"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5419),
                            Name = "Travel",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5420)
                        },
                        new
                        {
                            Id = new Guid("35603d7f-865f-4496-ac08-1276cacf8583"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5421),
                            Name = "Work",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5422)
                        },
                        new
                        {
                            Id = new Guid("2a01b945-1bf1-4da1-af03-51e85106e57c"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5423),
                            Name = "Gifts",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5424)
                        },
                        new
                        {
                            Id = new Guid("c8735def-95a7-4600-b0e9-3a38796fe5a0"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5425),
                            Name = "Industrials",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5426)
                        },
                        new
                        {
                            Id = new Guid("b26c3953-e45e-4078-9c4f-e529aeb92648"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5427),
                            Name = "Financials",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5428)
                        },
                        new
                        {
                            Id = new Guid("46ef3354-87ca-42cc-88ed-761531f39ee2"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5429),
                            Name = "Energy",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5430)
                        },
                        new
                        {
                            Id = new Guid("6b89bf02-ecbd-4605-8a9a-0b1e3b28db62"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5433),
                            Name = "Consumer Discretionary",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5434)
                        },
                        new
                        {
                            Id = new Guid("245e6f7a-f849-4323-baee-dd1212c546af"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5435),
                            Name = "Information Technology",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5436)
                        },
                        new
                        {
                            Id = new Guid("bcfe7168-9ccd-400d-b3eb-5744c695568f"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5438),
                            Name = "Communication Services",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5439)
                        },
                        new
                        {
                            Id = new Guid("48b2a969-863e-4ee5-810c-489bf389182b"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5440),
                            Name = "Real Estate",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5441)
                        },
                        new
                        {
                            Id = new Guid("3f0f75d2-1504-429c-953a-2a6369c49375"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5442),
                            Name = "Health Care",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5443)
                        },
                        new
                        {
                            Id = new Guid("fb156b5e-29f0-4b1f-a473-2d931efc3ee6"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5444),
                            Name = "Consumer Staples",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5445)
                        },
                        new
                        {
                            Id = new Guid("c7076130-71e9-4e6e-9279-998d487f60de"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5446),
                            Name = "Utilities",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(5447)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Entrace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

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
                        .HasColumnType("datetime2");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<Guid>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WalletId");

                    b.ToTable("Entraces");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

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
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 693, DateTimeKind.Local).AddTicks(1851),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "$2a$11$eS63Z.krrkXp971dszCK9.uR3tm3SYzxWIeyoS1/A/PDHW/DlXs.y",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 693, DateTimeKind.Local).AddTicks(8917)
                        },
                        new
                        {
                            Id = new Guid("cb43d078-87f1-4864-853a-e626922b8109"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 816, DateTimeKind.Local).AddTicks(9769),
                            Email = "testUser01@email.com",
                            Name = "Test-User-01",
                            Password = "$2a$11$v/2.Dd2yL7Rfp4zymjQsgubDASRihHvYVIITxM1zelywzaIcIMGVq",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 816, DateTimeKind.Local).AddTicks(9791)
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
                        .HasColumnType("datetime2");

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
                        .HasColumnType("datetime2");

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
                            Id = new Guid("722b84da-1628-49af-b09b-b622271af6ec"),
                            CloseDate = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(178),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(965),
                            CurrentValue = 500.0,
                            Description = "Main Account",
                            DueDate = new DateTime(2021, 5, 11, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(470),
                            Name = "Inter",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(969),
                            UserId = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            WalletTypeId = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e37")
                        },
                        new
                        {
                            Id = new Guid("c5ee0354-48af-4bac-a752-ab99f3c747b3"),
                            CloseDate = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(1007),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(1014),
                            CurrentValue = 500.0,
                            Description = "Credit Card Account",
                            DueDate = new DateTime(2021, 5, 11, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(1009),
                            Name = "Credit",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 819, DateTimeKind.Local).AddTicks(1015),
                            UserId = new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"),
                            WalletTypeId = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e38")
                        });
                });

            modelBuilder.Entity("Domain.Entities.WalletType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WalletTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e37"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(3423),
                            Name = "Checking Account",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(3431)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e38"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(3809),
                            Name = "Credit",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(3812)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e39"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(4128),
                            Name = "Saving",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(4131)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e40"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(4428),
                            Name = "Investiments",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(4430)
                        },
                        new
                        {
                            Id = new Guid("ad4ac47f-0888-4d60-81f9-964153b13e41"),
                            CreatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(4719),
                            Name = "Stocks",
                            UpdatedAt = new DateTime(2021, 4, 26, 7, 59, 9, 818, DateTimeKind.Local).AddTicks(4721)
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

            modelBuilder.Entity("Domain.Entities.Entrace", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Entraces")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Wallet", "Wallet")
                        .WithMany("Entraces")
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
                    b.Navigation("Entraces");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("Domain.Entities.Wallet", b =>
                {
                    b.Navigation("Entraces");
                });

            modelBuilder.Entity("Domain.Entities.WalletType", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
