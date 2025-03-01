using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaseballECommerce.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("a1d4c053-49b6-410c-bc78-2d54a9991871"), "Baseball Caps" },
                    { new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"), "Memorabilia" },
                    { new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"), "Baseball Jerseys" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "ListPrice", "Name", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"), new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"), "This gnome was given out as part of a Mets game giveaway.", "https://example.com/images/lindor-garden-gnome-2023.jpg", 50.0, "Francisco Lindor Garden Gnome", 30 },
                    { new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"), new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"), "Stanimal wore this jersey when he played for NYCSummerBaseball Giants in 2022.", "https://example.com/images/stamimal-giants-jersey.jpg", 50.0, "Stanimal Giants Jersey", 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a1d4c053-49b6-410c-bc78-2d54a9991871"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"));
        }
    }
}
