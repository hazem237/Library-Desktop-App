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
                    libraryID = table.Column<int>(nullable: false),
                    patronID = table.Column<int>(nullable: false),
                    account_State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Account_number);
                    table.ForeignKey(
                        name: "FK_Accounts_Libraries_libraryID",
                        column: x => x.libraryID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    CatalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Catalog_Name = table.Column<string>(nullable: true),
                    libraryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.CatalogID);
                    table.ForeignKey(
                        name: "FK_Catalogs_Libraries_libraryID",
                        column: x => x.libraryID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    Patron_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Accountnumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.Patron_ID);
                    table.ForeignKey(
                        name: "FK_Patrons_Accounts_Accountnumber",
                        column: x => x.Accountnumber,
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
                    libraryID = table.Column<int>(nullable: true),
                    AccountID = table.Column<int>(nullable: true),
                    librarian_ID = table.Column<int>(nullable: true),
                    Librarian_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "Account_number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Catalogs_CatalogID",
                        column: x => x.CatalogID,
                        principalTable: "Catalogs",
                        principalColumn: "CatalogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Librarians_Librarian_ID",
                        column: x => x.Librarian_ID,
                        principalTable: "Librarians",
                        principalColumn: "Librarian_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Libraries_libraryID",
                        column: x => x.libraryID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Accounts_libraryID",
                table: "Accounts",
                column: "libraryID");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_Author_Id",
                table: "BookAuthors",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AccountID",
                table: "Books",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CatalogID",
                table: "Books",
                column: "CatalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Librarian_ID",
                table: "Books",
                column: "Librarian_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_libraryID",
                table: "Books",
                column: "libraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_libraryID",
                table: "Catalogs",
                column: "libraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_Accountnumber",
                table: "Patrons",
                column: "Accountnumber",
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
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Librarians");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
