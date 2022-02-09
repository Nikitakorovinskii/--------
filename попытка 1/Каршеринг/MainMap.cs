using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Nikita;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Каршеринг
{
    public partial class MainMap : Form
    {
        DateTime date;
        Timer timer = new Timer();
        Client client;
        Trip trip;


        List<Car> cars;
        public MainMap(Trip trip, Client client)
        {
            using (ApplicationContext db = new ApplicationContext())
            { cars = db.Cars.ToList(); }

            this.trip = trip;
            this.client = client;

            InitializeComponent();

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(58.5966, 49.6601);
            gMapControl1.ShowCenter = false;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MarkersEnabled = true;

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 70;
            gMapControl1.Zoom = 14;
            //1 машина
            GMapOverlay marker1 = new GMapOverlay("markers");
            GMapMarker marker11 = new GMarkerGoogle(new PointLatLng(58.595591, 49.658827), GMarkerGoogleType.green);
            marker1.Markers.Add(marker11);
            this.gMapControl1.Overlays.Add(marker1);
            marker11.ToolTipText = "\nSkoda \nТариф: (30 руб / мин) ";
            marker11.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
            marker11.ToolTip.Foreground = Brushes.White;
            marker11.ToolTip.TextPadding = new Size(20, 10);


            //2 машина
            GMapOverlay marker2 = new GMapOverlay("markers");
            GMapMarker marker22 = new GMarkerGoogle(new PointLatLng(58.591363, 49.659980), GMarkerGoogleType.green);
            marker2.Markers.Add(marker22);
            this.gMapControl1.Overlays.Add(marker2);
            marker22.ToolTipText = " \nKIA\nТариф: (25 руб / мин) ";
            marker22.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
            marker22.ToolTip.Foreground = Brushes.White;
            marker22.ToolTip.TextPadding = new Size(20, 10);

            //3 машина
            GMapOverlay marker3 = new GMapOverlay("markers");
            GMapMarker marker33 = new GMarkerGoogle(new PointLatLng(58.603595, 49.668023), GMarkerGoogleType.green);
            marker3.Markers.Add(marker33);
            this.gMapControl1.Overlays.Add(marker3);
            marker33.ToolTipText = " \nVolkswagen \nТариф: (20 руб / мин)";
            marker33.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
            marker33.ToolTip.Foreground = Brushes.White;
            marker33.ToolTip.TextPadding = new Size(20, 10);
            foreach (var car in cars)
            {
                comboBox1.Items.Add(car.ToString());
            }

        }

        private void label2_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Lk kab = new Lk(client);
            kab.Show();
        }

        private void MainMap_Load(object sender, EventArgs e)
        {
            Noarend.Visible = false;
            Timer.Visible = false;
            button1.Visible = false;
        }


        private void Arend_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // return $"Название авто: {СarName}  Кол-во мест: {NumberOfSeats} Цена: {Coast} ";

                string carName = comboBox1.Text.Substring(comboBox1.Text.IndexOf(": ") + 2, comboBox1.Text.IndexOf("К") - comboBox1.Text.IndexOf(": ") - 3).Trim();

                Trip trip1 = new Trip
                {
                    ClientId = client.Id,
                    CarId = db.Cars.Where(c => carName == c.СarName).Select(c => c.Id).FirstOrDefault(),                    
                    StartDate = DateTime.Now
                };
                db.Trips.Add(trip1);
                db.SaveChanges();
                trip = trip1;
                date = trip1.StartDate;

            }

            comboBox1.Visible = false;

            timer.Interval = 10;
            timer.Tick += new EventHandler(tickTimer);
            timer.Start();

            label2.Enabled = false;
            label1.Enabled = false;
            Timer.Visible = true;
            Arend.Visible = false;
            Noarend.Visible = true;
        }
        private void tickTimer(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            Timer.Text = String.Format("{0:HH:mm:ss}", stopWatch);


        }

        private void Noarend_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Trip trip1 = db.Trips.Where(x => x.StartDate == date).FirstOrDefault();
                if (trip1 != null)
                {
                    trip1.Car = db.Cars.Where(c => c.Id == trip1.CarId).FirstOrDefault();
                    trip1.EndDate = DateTime.Now;
                    db.Trips.Update(trip1);
                    db.SaveChanges();
                    label3.Text = trip1.Cost.ToString();
                    trip = trip1;
                }
            }


            timer.Stop();
            Noarend.Visible = false;
            button1.Visible = true;
            label2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Pay check = new Pay(trip, client);
            check.Show();

            label2.Enabled = true;
            label1.Enabled = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
