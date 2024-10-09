using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 341, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.AddColumn<int>(
                name: "AppliedDiscountId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountAmount",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(8721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(3501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(8893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(4118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppliedDiscountId",
                table: "Orders",
                column: "AppliedDiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Discount1s_AppliedDiscountId",
                table: "Orders",
                column: "AppliedDiscountId",
                principalTable: "Discount1s",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Discount1s_AppliedDiscountId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppliedDiscountId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AppliedDiscountId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 341, DateTimeKind.Local).AddTicks(139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(6226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(4535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(9841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(8975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(4969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(6397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 339, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 21, 45, 340, DateTimeKind.Local).AddTicks(2732));
        }
    }
}
