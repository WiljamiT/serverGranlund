using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocationApi.Migrations
{
    public partial class AddLocationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "Locations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Locations");
        }
    }
}
