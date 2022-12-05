using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Author_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authour_Name = table.Column<string>(nullable: true),
                    Author_biography = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Author_ID);
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
                name: "Accounts",
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
                    table.PrimaryKey("PK_Accounts", x => x.Account_number);
                    table.ForeignKey(
                        name: "FK_Accounts_Libraries_Library_ID",
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
                        name: "FK_Catalogs_Accounts_Account_number",
                        column: x => x.Account_number,
                        principalTable: "Accounts",
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
                name: "Patrons",
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
                    table.PrimaryKey("PK_Patrons", x => x.Patron_ID);
                    table.ForeignKey(
                        name: "FK_Patrons_Accounts_Account_number",
                        column: x => x.Account_number,
                        principalTable: "Accounts",
                        principalColumn: "Account_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
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
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Accounts_Account_number",
                        column: x => x.Account_number,
                        principalTable: "Accounts",
                        principalColumn: "Account_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Catalogs_CatalogID",
                        column: x => x.CatalogID,
                        principalTable: "Catalogs",
                        principalColumn: "CatalogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Librarians_Librarian_ID",
                        column: x => x.Librarian_ID,
                        principalTable: "Librarians",
                        principalColumn: "Librarian_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    ISBN = table.Column<int>(nullable: false),
                    Author_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.ISBN, x.Author_Id });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "Author_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Library_ID",
                table: "Accounts",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_Author_Id",
                table: "BookAuthors",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Account_number",
                table: "Books",
                column: "Account_number");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CatalogID",
                table: "Books",
                column: "CatalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Librarian_ID",
                table: "Books",
                column: "Librarian_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Library_ID",
                table: "Books",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_Account_number",
                table: "Catalogs",
                column: "Account_number");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_Library_ID",
                table: "Catalogs",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_Account_number",
                table: "Patrons",
                column: "Account_number",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Librarians");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
