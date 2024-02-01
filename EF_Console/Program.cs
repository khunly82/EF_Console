using EF_DAL;
using EF_DAL.Entities;

HolidayContext context = new();

//// SELECT * FROM Hotels WHERE Address LIKE 'Char%'
//List<Hotel> hotels = context.Hotels
//    .Where(ht => ht.Address.StartsWith("Char"))
//    .ToList();

//List<Hotel> hotels2 = (
//    from h in hotels
//    where h.Address.StartsWith("Char")
//    select h
//).ToList();

//foreach (Hotel hotel in hotels)
//{
//    Console.WriteLine($"{hotel.Nom}");
//}

Hotel h = new Hotel();
h.Nom = "Novotel";
h.Piscine = false;
h.Address = "Charleroi";
h.DateDeCreation = DateTime.Now;
h.NbEtoiles = 3;
h.Fax = "+3271123456";

context.Hotels.Add(h);
context.SaveChanges();


