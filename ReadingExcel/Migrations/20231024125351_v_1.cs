using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReadingExcel.Migrations
{
    /// <inheritdoc />
    public partial class v_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommodidyId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommodityGroupId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HangHoa",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhomHang",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceTotal",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommodityGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommodidyId",
                table: "Products",
                column: "CommodidyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommodityGroupId",
                table: "Products",
                column: "CommodityGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Commodities_CommodidyId",
                table: "Products",
                column: "CommodidyId",
                principalTable: "Commodities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CommodityGroups_CommodityGroupId",
                table: "Products",
                column: "CommodityGroupId",
                principalTable: "CommodityGroups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Commodities_CommodidyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CommodityGroups_CommodityGroupId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Commodities");

            migrationBuilder.DropTable(
                name: "CommodityGroups");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommodidyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommodityGroupId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CommodidyId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CommodityGroupId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HangHoa",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NhomHang",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceTotal",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
