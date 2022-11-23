using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrolKhata.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_FuelTypes_FuelTypeId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_FuelTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuelTypeId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FuelTypeId",
                table: "Customers",
                column: "FuelTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_FuelTypes_FuelTypeId",
                table: "Customers",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id");
        }
    }
}
