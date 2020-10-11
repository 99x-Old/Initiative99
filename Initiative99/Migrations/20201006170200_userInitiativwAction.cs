using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class userInitiativwAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInitiativeActions",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    InitiativeActionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInitiativeActions", x => new { x.UserId, x.InitiativeActionId });
                    table.ForeignKey(
                        name: "FK_UserInitiativeActions_InitiativeActions_InitiativeActionId",
                        column: x => x.InitiativeActionId,
                        principalTable: "InitiativeActions",
                        principalColumn: "InitiativeActionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInitiativeActions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInitiativeActions_InitiativeActionId",
                table: "UserInitiativeActions",
                column: "InitiativeActionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInitiativeActions");
        }
    }
}
