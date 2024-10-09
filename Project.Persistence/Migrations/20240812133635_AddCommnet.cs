using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCommnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 742, DateTimeKind.Local).AddTicks(1597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(9525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 466, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(6949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(7909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(7290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(4347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(1528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(4712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(7081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(2339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 463, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.CreateTable(
                name: "CatalogItemComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(2270)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItemComments_CatalogItems_CatalogItemId",
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
                value: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemComments_CatalogItemId",
                table: "CatalogItemComments",
                column: "CatalogItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItemComments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 742, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(6150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 466, DateTimeKind.Local).AddTicks(6496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 467, DateTimeKind.Local).AddTicks(2685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(9627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 465, DateTimeKind.Local).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(7186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(6450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(4766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 464, DateTimeKind.Local).AddTicks(2496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 12, 30, 53, 463, DateTimeKind.Local).AddTicks(9221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(2339));

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
    }
}
