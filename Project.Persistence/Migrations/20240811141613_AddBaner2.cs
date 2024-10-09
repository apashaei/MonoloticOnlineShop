using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddBaner2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 136, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(7365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(9133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(5439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(2365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(1232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(7731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(8785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Banners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveTime",
                table: "Banners",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Banners",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "RemoveTime",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 136, DateTimeKind.Local).AddTicks(11),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(9417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(8732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(6147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(4039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(3287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(1589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 13, 37, 135, DateTimeKind.Local).AddTicks(5264));
        }
    }
}
