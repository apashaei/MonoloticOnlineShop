using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(3914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(3043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(2294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 976, DateTimeKind.Local).AddTicks(9463)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(580)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_CatalogItemId",
                table: "BasketItems",
                column: "CatalogItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(5239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 12, 7, 30, 977, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 5, 10, 8, 33, 845, DateTimeKind.Local).AddTicks(9588));
        }
    }
}
