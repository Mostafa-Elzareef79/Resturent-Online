using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resterurnt_Delevery_online.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_Itemid",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Itemid",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Itemid",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Quntity",
                table: "ItemOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quntity",
                table: "ItemOrders");

            migrationBuilder.AddColumn<int>(
                name: "Itemid",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Itemid",
                table: "Orders",
                column: "Itemid");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_Itemid",
                table: "Orders",
                column: "Itemid",
                principalTable: "Items",
                principalColumn: "id");
        }
    }
}
