using BusinessLayer;
using DataLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MainDbManager<Reservation, int> contextReser = new MainDbManager<Reservation, int>(new ReservationsDbContext());
            MainDbManager<Restaurant, int> contextResta = new MainDbManager<Restaurant, int>(new RestaurantsDbContext());
            MainDbManager<Client, int> contextCli = new MainDbManager<Client, int>(new ClientsDbContext());
            Reservation reservation = new Reservation();
            Client client = new Client();
            contextCli.Create(client);
            //contextRes.Create(reservation);
            //Не съм написал контекст за резервация, но смисълът е същия
        }
    }
}
