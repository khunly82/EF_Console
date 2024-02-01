using EF_DAL;
using EF_DAL.Entities;

HolidayContext context = new HolidayContext();

// SELECT * FROM Hotels
List<Hotel> h = context.Hotels.ToList();

foreach (Hotel hotel in h)
{
    Console.WriteLine($"{hotel.Nom}");
}

List<int> Filtrer(List<int> nbs, Func<int, bool> cond)
{
    List<int> result = new List<int>();
    foreach (int nb in nbs)
    {
        if (cond(nb))
        {
            result.Add(nb);
        }
    }
    return result;
}

List<int> nbs = new List<int>() { 1, 2, 3, 4, 42, 99, 85 };

bool EstPair(int nb)
{
    return nb % 2 == 0;
}

List<int> nbs2 = nbs.Where(nb => nb % 3 == 0).ToList();
Console.WriteLine(string.Join(",", nbs2.Select(x => x.ToString())));


