using Microsoft.EntityFrameworkCore.Migrations;

namespace EFIntroductionMVC.Migrations
{
    public partial class AddGetSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "invitees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    isAttending = table.Column<bool>(nullable: false),
                    numberOfPartiesAttended = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invitees", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invitees");
        }
    }
}
