using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kheoom.Migrations
{
    public partial class ten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Invoice_All_Value_",
                table: "Invoices",
                newName: "Invoice_All_Value");

            migrationBuilder.AddColumn<decimal>(
                name: "LastRead",
                table: "SubScribptions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastRead",
                table: "SubScribptions");

            migrationBuilder.RenameColumn(
                name: "Invoice_All_Value",
                table: "Invoices",
                newName: "Invoice_All_Value_");
        }
    }
}
