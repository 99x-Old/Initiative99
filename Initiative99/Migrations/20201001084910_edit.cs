using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Initiatives_InitiativeActions_InitiativeActionId",
                table: "Initiatives");

            migrationBuilder.DropIndex(
                name: "IX_Initiatives_InitiativeActionId",
                table: "Initiatives");

            migrationBuilder.AddColumn<long>(
                name: "InitiativeInitiativid",
                table: "InitiativeActions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InitiativeActions_InitiativeInitiativid",
                table: "InitiativeActions",
                column: "InitiativeInitiativid");

            migrationBuilder.AddForeignKey(
                name: "FK_InitiativeActions_Initiatives_InitiativeInitiativid",
                table: "InitiativeActions",
                column: "InitiativeInitiativid",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitiativeActions_Initiatives_InitiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.DropIndex(
                name: "IX_InitiativeActions_InitiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "InitiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.CreateIndex(
                name: "IX_Initiatives_InitiativeActionId",
                table: "Initiatives",
                column: "InitiativeActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Initiatives_InitiativeActions_InitiativeActionId",
                table: "Initiatives",
                column: "InitiativeActionId",
                principalTable: "InitiativeActions",
                principalColumn: "InitiativeActionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
