using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(6581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(7468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(3871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(1777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(5842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(2926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(4740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 134, DateTimeKind.Local).AddTicks(1267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(9498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(8169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(6958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(5917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(2944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 8, 18, 3, 51, 133, DateTimeKind.Local).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 8, 19, 26, 36, 150, DateTimeKind.Local).AddTicks(1777));

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
    }
}
