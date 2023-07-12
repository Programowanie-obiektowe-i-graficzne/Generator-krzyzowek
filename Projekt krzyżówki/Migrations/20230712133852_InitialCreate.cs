using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_krzyżówki.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slowa",
                columns: table => new
                {
                    Id_Slowa = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Kategoria = table.Column<string>(type: "TEXT", nullable: false),
                    Podkategoria = table.Column<int>(type: "INTEGER", nullable: false),
                    Anagram = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slowa", x => x.Id_Slowa);
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    Id_Uzytkownik = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Rozwiazane = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.Id_Uzytkownik);
                });

            migrationBuilder.CreateTable(
                name: "Pytania",
                columns: table => new
                {
                    Id_Pytania = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tresc = table.Column<string>(type: "TEXT", nullable: false),
                    Trudnosc = table.Column<int>(type: "INTEGER", nullable: false),
                    Kategoria = table.Column<string>(type: "TEXT", nullable: false),
                    SlowoId_Slowa = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pytania", x => x.Id_Pytania);
                    table.ForeignKey(
                        name: "FK_Pytania_Slowa_SlowoId_Slowa",
                        column: x => x.SlowoId_Slowa,
                        principalTable: "Slowa",
                        principalColumn: "Id_Slowa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Krzyzowki",
                columns: table => new
                {
                    Id_Krzyzowki = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    UzytkownikId_Uzytkownik = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Krzyzowki", x => x.Id_Krzyzowki);
                    table.ForeignKey(
                        name: "FK_Krzyzowki_Uzytkownicy_UzytkownikId_Uzytkownik",
                        column: x => x.UzytkownikId_Uzytkownik,
                        principalTable: "Uzytkownicy",
                        principalColumn: "Id_Uzytkownik",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pytania_Krzyzowkis",
                columns: table => new
                {
                    Id_Pytania = table.Column<int>(type: "INTEGER", nullable: false),
                    Id_Krzyzowki = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pytania_Krzyzowkis", x => new { x.Id_Pytania, x.Id_Krzyzowki });
                    table.ForeignKey(
                        name: "FK_Pytania_Krzyzowkis_Krzyzowki_Id_Krzyzowki",
                        column: x => x.Id_Krzyzowki,
                        principalTable: "Krzyzowki",
                        principalColumn: "Id_Krzyzowki",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pytania_Krzyzowkis_Pytania_Id_Pytania",
                        column: x => x.Id_Pytania,
                        principalTable: "Pytania",
                        principalColumn: "Id_Pytania",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Krzyzowki_UzytkownikId_Uzytkownik",
                table: "Krzyzowki",
                column: "UzytkownikId_Uzytkownik");

            migrationBuilder.CreateIndex(
                name: "IX_Pytania_SlowoId_Slowa",
                table: "Pytania",
                column: "SlowoId_Slowa");

            migrationBuilder.CreateIndex(
                name: "IX_Pytania_Krzyzowkis_Id_Krzyzowki",
                table: "Pytania_Krzyzowkis",
                column: "Id_Krzyzowki");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pytania_Krzyzowkis");

            migrationBuilder.DropTable(
                name: "Krzyzowki");

            migrationBuilder.DropTable(
                name: "Pytania");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");

            migrationBuilder.DropTable(
                name: "Slowa");
        }
    }
}
