using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kheoom.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blockcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blockcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionID = table.Column<int>(type: "int", nullable: false),
                    SubscriberID = table.Column<int>(type: "int", nullable: false),
                    SubscriberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastRead = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NowRead = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Consumption_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sanitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subscription_BlockNumbers = table.Column<int>(type: "int", nullable: false),
                    Service_Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConsumptionValue_Water = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConsumptionValue_Sanitation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Invoice_Value_ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Invoice_All_Value_ = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slice_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsumptionValue_Slice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BlockNumbers = table.Column<int>(type: "int", nullable: false),
                    price_liter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price_Sanitation = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubScribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubScribers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubScribptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberID = table.Column<int>(type: "int", nullable: false),
                    SubscriberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlockNumbers = table.Column<int>(type: "int", nullable: false),
                    BlockType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sanitation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubScribptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubScribptions_SubScribers_SubscriberID",
                        column: x => x.SubscriberID,
                        principalTable: "SubScribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "123", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_SubScribptions_SubscriberID",
                table: "SubScribptions",
                column: "SubscriberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blockcs");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Slices");

            migrationBuilder.DropTable(
                name: "SubScribptions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubScribers");
        }
    }
}
