using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Artist = table.Column<string>(type: "TEXT", nullable: true),
                    Border = table.Column<string>(type: "TEXT", nullable: true),
                    Cmc = table.Column<float>(type: "REAL", nullable: true),
                    Flavor = table.Column<string>(type: "TEXT", nullable: true),
                    Hand = table.Column<int>(type: "INTEGER", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Layout = table.Column<string>(type: "TEXT", nullable: true),
                    Life = table.Column<int>(type: "INTEGER", nullable: true),
                    Loyalty = table.Column<string>(type: "TEXT", nullable: true),
                    ManaCost = table.Column<string>(type: "TEXT", nullable: true),
                    MultiverseId = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Number = table.Column<string>(type: "TEXT", nullable: true),
                    OriginalText = table.Column<string>(type: "TEXT", nullable: true),
                    OriginalType = table.Column<string>(type: "TEXT", nullable: true),
                    Power = table.Column<string>(type: "TEXT", nullable: true),
                    Rarity = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<string>(type: "TEXT", nullable: true),
                    Reserved = table.Column<bool>(type: "INTEGER", nullable: true),
                    Set = table.Column<string>(type: "TEXT", nullable: true),
                    SetName = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    Starter = table.Column<bool>(type: "INTEGER", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Timeshifted = table.Column<bool>(type: "INTEGER", nullable: true),
                    Toughness = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Watermark = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardId = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PowerLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    Guild = table.Column<string>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deck_Card_CardId",
                        column: x => x.CardId,
                        principalTable: "Card",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deck_CardId",
                table: "Deck",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
