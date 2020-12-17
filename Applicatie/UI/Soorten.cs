using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie
{
    public partial class Soorten : Form
    {
        public static int soortID = 0;
        public Soorten()
        {
            InitializeComponent();
        }

        private void MenuHome_Click(object sender, EventArgs e)
        {
            var myForm = new Home();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuProducten_Click(object sender, EventArgs e)
        {
            var myForm = new Producten();
            myForm.Show();
            this.Visible = false;
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

        private void BtnPlastic_Click(object sender, EventArgs e)
        {
            soortID = 2;
            var myForm = new SoortenDetail();
            myForm.Show();
            this.Visible = false;
        }

        private void BtnIjzer_Click(object sender, EventArgs e)
        {
            soortID = 3;
            var myForm = new SoortenDetail();
            myForm.Show();
            this.Visible = false;
        }

        private void BtnHout_Click(object sender, EventArgs e)
        {
            soortID = 4;
            var myForm = new SoortenDetail();
            myForm.Show();
            this.Visible = false;
        }

        private void BtnBatterijen_Click(object sender, EventArgs e)
        {
            soortID = 5;
            var myForm = new SoortenDetail();
            myForm.Show();
            this.Visible = false;
        }
    }
}
