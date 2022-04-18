using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp43.Migrations
{
    public partial class CreatedBookGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookGenres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bookGenres_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookGenres_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookWriters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    WriterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookWriters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookWriters_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookWriters_Writer_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookGenres_BookId",
                table: "bookGenres",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_bookGenres_GenreId",
                table: "bookGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BookWriters_BookId",
                table: "BookWriters",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookWriters_WriterId",
                table: "BookWriters",
                column: "WriterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookGenres");

            migrationBuilder.DropTable(
                name: "BookWriters");
        }
    }
}
