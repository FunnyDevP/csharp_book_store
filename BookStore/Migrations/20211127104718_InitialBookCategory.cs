using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InitialBookCategory : Migration
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

            migrationBuilder.InsertData(
                table: "book_categories",
                columns: new[] { "Id", "created_at", "name" },
                values: new object[,]
                {
                    { new Guid("6cb0457d-eab1-46ac-a312-cbd720b0c3f4"), new DateTime(2021, 11, 27, 17, 47, 18, 103, DateTimeKind.Local).AddTicks(9960), "Data" },
                    { new Guid("ef4c4a26-d971-449d-8472-116923809099"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7020), "Development" },
                    { new Guid("b2ceac0a-b821-48ec-bc05-b6477e26f83d"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7040), "General" },
                    { new Guid("68bfd1fd-fc14-4c3e-aa15-d11592a08423"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7040), "Java/JVM" },
                    { new Guid("f6d724ad-a480-4205-b11a-7ca689633316"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7050), "Microsoft &.NET" },
                    { new Guid("ec378350-cd7c-4226-9fd3-2ccbec4b143e"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7050), "Operations & Cloud" },
                    { new Guid("bf13e0cc-5a93-403d-bf6b-b2471c69bf69"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7050), "Programming" },
                    { new Guid("0beb0a26-fd92-48d4-8cbf-9f18a839481a"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7060), "Python" },
                    { new Guid("85582997-4b6e-4689-93d4-329046df91df"), new DateTime(2021, 11, 27, 17, 47, 18, 111, DateTimeKind.Local).AddTicks(7060), "Web" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_categories_name",
                table: "book_categories",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_categories");
        }
    }
}
