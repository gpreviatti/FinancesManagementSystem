﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Data.Migrations
{
    public partial class Create_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    MessageTemplate = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Level = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 362, DateTimeKind.Local).AddTicks(2751)),
                    Exception = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Propperties = table.Column<string>(type: "VARCHAR(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 324, DateTimeKind.Local).AddTicks(6803)),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 334, DateTimeKind.Local).AddTicks(2293))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WalletTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 343, DateTimeKind.Local).AddTicks(5062)),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 343, DateTimeKind.Local).AddTicks(5528))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 348, DateTimeKind.Local).AddTicks(7912)),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 348, DateTimeKind.Local).AddTicks(8346))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CurrentValue = table.Column<double>(type: "double precision", nullable: false, defaultValue: 0.0),
                    DueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    WalletTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 345, DateTimeKind.Local).AddTicks(2223)),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 345, DateTimeKind.Local).AddTicks(3656))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wallets_WalletTypes_WalletTypeId",
                        column: x => x.WalletTypeId,
                        principalTable: "WalletTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", maxLength: 36, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Ticker = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Observation = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    WalletId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 356, DateTimeKind.Local).AddTicks(6670)),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2022, 5, 21, 17, 9, 33, 356, DateTimeKind.Local).AddTicks(7265))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrances_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrances_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("18301de4-a10f-404e-8ce7-836f297382bb"), null, "Salary", null },
                    { new Guid("18461de4-a10f-404e-8ce7-836f297382bb"), null, "Other Expanses", null },
                    { new Guid("18451de4-a10f-404e-8ce7-836f297382bb"), null, "Home", null },
                    { new Guid("18441de4-a10f-404e-8ce7-836f297382bb"), null, "Gifts", null },
                    { new Guid("18421de4-a10f-404e-8ce7-836f297382bb"), null, "Travel", null },
                    { new Guid("18411de4-a10f-404e-8ce7-836f297382bb"), null, "Education", null },
                    { new Guid("18401de4-a10f-404e-8ce7-836f297382bb"), null, "Health", null },
                    { new Guid("18431de4-a10f-404e-8ce7-836f297382bb"), null, "Work", null },
                    { new Guid("18381de4-a10f-404e-8ce7-836f297382bb"), null, "Transport", null },
                    { new Guid("18371de4-a10f-404e-8ce7-836f297382bb"), null, "Food", null },
                    { new Guid("18361de4-a10f-404e-8ce7-836f297382bb"), null, "Investiments", null },
                    { new Guid("18351de4-a10f-404e-8ce7-836f297382bb"), null, "Other Earnings", null },
                    { new Guid("18341de4-a10f-404e-8ce7-836f297382bb"), null, "Loans", null },
                    { new Guid("18391de4-a10f-404e-8ce7-836f297382bb"), null, "Services", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"), "admin@admin.com", "Admin", "$2a$11$c.SIFTETbDiPYleF/XoVAuKjtJ26SNK7lfeAdSXmugTr4e/N0B7sC" },
                    { new Guid("cb43d078-87f1-4864-853a-e626922b8109"), "testUser01@email.com", "Test-User-01", "$2a$11$7J.2vbWhQHkLXa0T.PSddu8Nmz5uUA6ljP4N9gpMTSv3dcYpwbRV2" }
                });

            migrationBuilder.InsertData(
                table: "WalletTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ad4ac47f-0888-4d60-81f9-964153b13e40"), "Investiments" },
                    { new Guid("ad4ac47f-0888-4d60-81f9-964153b13e37"), "Checking Account" },
                    { new Guid("ad4ac47f-0888-4d60-81f9-964153b13e38"), "Credit" },
                    { new Guid("ad4ac47f-0888-4d60-81f9-964153b13e39"), "Saving" },
                    { new Guid("ad4ac47f-0888-4d60-81f9-964153b13e41"), "Stocks" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "CloseDate", "Description", "DueDate", "Name", "UserId", "WalletTypeId" },
                values: new object[,]
                {
                    { new Guid("040cc3ad-2159-4b8e-894e-e700a121b48f"), new DateTime(2022, 5, 21, 17, 9, 33, 763, DateTimeKind.Local).AddTicks(2367), "Main Account", new DateTime(2022, 6, 5, 17, 9, 33, 763, DateTimeKind.Local).AddTicks(2769), "Main Card", new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"), new Guid("ad4ac47f-0888-4d60-81f9-964153b13e37") },
                    { new Guid("041cc3ad-2159-4b8e-894e-e700a121b48f"), new DateTime(2022, 5, 21, 17, 9, 33, 763, DateTimeKind.Local).AddTicks(3262), "Credit Card Account", new DateTime(2022, 6, 5, 17, 9, 33, 763, DateTimeKind.Local).AddTicks(3267), "Credit", new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"), new Guid("ad4ac47f-0888-4d60-81f9-964153b13e38") },
                    { new Guid("042cc3ad-2159-4b8e-894e-e700a121b48f"), new DateTime(2022, 5, 21, 17, 9, 33, 763, DateTimeKind.Local).AddTicks(3281), "My Savings", new DateTime(2022, 6, 5, 17, 9, 33, 763, DateTimeKind.Local).AddTicks(3283), "Saving", new Guid("430e0144-289f-4a95-8f14-bacfabb3fe8a"), new Guid("ad4ac47f-0888-4d60-81f9-964153b13e39") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_CategoryId",
                table: "Entrances",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Id_CategoryId",
                table: "Entrances",
                columns: new[] { "Id", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_WalletId",
                table: "Entrances",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_WalletTypeId",
                table: "Wallets",
                column: "WalletTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrances");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WalletTypes");
        }
    }
}