using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Nikita;

namespace Каршеринг
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void buttonLogin_Click(object sender, EventArgs e) //Подключение к базе данных и сравнение занчений 
        {
            String loginUser = LoginName.Text;
            String passUser = password.Text;
            


            using (ApplicationContext db = new ApplicationContext())
            { 
                Client client = db.Clients.Where(cl => cl.Login == loginUser && cl.Password == passUser).FirstOrDefault();                
                if (client != null)
                {
                    Hide();
                    MainMap mainForm = new MainMap(null, client);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reginstration reginstration = new Reginstration();
            reginstration.Show();
        }

        private void buttom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
