using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(5842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 345, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveTime",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "OrderItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(9498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(8169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(6958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(2944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "RemoveTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "RemoveTime",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "OrderItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 345, DateTimeKind.Local).AddTicks(2605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(6087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(4335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(8717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 343, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 15, 40, 23, 344, DateTimeKind.Local).AddTicks(7965));
        }
    }
}
