using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountToBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 736, DateTimeKind.Local).AddTicks(1908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 736, DateTimeKind.Local).AddTicks(957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(8371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(9933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(6426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(3134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(1947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.AddColumn<int>(
                name: "AppliedDiscountId",
                table: "Baskets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountAmount",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(8416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_AppliedDiscountId",
                table: "Baskets",
                column: "AppliedDiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Discount1s_AppliedDiscountId",
                table: "Baskets",
                column: "AppliedDiscountId",
                principalTable: "Discount1s",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Discount1s_AppliedDiscountId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_AppliedDiscountId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "AppliedDiscountId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Baskets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(4467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 736, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 736, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(2762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(9702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 735, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(2017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(3240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 20, 11, 734, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));
        }
    }
}
