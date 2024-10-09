using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderItem1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 578, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(4717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 578, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(3817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 578, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(9710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(8729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(6030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 578, DateTimeKind.Local).AddTicks(1856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 578, DateTimeKind.Local).AddTicks(943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 578, DateTimeKind.Local).AddTicks(60),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 182, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(6111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(5178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(4387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(1477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(2592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 11, 46, 8, 181, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 11, 40, 22, 577, DateTimeKind.Local).AddTicks(7513));
        }
    }
}
