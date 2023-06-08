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
    public partial class clientForm : Form
    {
        MainDbContext mainContext = new MainDbContext();
        MainDbManager<Client, int> dbManager = new MainDbManager<Client, int>(new ClientsDbContext());
        Client clientFromDb;
        Client client;
        public clientForm()
        {
            InitializeComponent();
        }

        private void clientForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void creaeteBtn_Click(object sender, EventArgs e)
        {
            
            client = new Client(nameTBox.Text, int.Parse(ageTBox.Text));
            dbManager.Create(client);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ageTBox.Text != null && nameTBox.Text != null)
            {
                client = new Client(clientFromDb.ClientId, nameTBox.Text, int.Parse(ageTBox.Text));
                dbManager.Update(client);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
                dbManager.Delete(clientFromDb.ClientId);
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            clientFromDb = dbManager.ReadAll().Where(x => x.Name == nameTBox.Text && x.Age == int.Parse(ageTBox.Text)).First();
            client = dbManager.Read(clientFromDb.ClientId);
            foundTBox.Text = "Client found, please enter new data";
            nameTBox.Clear();
            ageTBox.Clear();
        }
    }
}
