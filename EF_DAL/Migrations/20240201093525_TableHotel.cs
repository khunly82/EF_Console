using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_DAL.Migrations
{
    public partial class TableHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NbEtoiles = table.Column<int>(type: "int", nullable: false),
                    Piscine = table.Column<bool>(type: "bit", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
