using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        [Required]
        public string Address { get; set; }
        public List<Reservation> Reservations { get; set; }
        public decimal YearlyIncome { get; set; }
        private Client Client { get; set; }
        public Restaurant()
        {
            Reservations = new List<Reservation>();
        }

        public Restaurant(int restaurantId, string address, decimal yearlyIncome) : this()
        {
            RestaurantId = restaurantId;
            Address = address;
            YearlyIncome = yearlyIncome;
        }
        public Restaurant(string address, decimal yearlyIncome) : this()
        {
            Address = address;
            YearlyIncome = yearlyIncome;
        }
    }
}
