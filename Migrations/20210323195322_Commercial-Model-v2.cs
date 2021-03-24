using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DashboardManagerMadera.Migrations
{
    public partial class CommercialModelv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Modifie_le_Commercial",
                table: "Commercial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Modifie_le_Commercial",
                table: "Commercial",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
