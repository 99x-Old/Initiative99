using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class meetingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Initiatives_initiativeInitiativid",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_initiativeInitiativid",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "initiativeInitiativid",
                table: "Meetings");

            migrationBuilder.AddColumn<long>(
                name: "InitiativeId",
                table: "Meetings",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Meetings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_InitiativeId",
                table: "Meetings",
                column: "InitiativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Initiatives_InitiativeId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_InitiativeId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "InitiativeId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Meetings");

            migrationBuilder.AddColumn<long>(
                name: "initiativeInitiativid",
                table: "Meetings",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_initiativeInitiativid",
                table: "Meetings",
                column: "initiativeInitiativid");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Initiatives_initiativeInitiativid",
                table: "Meetings",
                column: "initiativeInitiativid",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
