using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resterurnt_Delevery_online.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resteruntes_Items_Item_Id",
                table: "Resteruntes");

            migrationBuilder.DropIndex(
                name: "IX_Resteruntes_Item_Id",
                table: "Resteruntes");

            migrationBuilder.DropColumn(
                name: "Item_Id",
                table: "Resteruntes");

            migrationBuilder.AddColumn<int>(
                name: "Rest_id",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_Rest_id",
                table: "Items",
                column: "Rest_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Resteruntes_Rest_id",
                table: "Items",
                column: "Rest_id",
                principalTable: "Resteruntes",
                principalColumn: "id"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Resteruntes_Rest_id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_Rest_id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Rest_id",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Item_Id",
                table: "Resteruntes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Resteruntes_Item_Id",
                table: "Resteruntes",
                column: "Item_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resteruntes_Items_Item_Id",
                table: "Resteruntes",
                column: "Item_Id",
                principalTable: "Items",
                principalColumn: "id");
        }
    }
}
