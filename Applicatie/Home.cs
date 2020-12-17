using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Applicatie
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();          
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Inloggen.gebruikerRol == "Admin")
            {

            }
        }

        private void MenuAccount_Click(object sender, EventArgs e)
        {
            var myForm = new MyAccount();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuUitloggen_Click(object sender, EventArgs e)
        {
            Inloggen.gebruikerID = 0;
            var myForm = new Inloggen();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuSoorten_Click(object sender, EventArgs e)
        {
            var myForm = new Soorten();
            myForm.Show();
            this.Visible = false;
        }

        private void BtnSoorten_Click(object sender, EventArgs e)
        {
            var myForm = new Soorten();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuProducten_Click(object sender, EventArgs e)
        {
            var myForm = new Producten();
            myForm.Show();
            this.Visible = false;
        }

        private void BtnOverOns_Click(object sender, EventArgs e)
        {
            var myForm = new Over_Ons();
            myForm.Show();
            this.Visible = false;
        }

        private void BtnProducten_Click(object sender, EventArgs e)
        {
            var myForm = new Producten();
            myForm.Show();
            this.Visible = false;
        }
    }
}
