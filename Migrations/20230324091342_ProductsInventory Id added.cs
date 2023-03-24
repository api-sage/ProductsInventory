using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductInventoryMgt.Migrations
{
    /// <inheritdoc />
    public partial class ProductsInventoryIdadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductNumber",
                table: "ProductsInventory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductNumber",
                table: "ProductsInventory");
        }
    }
}
