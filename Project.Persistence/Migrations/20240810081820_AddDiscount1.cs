using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscount1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItemDiscounts");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(4467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(2762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(2017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(3240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.CreateTable(
                name: "Discount1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsePrecentage = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPerecentage = table.Column<int>(type: "int", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequiredCouponCode = table.Column<bool>(type: "bit", nullable: false),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountTypeId = table.Column<int>(type: "int", nullable: false),
                    LimitaionTime = table.Column<int>(type: "int", nullable: false),
                    DiscountLimitationId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(9702)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogItemDiscount1",
                columns: table => new
                {
                    CatalogItemsId = table.Column<int>(type: "int", nullable: false),
                    DiscountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemDiscount1", x => new { x.CatalogItemsId, x.DiscountsId });
                    table.ForeignKey(
                        name: "FK_CatalogItemDiscount1_CatalogItems_CatalogItemsId",
                        column: x => x.CatalogItemsId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogItemDiscount1_Discount1s_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discount1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemDiscount1_DiscountsId",
                table: "CatalogItemDiscount1",
                column: "DiscountsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItemDiscount1");

            migrationBuilder.DropTable(
                name: "Discount1s");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(6216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(5334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(3192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 189, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(8968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(5550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 10, 10, 18, 20, 188, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    DiscountLimitationId = table.Column<int>(type: "int", nullable: false),
                    DiscountPerecentage = table.Column<int>(type: "int", nullable: false),
                    DiscountTypeId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(2033)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LimitaionTime = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequiredCouponCode = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsePrecentage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogItemDiscounts",
                columns: table => new
                {
                    CatalogItemsId = table.Column<int>(type: "int", nullable: false),
                    DiscountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemDiscounts", x => new { x.CatalogItemsId, x.DiscountsId });
                    table.ForeignKey(
                        name: "FK_CatalogItemDiscounts_CatalogItems_CatalogItemsId",
                        column: x => x.CatalogItemsId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogItemDiscounts_Discounts_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 582, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 9, 14, 58, 20, 583, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemDiscounts_DiscountsId",
                table: "CatalogItemDiscounts",
                column: "DiscountsId");
        }
    }
}
