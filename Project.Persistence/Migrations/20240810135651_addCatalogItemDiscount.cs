using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCatalogItemDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(3918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(5458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(2173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.AddColumn<int>(
                name: "Discountperecentage",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OldPrice",
                table: "CatalogItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(8195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(7538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(4899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.CreateTable(
                name: "DiscountUsageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderId = table.Column<int>(type: "int", nullable: false),
                    Discount1Id = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountUsageHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountUsageHistories_Discount1s_Discount1Id",
                        column: x => x.Discount1Id,
                        principalTable: "Discount1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountUsageHistories_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.CreateIndex(
                name: "IX_DiscountUsageHistories_Discount1Id",
                table: "DiscountUsageHistories",
                column: "Discount1Id");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountUsageHistories_orderId",
                table: "DiscountUsageHistories",
                column: "orderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountUsageHistories");

            migrationBuilder.DropColumn(
                name: "Discountperecentage",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 222, DateTimeKind.Local).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(8721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 221, DateTimeKind.Local).AddTicks(700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(7142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 951, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(3501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 220, DateTimeKind.Local).AddTicks(595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(8893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(6997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(1260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 26, 58, 219, DateTimeKind.Local).AddTicks(4118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 15, 56, 50, 950, DateTimeKind.Local).AddTicks(6049));

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
        }
    }
}
