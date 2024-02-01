using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_DAL.Migrations
{
    public partial class SeedReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "DateArrivee", "DateDeReservation", "DateDepart", "HotelId", "Prix" },
                values: new object[] { new Guid("10b4b347-6b98-457e-b6f6-347a4d2274a3"), new DateTime(2024, 2, 2, 14, 50, 39, 87, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 2, 1, 14, 50, 39, 87, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 2, 9, 14, 50, 39, 87, DateTimeKind.Local).AddTicks(9029), 1, 150.42m });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "DateArrivee", "DateDeReservation", "DateDepart", "HotelId", "Prix" },
                values: new object[] { new Guid("eacabc34-084c-4196-9461-0ffa87130445"), new DateTime(2024, 1, 27, 14, 50, 39, 87, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 1, 25, 14, 50, 39, 87, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 1, 28, 14, 50, 39, 87, DateTimeKind.Local).AddTicks(9044), 1, 61m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("10b4b347-6b98-457e-b6f6-347a4d2274a3"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("eacabc34-084c-4196-9461-0ffa87130445"));
        }
    }
}
