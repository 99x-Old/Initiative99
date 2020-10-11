using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class modificationForId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitiativeActions_Initiatives_InitiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.RenameColumn(
                name: "InitiativeInitiativid",
                table: "InitiativeActions",
                newName: "initiativeInitiativid");

            migrationBuilder.RenameIndex(
                name: "IX_InitiativeActions_InitiativeInitiativid",
                table: "InitiativeActions",
                newName: "IX_InitiativeActions_initiativeInitiativid");

            migrationBuilder.AddColumn<int>(
                name: "ScheduledBy",
                table: "Meetings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_InitiativeActions_Initiatives_initiativeInitiativid",
                table: "InitiativeActions",
                column: "initiativeInitiativid",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitiativeActions_Initiatives_initiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "ScheduledBy",
                table: "Meetings");

            migrationBuilder.RenameColumn(
                name: "initiativeInitiativid",
                table: "InitiativeActions",
                newName: "InitiativeInitiativid");

            migrationBuilder.RenameIndex(
                name: "IX_InitiativeActions_initiativeInitiativid",
                table: "InitiativeActions",
                newName: "IX_InitiativeActions_InitiativeInitiativid");

            migrationBuilder.AddForeignKey(
                name: "FK_InitiativeActions_Initiatives_InitiativeInitiativid",
                table: "InitiativeActions",
                column: "InitiativeInitiativid",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
