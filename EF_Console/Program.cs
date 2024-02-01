using EF_DAL;
using EF_DAL.Entities;
using Microsoft.EntityFrameworkCore;

HolidayContext context = new();

List<Hotel> hotelList = context.Hotels
    .Include(h => h.Reservations).ToList();

foreach (Hotel hotel in hotelList)
{
    Console.WriteLine($"{hotel.Nom}");
    Console.WriteLine(hotel.Reservations.Count);
}