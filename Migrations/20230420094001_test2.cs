using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmAPI.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonGenres_FkPersonId",
                table: "PersonGenres");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Movies",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonGenres_FkPersonId_FkGenreId",
                table: "PersonGenres",
                columns: new[] { "FkPersonId", "FkGenreId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Link",
                table: "Movies",
                column: "Link",
                unique: true,
                filter: "[Link] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonGenres_FkPersonId_FkGenreId",
                table: "PersonGenres");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Link",
                table: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonGenres_FkPersonId",
                table: "PersonGenres",
                column: "FkPersonId");
        }
    }
}
