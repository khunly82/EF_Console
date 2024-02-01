using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DAL.Entities
{
    [Table(name: "Hotels")] // nom de la table
    public class Hotel
    {
        [Key] // primary key
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime DateDeCreation { get; set; }
        public int NbEtoiles { get; set; }
        public bool Piscine { get; set; }
        public string? Fax { get; set; }
    }
}
