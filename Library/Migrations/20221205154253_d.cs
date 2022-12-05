using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Author_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authour_Name = table.Column<string>(nullable: true),
                    Author_biography = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Author_ID);
                });

            migrationBuilder.CreateTable(
                name: "Librarians",
                columns: table => new
                {
                    Librarian_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarians", x => x.Librarian_ID);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Library_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Library_ID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Account_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History = table.Column<string>(nullable: true),
                    Date_opened = table.Column<string>(nullable: true),
                    Library_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Account_number);
                    table.ForeignKey(
                        name: "FK_Account_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    CatalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account_number = table.Column<int>(nullable: true),
                    Library_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.CatalogID);
                    table.ForeignKey(
                        name: "FK_Catalogs_Account_Account_number",
                        column: x => x.Account_number,
                        principalTable: "Account",
                        principalColumn: "Account_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalogs_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patron",
                columns: table => new
                {
                    Patron_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Account_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patron", x => x.Patron_ID);
                    table.ForeignKey(
                        name: "FK_Patron_Account_Account_number",
                        column: x => x.Account_number,
                        principalTable: "Account",
                        principalColumn: "Account_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ISBN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    Publication_data = table.Column<string>(nullable: true),
                    Number_of_pages = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    BarCode = table.Column<string>(nullable: true),
                    Tag = table.Column<int>(nullable: true),
                    IsReferenceOnly = table.Column<bool>(nullable: true),
                    CatalogID = table.Column<int>(nullable: true),
                    Library_ID = table.Column<int>(nullable: true),
                    Account_number = table.Column<int>(nullable: true),
                    Librarian_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Book_Account_Account_number",
                        column: x => x.Account_number,
                        principalTable: "Account",
                        principalColumn: "Account_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Catalogs_CatalogID",
                        column: x => x.CatalogID,
                        principalTable: "Catalogs",
                        principalColumn: "CatalogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Librarians_Librarian_ID",
                        column: x => x.Librarian_ID,
                        principalTable: "Librarians",
                        principalColumn: "Librarian_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    ISBN = table.Column<int>(nullable: false),
                    Author_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => new { x.ISBN, x.Author_Id });
                    table.ForeignKey(
                        name: "FK_BookAuthor_Author_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Author",
                        principalColumn: "Author_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Book_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Book",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Library_ID",
                table: "Account",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Account_number",
                table: "Book",
                column: "Account_number");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CatalogID",
                table: "Book",
                column: "CatalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Librarian_ID",
                table: "Book",
                column: "Librarian_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Library_ID",
                table: "Book",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_Author_Id",
                table: "BookAuthor",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_Account_number",
                table: "Catalogs",
                column: "Account_number");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_Library_ID",
                table: "Catalogs",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Patron_Account_number",
                table: "Patron",
                column: "Account_number",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "Patron");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Librarians");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
