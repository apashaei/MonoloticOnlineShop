using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(6150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 466, DateTimeKind.Local).AddTicks(6496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(2685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(9627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "CatalogItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(7186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(6450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(2496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 463, DateTimeKind.Local).AddTicks(9221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 740, DateTimeKind.Local).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(7365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 466, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(9133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(5439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(4227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(2365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(1232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 739, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(9746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(7731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(8785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 16, 16, 13, 738, DateTimeKind.Local).AddTicks(6697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 463, DateTimeKind.Local).AddTicks(9221));

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
    }
}
