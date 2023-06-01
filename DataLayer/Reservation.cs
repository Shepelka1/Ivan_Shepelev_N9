using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public List<int> RoomNumbers { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Days { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        private Restaurant Restaurant { get; set; }
        public Reservation()
        {
            RoomNumbers = new List<int>();
        }
    }
}
