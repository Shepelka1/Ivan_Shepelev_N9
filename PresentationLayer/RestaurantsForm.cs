using BusinessLayer;
using DataLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class RestaurantsForm : Form
    {
        MainDbContext mainContext = new MainDbContext();
        MainDbManager<Restaurant, int> dbManager = new MainDbManager<Restaurant, int>(new RestaurantsDbContext());
        Restaurant restaurantFromDb;
        Restaurant restaurant;
        public RestaurantsForm()
        {
            InitializeComponent();
        }

        private void creaeteBtn_Click(object sender, EventArgs e)
        {

            restaurant = new Restaurant(addressTBox.Text, int.Parse(incomeTBox.Text));
            dbManager.Create(restaurant);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (incomeTBox.Text != null && addressTBox.Text != null)
            {
                restaurant = new Restaurant(restaurantFromDb.RestaurantId, addressTBox.Text, int.Parse(incomeTBox.Text));
                dbManager.Update(restaurant);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dbManager.Delete(restaurantFromDb.RestaurantId);
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            restaurantFromDb = dbManager.ReadAll().Where(x => x.Address == addressTBox.Text && x.YearlyIncome == int.Parse(incomeTBox.Text)).First();
            restaurant = dbManager.Read(restaurantFromDb.RestaurantId);
            foundTBox.Text = "Restaurant found, please enter new data";
            addressTBox.Clear();
            incomeTBox.Clear();
        }
    }
}
