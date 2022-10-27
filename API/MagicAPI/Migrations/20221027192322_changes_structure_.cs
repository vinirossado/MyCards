using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicAPI.Migrations
{
    public partial class changes_structure_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_DeckCard_DeckId",
                table: "DeckCard");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckPlayer_DeckCard_DeckId",
                table: "DeckPlayer");

            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PowerLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    Guild = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_CardId",
                table: "DeckCard",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Card_CardId",
                table: "DeckCard",
                column: "CardId",
                principalTable: "Card",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Deck_DeckId",
                table: "DeckCard",
                column: "DeckId",
                principalTable: "Deck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeckPlayer_Deck_DeckId",
                table: "DeckPlayer",
                column: "DeckId",
                principalTable: "Deck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Card_CardId",
                table: "DeckCard");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Deck_DeckId",
                table: "DeckCard");

            migrationBuilder.DropForeignKey(
                name: "FK_DeckPlayer_Deck_DeckId",
                table: "DeckPlayer");

            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.DropIndex(
                name: "IX_DeckCard_CardId",
                table: "DeckCard");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_DeckCard_DeckId",
                table: "DeckCard",
                column: "DeckId",
                principalTable: "DeckCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeckPlayer_DeckCard_DeckId",
                table: "DeckPlayer",
                column: "DeckId",
                principalTable: "DeckCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
