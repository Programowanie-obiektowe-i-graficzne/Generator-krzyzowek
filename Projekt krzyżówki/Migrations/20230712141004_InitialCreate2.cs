using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_krzyżówki.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pytania_Krzyzowkis_Krzyzowki_Id_Krzyzowki",
                table: "Pytania_Krzyzowkis");

            migrationBuilder.DropIndex(
                name: "IX_Pytania_Krzyzowkis_Id_Krzyzowki",
                table: "Pytania_Krzyzowkis");

            migrationBuilder.AddForeignKey(
                name: "FK_Pytania_Krzyzowkis_Krzyzowki_Id_Pytania",
                table: "Pytania_Krzyzowkis",
                column: "Id_Pytania",
                principalTable: "Krzyzowki",
                principalColumn: "Id_Krzyzowki",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pytania_Krzyzowkis_Krzyzowki_Id_Pytania",
                table: "Pytania_Krzyzowkis");

            migrationBuilder.CreateIndex(
                name: "IX_Pytania_Krzyzowkis_Id_Krzyzowki",
                table: "Pytania_Krzyzowkis",
                column: "Id_Krzyzowki");

            migrationBuilder.AddForeignKey(
                name: "FK_Pytania_Krzyzowkis_Krzyzowki_Id_Krzyzowki",
                table: "Pytania_Krzyzowkis",
                column: "Id_Krzyzowki",
                principalTable: "Krzyzowki",
                principalColumn: "Id_Krzyzowki",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
