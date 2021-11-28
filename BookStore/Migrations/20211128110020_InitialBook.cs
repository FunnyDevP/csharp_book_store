using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InitialBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "book_categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    author = table.Column<string>(type: "varchar(100)", nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books_book_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "book_categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "book_categories",
                columns: new[] { "Id", "created_at", "name" },
                values: new object[,]
                {
                    { new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"), new DateTime(2021, 11, 28, 18, 0, 19, 994, DateTimeKind.Local).AddTicks(3890), "Data" },
                    { new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"), new DateTime(2021, 11, 28, 18, 0, 20, 1, DateTimeKind.Local).AddTicks(6360), "Development" },
                    { new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"), new DateTime(2021, 11, 28, 18, 0, 20, 1, DateTimeKind.Local).AddTicks(6380), "General" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "author", "category_id", "created_at", "name", "price" },
                values: new object[,]
                {
                    { new Guid("405f49b6-e570-4081-8c51-861dd6bfac65"), "Ekaterina Kochmar", new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"), new DateTime(2021, 11, 28, 18, 0, 20, 3, DateTimeKind.Local).AddTicks(970), "Getting Started with Natural Language Processing", 19.99m },
                    { new Guid("d8fef357-4b1c-4bda-adde-9d14a0cefafa"), "Edward Raff", new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"), new DateTime(2021, 11, 28, 18, 0, 20, 3, DateTimeKind.Local).AddTicks(1450), "Inside Deep Learning", 19.99m },
                    { new Guid("8ff7a7b4-ed32-4e56-90a2-e6ca3148fc48"), "Michał Płachta", new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"), new DateTime(2021, 11, 28, 18, 0, 20, 3, DateTimeKind.Local).AddTicks(1460), "Grokking Functional Programming", 28.79m },
                    { new Guid("87c7ebb8-a15f-404e-9011-407e6966d894"), "Alexander Granin", new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"), new DateTime(2021, 11, 28, 18, 0, 20, 3, DateTimeKind.Local).AddTicks(1470), "Functional Design and Architecture", 28.79m },
                    { new Guid("f9b7ff9d-5699-4b4a-95cc-c50e701c0b5a"), "Thomas Kranz", new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"), new DateTime(2021, 11, 28, 18, 0, 20, 3, DateTimeKind.Local).AddTicks(1470), "Making Sense of Cyber Security", 28.79m },
                    { new Guid("e49ad4e4-98c9-4f0a-adc0-0b3dc585c243"), "Oleksandr Kaleniuk", new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"), new DateTime(2021, 11, 28, 18, 0, 20, 3, DateTimeKind.Local).AddTicks(1480), "Geometry for Programmers", 28.79m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_category_id",
                table: "books",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_books_name",
                table: "books",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "book_categories");
        }
    }
}
