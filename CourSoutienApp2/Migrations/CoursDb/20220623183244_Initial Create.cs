using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourSoutienApp2.Migrations.CoursDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cours",
                columns: table => new
                {
                    CoursId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitule = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Prof = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Lieu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Heured = table.Column<DateTime>(nullable: false),
                    Heuref = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cours", x => x.CoursId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cours");
        }
    }
}
