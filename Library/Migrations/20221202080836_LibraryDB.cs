﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class LibraryDB : Migration
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
                name: "Catalogs",
                columns: table => new
                {
                    CatalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.CatalogID);
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
                    CatalogID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Catalogs_CatalogID",
                        column: x => x.CatalogID,
                        principalTable: "Catalogs",
                        principalColumn: "CatalogID",
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
                name: "IX_BookAuthors_Author_Id",
                table: "BookAuthors",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CatalogID",
                table: "Books",
                column: "CatalogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Catalogs");
        }
    }
}
