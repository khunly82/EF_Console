using EF_DAL;
using EF_DAL.Entities;

HolidayContext context = new();

//// SELECT * FROM Hotels WHERE Address LIKE 'Char%'
IEnumerable<Hotel> hotels = context.Hotels
    .Where(ht => ht.Address.StartsWith("Char"));

//List<Hotel> hotels2 = (
//    from h in hotels
//    where h.Address.StartsWith("Char")
//    select h
//).ToList();

foreach (Hotel hotel in hotels.ToList())
{
    Console.WriteLine($"{hotel.Nom}");
}

Hotel h = new Hotel();
h.Nom = "Novotel";
h.Piscine = false;
h.Address = "Charleroi";
h.DateDeCreation = DateTime.Now;
h.NbEtoiles = 3;
h.Fax = "+3271123456";

context.Hotels.Add(h);
context.SaveChanges();

foreach (Hotel hotel in hotels.ToList())
{
    Console.WriteLine($"{hotel.Nom}");
}



