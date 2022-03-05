using Microsoft.EntityFrameworkCore.Migrations;

namespace Giving__FinalProcekt_.Migrations
{
    public partial class updateVolunteer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Volunteers",
                type: "ntext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Volunteers");
        }
    }
}
