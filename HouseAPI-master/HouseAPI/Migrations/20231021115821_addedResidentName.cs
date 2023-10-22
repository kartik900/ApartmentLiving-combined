using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseAPI.Migrations
{
    public partial class addedResidentName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResidentName",
                table: "DashBoardPosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResidentName",
                table: "DashBoardPosts");
        }
    }
}
