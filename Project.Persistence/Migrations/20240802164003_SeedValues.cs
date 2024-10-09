using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoved",
                table: "CatalogTypes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 18, 40, 3, 224, DateTimeKind.Local).AddTicks(4321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoved",
                table: "CatalogBrands",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 18, 40, 3, 224, DateTimeKind.Local).AddTicks(3376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "CatalogBrands",
                columns: new[] { "Id", "BrandName", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "سامسونگ", null, null },
                    { 2, "شیامی", null, null },
                    { 3, "اپل", null, null },
                    { 4, "هوآوی", null, null },
                    { 5, "نوکیا", null, null },
                    { 6, "ال جی", null, null }
                });

            migrationBuilder.InsertData(
                table: "CatalogTypes",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { 1, null, null, "کالای دیجیتال", null },
                    { 2, 1, null, "لوازم جانبی گوشی", null },
                    { 3, 2, null, "پایه نگهدارنده گوشی", null },
                    { 4, 2, null, "پاور بانک", null },
                    { 5, 2, null, "پاور بانک", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoved",
                table: "CatalogTypes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 18, 40, 3, 224, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.AlterColumn<bool>(
                name: "IsRemoved",
                table: "CatalogBrands",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 18, 40, 3, 224, DateTimeKind.Local).AddTicks(3376));
        }
    }
}
