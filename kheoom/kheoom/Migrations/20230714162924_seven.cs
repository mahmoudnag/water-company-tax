using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kheoom.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubScribptions_SubScribers_SubscriberID",
                table: "SubScribptions");

            migrationBuilder.DropIndex(
                name: "IX_SubScribptions_SubscriberID",
                table: "SubScribptions");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriberID",
                table: "SubScribptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SubscriberID",
                table: "SubScribptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_SubScribptions_SubscriberID",
                table: "SubScribptions",
                column: "SubscriberID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubScribptions_SubScribers_SubscriberID",
                table: "SubScribptions",
                column: "SubscriberID",
                principalTable: "SubScribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
