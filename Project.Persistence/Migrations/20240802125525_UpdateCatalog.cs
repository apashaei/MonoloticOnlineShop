using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentCatalogTypeId",
                table: "CatalogTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CatalogTypes_ParentCatalogTypeId",
                table: "CatalogTypes",
                column: "ParentCatalogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogTypes_CatalogTypes_ParentCatalogTypeId",
                table: "CatalogTypes",
                column: "ParentCatalogTypeId",
                principalTable: "CatalogTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogTypes_CatalogTypes_ParentCatalogTypeId",
                table: "CatalogTypes");

            migrationBuilder.DropIndex(
                name: "IX_CatalogTypes_ParentCatalogTypeId",
                table: "CatalogTypes");

            migrationBuilder.DropColumn(
                name: "ParentCatalogTypeId",
                table: "CatalogTypes");
        }
    }
}
