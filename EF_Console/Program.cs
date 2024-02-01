using EF_DAL;
using EF_DAL.Entities;

HolidayContext context = new HolidayContext();

// SELECT * FROM Hotels
List<Hotel> h = context.Hotels.ToList();

foreach (Hotel hotel in h)
{
    Console.WriteLine($"{hotel.Nom}");
}




