using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class id22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_saleManagements",
                table: "saleManagements");

            migrationBuilder.RenameTable(
                name: "saleManagements",
                newName: "SaleManagements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleManagements",
                table: "SaleManagements",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleManagements",
                table: "SaleManagements");

            migrationBuilder.RenameTable(
                name: "SaleManagements",
                newName: "saleManagements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_saleManagements",
                table: "saleManagements",
                column: "ID");
        }
    }
}
