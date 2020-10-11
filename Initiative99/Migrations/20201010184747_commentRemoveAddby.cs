using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class commentRemoveAddby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addby",
                table: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addby",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
