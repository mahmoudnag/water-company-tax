using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kheoom.Migrations
{
    public partial class thrid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SystemsubsriptionId",
                table: "SubScribptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SystemsubsriptionId",
                table: "SubScribptions");
        }
    }
}
