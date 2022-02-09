using Nikita;
using System;
using System.Windows.Forms;

namespace Каршеринг
{
    public partial class Pay : Form
    {
        Trip trip;
        Client client;
        public Pay(Trip trip, Client client)
        {
            InitializeComponent();
            this.trip = trip;
            this.client = client;
            Coast.Text = trip.Cost.ToString();
        }

        private void PayButton_Click_1(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Заполните пустые поля");
                return;

            }


            Hide();
            MainMap main = new MainMap(trip, client);
            main.Show();
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    PayCar check = new PayCar
                    {
                        Status = true,
                        Chek = DateTime.Now,
                        TripId = trip.Id                        
                    };
                    db.PayCars.Add(check);
                    db.SaveChanges();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "Ошибка!"); }
            }
        }
    }
}