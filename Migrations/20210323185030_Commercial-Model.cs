using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DashboardManagerMadera.Migrations
{
    public partial class CommercialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commercial",
                columns: table => new
                {
                    ID_Commercial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Commercial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom_Commercial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email_Commercial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telephone_Commercial = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pays_Commercial = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cree_le_Commercial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modifie_le_Commercial = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commercial", x => x.ID_Commercial);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commercial");
        }
    }
}
