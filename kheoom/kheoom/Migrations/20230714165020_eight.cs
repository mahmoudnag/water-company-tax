using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kheoom.Migrations
{
    public partial class eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubscriptionID",
                table: "Invoices",
                newName: "System_SubscriptionID");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriberID",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "System_InvoiceID",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "System_InvoiceID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "System_SubscriptionID",
                table: "Invoices",
                newName: "SubscriptionID");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriberID",
                table: "Invoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
