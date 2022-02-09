using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nikita;

namespace Каршеринг
{
    public partial class Lk : Form
    {
        Client client;

        public Lk(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void Lk_Load(object sender, EventArgs e)
        {
            LastName.Text = client.LastName.ToString();
            Name.Text = client.Name.ToString();
            Prava.Text = client.DriversLicense.ToString();
            using (ApplicationContext db = new ApplicationContext())
            {
                List<Trip> trips = db.Trips.Where(tr => tr.ClientId == client.Id).ToList();
                if (trips != null)
                {
                    
                    foreach ( var trip in trips )
                    {
                        textBox1.Text += $"Дата начала: {trip.StartDate.ToLocalTime()} " +
                            $"Дата завершения: {trip.EndDate.ToLocalTime()} " +
                            $"Цена: {trip.Cost} руб. " +
                            $"Количество минут: {trip.Minutes}\r\n";
                    }
                }
                else
                {
                    textBox1.Text="Поездок ещё не было";
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            Hide();
            MainMap map = new MainMap(null, client);
            map.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
