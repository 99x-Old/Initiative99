using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Initiative99.Migrations
{
    public partial class editInitiativeAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitiativeActions_Initiatives_initiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.DropIndex(
                name: "IX_InitiativeActions_initiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "initiativeInitiativid",
                table: "InitiativeActions");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "InitiativeActions",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InitiativeId",
                table: "InitiativeActions",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InitiativeActions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "InitiativeActions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_InitiativeActions_InitiativeId",
                table: "InitiativeActions",
                column: "InitiativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InitiativeActions_Initiatives_InitiativeId",
                table: "InitiativeActions",
                column: "InitiativeId",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitiativeActions_Initiatives_InitiativeId",
                table: "InitiativeActions");

            migrationBuilder.DropIndex(
                name: "IX_InitiativeActions_InitiativeId",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "InitiativeId",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InitiativeActions");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "InitiativeActions");

            migrationBuilder.AddColumn<long>(
                name: "initiativeInitiativid",
                table: "InitiativeActions",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InitiativeActions_initiativeInitiativid",
                table: "InitiativeActions",
                column: "initiativeInitiativid");

            migrationBuilder.AddForeignKey(
                name: "FK_InitiativeActions_Initiatives_initiativeInitiativid",
                table: "InitiativeActions",
                column: "initiativeInitiativid",
                principalTable: "Initiatives",
                principalColumn: "Initiativid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
