using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RestaurantsDbContext : IDb<Restaurant, int>
    {
        MainDbContext dbContext = new MainDbContext();
        public void Create(Restaurant item)
        {
            dbContext.Restaurants.Add(item);
        }

        public void Delete(int key)
        {
            Restaurant restaurantFromDb = dbContext.Restaurants.Find(key);
            dbContext.Restaurants.Remove(restaurantFromDb);
        }

        public Restaurant Read(int key)
        {
            return dbContext.Restaurants.Find(key);
        }

        public List<Restaurant> ReadAll()
        {
            return dbContext.Restaurants.ToList();
        }

        public void Update(Restaurant item)
        {
            Restaurant restaurantFromDb = dbContext.Restaurants.Find(item.RestaurantId);
            restaurantFromDb.Address = item.Address;
            restaurantFromDb.Reservations = item.Reservations;
            restaurantFromDb.YearlyIncome = item.YearlyIncome;
        }
    }
}
