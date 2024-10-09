using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateCatalogItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CatalogItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(3717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 221, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(3026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 221, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(2344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 221, DateTimeKind.Local).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 221, DateTimeKind.Local).AddTicks(3817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(9143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 8, 27, 59, 670, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 220, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 4, 13, 19, 31, 222, DateTimeKind.Local).AddTicks(1367));
        }
    }
}
