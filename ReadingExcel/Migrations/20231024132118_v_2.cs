using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReadingExcel.Migrations
{
    /// <inheritdoc />
    public partial class v_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceTotal",
                table: "Products",
                newName: "CapitalPrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CapitalPrice",
                table: "Products",
                newName: "PriceTotal");
        }
    }
}
