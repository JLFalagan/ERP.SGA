using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.SGA.WinApp.Migrations
{
    /// <inheritdoc />
    public partial class PVMig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDisplay",
                table: "ProductType",
                type: "longtext",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDisplay",
                table: "ProductType");
        }
    }
}
