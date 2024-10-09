using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(9760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 742, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(6236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(2089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(4532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(7861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(1157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(2267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(8540)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(7484)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 742, DateTimeKind.Local).AddTicks(1597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(9525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 741, DateTimeKind.Local).AddTicks(6949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(7909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 154, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(4753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(7290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 740, DateTimeKind.Local).AddTicks(2270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(4347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 739, DateTimeKind.Local).AddTicks(1528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(9930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(4712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(7081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Banners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 36, 35, 738, DateTimeKind.Local).AddTicks(2339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 17, 37, 0, 153, DateTimeKind.Local).AddTicks(133));

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
        }
    }
}
