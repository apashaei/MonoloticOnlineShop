using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddVisitcount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(6203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 885, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(5571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 885, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(3597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(4856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 885, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.AddColumn<int>(
                name: "Visisted",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(6370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 879, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(7315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_CatalogItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_CatalogItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Visisted",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 885, DateTimeKind.Local).AddTicks(3121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 885, DateTimeKind.Local).AddTicks(2199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(8744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 885, DateTimeKind.Local).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(4739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(3568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(2705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 879, DateTimeKind.Local).AddTicks(9409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 880, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 18, 35, 30, 884, DateTimeKind.Local).AddTicks(1570));
        }
    }
}
