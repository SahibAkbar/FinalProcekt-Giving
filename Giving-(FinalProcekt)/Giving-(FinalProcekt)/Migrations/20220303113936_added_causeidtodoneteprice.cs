using Microsoft.EntityFrameworkCore.Migrations;

namespace Giving__FinalProcekt_.Migrations
{
    public partial class added_causeidtodoneteprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CauseId",
                table: "DonatePrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DonatePrices_CauseId",
                table: "DonatePrices",
                column: "CauseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonatePrices_Causes_CauseId",
                table: "DonatePrices",
                column: "CauseId",
                principalTable: "Causes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonatePrices_Causes_CauseId",
                table: "DonatePrices");

            migrationBuilder.DropIndex(
                name: "IX_DonatePrices_CauseId",
                table: "DonatePrices");

            migrationBuilder.DropColumn(
                name: "CauseId",
                table: "DonatePrices");
        }
    }
}
