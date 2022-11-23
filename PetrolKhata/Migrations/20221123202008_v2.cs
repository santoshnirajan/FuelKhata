using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetrolKhata.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_FuelTypes_FuelId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customers_CustomerId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_FuelTypes_FuelId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Customers_FuelId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Customers");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customers_CustomerId",
                table: "Sale",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_FuelTypes_FuelId",
                table: "Sale",
                column: "FuelId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_FuelTypes_FuelTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customers_CustomerId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_FuelTypes_FuelId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Customers_FuelTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "FuelId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FuelId",
                table: "Customers",
                column: "FuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_FuelTypes_FuelId",
                table: "Customers",
                column: "FuelId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customers_CustomerId",
                table: "Sale",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_FuelTypes_FuelId",
                table: "Sale",
                column: "FuelId",
                principalTable: "FuelTypes",
                principalColumn: "Id");
        }
    }
}
