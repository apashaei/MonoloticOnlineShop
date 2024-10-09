using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddBaner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(5204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(4527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(2403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(3765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(8348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(7459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(4189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IActive = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "CatalogBrands",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "CatalogTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(6203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(5571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(3597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(4856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 576, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 43, DateTimeKind.Local).AddTicks(1264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(9207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(6370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 11, 9, 45, 46, 42, DateTimeKind.Local).AddTicks(7315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 11, 15, 12, 21, 575, DateTimeKind.Local).AddTicks(5337));

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
        }
    }
}
