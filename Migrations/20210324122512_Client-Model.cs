using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DashboardManagerMadera.Migrations
{
    public partial class ClientModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID_Client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Societe_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nom_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email_Client = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telephone_Client = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cree_le_Client = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID_Client);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
