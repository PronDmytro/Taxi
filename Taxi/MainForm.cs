using System;
using System.Windows.Forms;

namespace Taxi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string ConnectionString = " Data Source =  db.sqlite3; Version = 3 ";

        private void buttonCalls_Click(object sender, EventArgs e)
        {
            CallsForm callsForm = new CallsForm();

            callsForm.ConnectionString = ConnectionString;
            callsForm.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsFrom = new ClientsForm();

            clientsFrom.ConnectionString = ConnectionString;
            clientsFrom.Show();
        }

        private void buttonTarifs_Click(object sender, EventArgs e)
        {
            TarifsForm tarifsForm = new TarifsForm();

            tarifsForm.ConnectionString = ConnectionString;
            tarifsForm.Show();
        }

        private void buttonCarPark_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();

            driversForm.ConnectionString = ConnectionString;
            driversForm.Show();
        }
    }
}
