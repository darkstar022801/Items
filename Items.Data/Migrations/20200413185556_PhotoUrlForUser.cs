using Microsoft.EntityFrameworkCore.Migrations;

namespace Items.Data.Migrations
{
    public partial class PhotoUrlForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                schema: "User",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                schema: "User",
                table: "Users");
        }
    }
}
