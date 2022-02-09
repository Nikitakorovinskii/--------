using Nikita;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Каршеринг
{
    public partial class Reginstration : Form
    {
        public Reginstration()
        {
            InitializeComponent();
            NameUser.Text = "Введите имя";
            Last_name.Text = "Введите фамилию";
            LoginName.Text = "Введите логин";
            prava.Text = "XXXX XXXXXX";
            password.Text = "Введите пароль";
            prava.ForeColor = Color.Gray;
            LoginName.ForeColor = Color.Gray;
            Last_name.ForeColor = Color.Gray;
            NameUser.ForeColor = Color.Gray;
            password.ForeColor = Color.Gray;
        }

        private void Reginstration_Load(object sender, EventArgs e)
        {

        }

        private void prava_Enter(object sender, EventArgs e)
        {
            if (prava.Text == "XXXX XXXXXX")
            {
                prava.ForeColor = Color.Black;
                prava.Text = "";
            }


        }
        private void prava_Leave(object sender, EventArgs e)
        {
            if (prava.Text == "")
            {
                prava.Text = "XXXX XXXXXX";
                prava.ForeColor = Color.Gray;

            }
        }
        private void Name_Enter(object sender, EventArgs e)
        {
            if (NameUser.Text == "Введите имя")
            {
                NameUser.ForeColor = Color.Black;
                NameUser.Text = "";
            }

        }

        private void Last_name_Enter(object sender, EventArgs e)
        {
            if (Last_name.Text == "Введите фамилию")
            {
                Last_name.ForeColor = Color.Black;
                Last_name.Text = "";
            }

        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (NameUser.Text == "")
            {
                NameUser.Text = "Введите имя";
                NameUser.ForeColor = Color.Gray;

            }
        }
        private void LoginName_Leave(object sender, EventArgs e)
        {
            if (LoginName.Text == "")
            {
                LoginName.Text = "Введите логин";
                LoginName.ForeColor = Color.Gray;

            }
        }
        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;

            }
        }
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.ForeColor = Color.Black;
                password.Text = "";
            }
        }

        private void LoginName_Enter(object sender, EventArgs e)
        {
            if (LoginName.Text == "Введите логин")
            {
                LoginName.ForeColor = Color.Black;
                LoginName.Text = "";
            }
        }
        private void Last_name_Leave(object sender, EventArgs e)
        {
            if (Last_name.Text == "")
            {
                Last_name.Text = "Введите фамилию";
                Last_name.ForeColor = Color.Gray;

            }

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (prava.Text.Length != 10)
            {
                MessageBox.Show("Номер прав должен содержать 10 цифр!!!");
                return;

            }
            if (NameUser.Text == "Введите имя")
            {
                MessageBox.Show("Есть пустые поля");
                return;

            }
            if (prava.Text == "XXXX XXXXXX")
            {
                MessageBox.Show("Есть пустые поля");
                return;

            }
            if (LoginName.Text == "Введите логин")
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }
            if (Last_name.Text == "Введите фамилию")
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }

            Contract contract = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    Client client = new Client
                    {
                        Name = NameUser.Text,
                        LastName = Last_name.Text,
                        Login = LoginName.Text,
                        Password = password.Text,
                        DriversLicense = prava.Text

                    };

                    db.Clients.Add(client);
                    db.SaveChanges();

                    Client clientInfo = db.Clients.Where(cl => cl.DriversLicense == client.DriversLicense).FirstOrDefault();

                    contract = new Contract
                    {
                        ClientId = clientInfo.Id,
                        DateContract=DateTime.Now
                    };

                    db.Contracts.Add(contract);
                    db.SaveChangesAsync();


                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "Ошибка!"); }
            }
            this.Hide();
            Dogovor dogovor = new Dogovor(contract);

            dogovor.Show();

        }



        private void buttom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
