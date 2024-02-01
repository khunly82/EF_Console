using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DAL.Entities
{
    [Table(name: "Bookings")]
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DateArrivee { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateDeReservation { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal Prix { get; set; }

        public int HotelId { get; set; }

        // Propriété de navigation
        public Hotel Hotel { get; set; } = null!;

    }
}
