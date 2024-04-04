using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkPersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Persons_FkPersonId",
                        column: x => x.FkPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonGenres",
                columns: table => new
                {
                    PersonGenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkPersonId = table.Column<int>(type: "int", nullable: false),
                    FkGenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonGenres", x => x.PersonGenreId);
                    table.ForeignKey(
                        name: "FK_PersonGenres_Genres_FkGenreId",
                        column: x => x.FkGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonGenres_Persons_FkPersonId",
                        column: x => x.FkPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkGenreId = table.Column<int>(type: "int", nullable: false),
                    FkMovieid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_FkGenreId",
                        column: x => x.FkGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_FkMovieid",
                        column: x => x.FkMovieid,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ratings = table.Column<int>(type: "int", nullable: false),
                    FkPersonId = table.Column<int>(type: "int", nullable: false),
                    FkMovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_FkMovieId",
                        column: x => x.FkMovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Persons_FkPersonId",
                        column: x => x.FkPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Title" },
                values: new object[,]
                {
                    { 12, "Adventuretime", "Adventure" },
                    { 14, "Fantastic", "Fantasy" },
                    { 16, "Graphic Beauty!", "Animation" },
                    { 18, "dramatic", "Drama" },
                    { 27, "Horrific", "Horror" },
                    { 28, "Explosions", "Action" },
                    { 35, "Will make you laugh", "Comedy" },
                    { 36, "Historical epicness", "History" },
                    { 37, "Cowboys", "Western" },
                    { 53, "Thrilling", "Thriller" },
                    { 80, "Watch out!", "Crime" },
                    { 99, "about the world", "Documentary" },
                    { 878, "Lasers", "Science Fiction" },
                    { 9648, "Mysterical", "Mystery" },
                    { 10402, "Musical magic", "Music" },
                    { 10749, "Lovely", "Romance" },
                    { 10751, "fun for everyone", "Family" },
                    { 10752, "War", "War" },
                    { 10770, "wow tv", "TV Movie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_FkGenreId",
                table: "MovieGenres",
                column: "FkGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_FkMovieid",
                table: "MovieGenres",
                column: "FkMovieid");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_FkPersonId",
                table: "Movies",
                column: "FkPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonGenres_FkGenreId",
                table: "PersonGenres",
                column: "FkGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonGenres_FkPersonId",
                table: "PersonGenres",
                column: "FkPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_FkMovieId",
                table: "Ratings",
                column: "FkMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_FkPersonId",
                table: "Ratings",
                column: "FkPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "PersonGenres");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
