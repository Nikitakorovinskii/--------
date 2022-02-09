using Nikita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Каршеринг
{
    public partial class Dogovor : Form
    {
        public Dogovor(Contract contract)
        {
            InitializeComponent();
            this.contract = contract;
        }

        private readonly Contract contract;

        private void button1_Click(object sender, EventArgs e)
        {
            
            Hide();
            Login loginfrom = new Login();
            loginfrom.Show();
        }

        private void Dogovor_Load(object sender, EventArgs e)
        {
            labelNumberContract.Text = contract.Id.ToString();
        }
    }
}
