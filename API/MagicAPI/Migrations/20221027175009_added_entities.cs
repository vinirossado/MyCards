using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicAPI.Migrations
{
    public partial class added_entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deck_Card_CardId",
                table: "Deck");

            migrationBuilder.DropIndex(
                name: "IX_Deck_CardId",
                table: "Deck");

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeckPlayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false),
                    DeckId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckPlayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeckPlayer_Deck_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Deck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckPlayer_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeckPlayer_DeckId",
                table: "DeckPlayer",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckPlayer_PlayerId",
                table: "DeckPlayer",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckPlayer");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.CreateIndex(
                name: "IX_Deck_CardId",
                table: "Deck",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deck_Card_CardId",
                table: "Deck",
                column: "CardId",
                principalTable: "Card",
                principalColumn: "Id");
        }
    }
}
