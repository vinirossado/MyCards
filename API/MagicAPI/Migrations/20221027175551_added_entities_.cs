using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicAPI.Migrations
{
    public partial class added_entities_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guild",
                table: "Deck");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Deck");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Deck");

            migrationBuilder.RenameColumn(
                name: "PowerLevel",
                table: "Deck",
                newName: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Deck_DeckId",
                table: "Deck",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deck_Deck_DeckId",
                table: "Deck",
                column: "DeckId",
                principalTable: "Deck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deck_Deck_DeckId",
                table: "Deck");

            migrationBuilder.DropIndex(
                name: "IX_Deck_DeckId",
                table: "Deck");

            migrationBuilder.RenameColumn(
                name: "DeckId",
                table: "Deck",
                newName: "PowerLevel");

            migrationBuilder.AddColumn<string>(
                name: "Guild",
                table: "Deck",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Deck",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Deck",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
