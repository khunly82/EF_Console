using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DAL.Entities
{
    [Table(name: "Hotels")] // nom de la table
    public class Hotel
    {
        [Key] // primary key
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string Nom { get; set; } = null!;
        public string Address { get; set; } = null!;
        [Column(TypeName = "DATE")]
        public DateTime DateDeCreation { get; set; }
        public int NbEtoiles { get; set; }
        public bool Piscine { get; set; }
        public string? Fax { get; set; }

        // navigation properties
        public List<Reservation> Reservations { get; set; } = null!;
    }
}
