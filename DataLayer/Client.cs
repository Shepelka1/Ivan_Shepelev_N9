using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Client()
        {
            Reservations = new List<Reservation>();
        }
    }
}
