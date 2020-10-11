using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class updateMeetingNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingNote_Meetings_MeetingId",
                table: "MeetingNote");

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "MeetingNote",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "MeetingNote",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingNote_Meetings_MeetingId",
                table: "MeetingNote",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingNote_Meetings_MeetingId",
                table: "MeetingNote");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "MeetingNote");

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "MeetingNote",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingNote_Meetings_MeetingId",
                table: "MeetingNote",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
