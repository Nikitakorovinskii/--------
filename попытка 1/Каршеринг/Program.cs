using System;
using Nikita;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Каршеринг
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());


            using (ApplicationContext db = new ApplicationContext())
            {

                Car car1 = new Car()
                {
                    СarName = "Volkswagen",
                    NumberOfSeats = 5,
                    VIN = "FEYWFWB3213Y43674",
                    Coast = 20


                };
                Car car2 = new Car()
                {
                    СarName = "KIA",
                    NumberOfSeats = 3,
                    VIN = "123456789ABVFEKK2",
                    Coast = 25

                };
                Car car3 = new Car()
                {
                    СarName = "Skoda",
                    NumberOfSeats = 4,
                    VIN = "987654321ABVFEKK2",
                    Coast = 30


                };
                db.Cars.Add(car1);
                db.Cars.Add(car2);
                db.Cars.Add(car3);
                db.SaveChanges();


            }
        }
    }
}
    


