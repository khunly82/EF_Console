using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_DAL.Migrations
{
    public partial class SeedHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "DateDeCreation", "Fax", "NbEtoiles", "Nom", "Piscine" },
                values: new object[] { 1, "Charleroi", new DateTime(1935, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Ibis", false });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "DateDeCreation", "Fax", "NbEtoiles", "Nom", "Piscine" },
                values: new object[] { 2, "Bruxelles", new DateTime(1929, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "Hilton", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
