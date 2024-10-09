using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 695, DateTimeKind.Local).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(9335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Tokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(8605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(5998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(7230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(4635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(7556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Customer", null },
                    { "2", null, "Admin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(9760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 695, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Tokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(7484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(6236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(2089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(4532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(7861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 694, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(1157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(2267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 18, 11, 693, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));
        }
    }
}
