using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCatalogItemDiscount1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 653, DateTimeKind.Local).AddTicks(2293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 653, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(7665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(9587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(5433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(2212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.AlterColumn<int>(
                name: "Discountperecentage",
                table: "CatalogItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(9411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(6007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(7507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 653, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 653, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(3918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(5458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(2173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.AlterColumn<int>(
                name: "Discountperecentage",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(8195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 652, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(7538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(4899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 16, 12, 30, 651, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));
        }
    }
}
