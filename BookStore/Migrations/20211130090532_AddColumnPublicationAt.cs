using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class AddColumnPublicationAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("405f49b6-e570-4081-8c51-861dd6bfac65"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("87c7ebb8-a15f-404e-9011-407e6966d894"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("8ff7a7b4-ed32-4e56-90a2-e6ca3148fc48"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("d8fef357-4b1c-4bda-adde-9d14a0cefafa"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("e49ad4e4-98c9-4f0a-adc0-0b3dc585c243"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("f9b7ff9d-5699-4b4a-95cc-c50e701c0b5a"));

            migrationBuilder.AddColumn<DateTime>(
                name: "publication_at",
                table: "books",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "book_categories",
                keyColumn: "Id",
                keyValue: new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"),
                column: "created_at",
                value: new DateTime(2021, 11, 30, 16, 5, 32, 204, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "book_categories",
                keyColumn: "Id",
                keyValue: new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"),
                column: "created_at",
                value: new DateTime(2021, 11, 30, 16, 5, 32, 186, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "book_categories",
                keyColumn: "Id",
                keyValue: new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"),
                column: "created_at",
                value: new DateTime(2021, 11, 30, 16, 5, 32, 204, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "author", "category_id", "created_at", "name", "price", "publication_at" },
                values: new object[,]
                {
                    { new Guid("97ce480c-5e2c-4ac3-a1c1-0310813e416c"), "Ekaterina Kochmar", new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"), new DateTime(2021, 11, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3100), "Getting Started with Natural Language Processing", 19.99m, new DateTime(2021, 12, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(2650) },
                    { new Guid("fa4e1250-bcfd-4b88-b6b3-0fb50b665771"), "Edward Raff", new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"), new DateTime(2021, 11, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3550), "Inside Deep Learning", 19.99m, new DateTime(2022, 1, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3530) },
                    { new Guid("c1896798-5c34-4343-a5af-8b0eff2371a3"), "Michał Płachta", new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"), new DateTime(2021, 11, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3610), "Grokking Functional Programming", 28.79m, new DateTime(2022, 2, 28, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3610) },
                    { new Guid("5c750f6a-abc0-409d-9109-526ba60a8ad5"), "Alexander Granin", new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"), new DateTime(2021, 11, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3620), "Functional Design and Architecture", 28.79m, new DateTime(2022, 3, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3610) },
                    { new Guid("c018717b-167e-4058-a874-6143c22199e6"), "Thomas Kranz", new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"), new DateTime(2021, 11, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3620), "Making Sense of Cyber Security", 28.79m, new DateTime(2022, 4, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3620) },
                    { new Guid("e2f3075b-1f76-412d-9e8a-5efa1dd1461b"), "Oleksandr Kaleniuk", new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"), new DateTime(2021, 11, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3630), "Geometry for Programmers", 28.79m, new DateTime(2022, 5, 30, 16, 5, 32, 206, DateTimeKind.Local).AddTicks(3630) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("5c750f6a-abc0-409d-9109-526ba60a8ad5"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("97ce480c-5e2c-4ac3-a1c1-0310813e416c"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("c018717b-167e-4058-a874-6143c22199e6"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("c1896798-5c34-4343-a5af-8b0eff2371a3"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("e2f3075b-1f76-412d-9e8a-5efa1dd1461b"));

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: new Guid("fa4e1250-bcfd-4b88-b6b3-0fb50b665771"));

            migrationBuilder.DropColumn(
                name: "publication_at",
                table: "books");

            migrationBuilder.UpdateData(
                table: "book_categories",
                keyColumn: "Id",
                keyValue: new Guid("b3ce1341-d10c-429f-954b-854f55aef90b"),
                column: "created_at",
                value: new DateTime(2021, 11, 28, 18, 0, 20, 1, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "book_categories",
                keyColumn: "Id",
                keyValue: new Guid("b3d9e7a8-3c31-4aed-9984-c65c14ef0795"),
                column: "created_at",
                value: new DateTime(2021, 11, 28, 18, 0, 19, 994, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "book_categories",
                keyColumn: "Id",
                keyValue: new Guid("d6b1de80-e44e-412e-957e-8a7e64d494f9"),
                column: "created_at",
                value: new DateTime(2021, 11, 28, 18, 0, 20, 1, DateTimeKind.Local).AddTicks(6380));

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
        }
    }
}
