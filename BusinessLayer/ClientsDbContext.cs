using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClientsDbContext : IDb<Client, int>
    {
        MainDbContext dbContext = new MainDbContext();
        public void Create(Client item)
        {
            dbContext.Clients.Add(item);
        }

        public void Delete(int key)
        {
            Client clientFromDb = dbContext.Clients.Find(key);
            dbContext.Clients.Remove(clientFromDb);
        }

        public Client Read(int key)
        {
            return dbContext.Clients.Find(key);
        }

        public List<Client> ReadAll()
        {
            return dbContext.Clients.ToList();
        }

        public void Update(Client item)
        {
            Client clientFromDb = dbContext.Clients.Find(item.ClientId);
            clientFromDb.Name = item.Name;
            clientFromDb.Age = item.Age;
            clientFromDb.Reservations = item.Reservations;
        }
    }
}
