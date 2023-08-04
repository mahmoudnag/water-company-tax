using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kheoom.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlockId",
                table: "Blocks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockId",
                table: "Blocks");
        }
    }
}
