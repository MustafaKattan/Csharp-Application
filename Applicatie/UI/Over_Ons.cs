﻿using System;
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
    public partial class Over_Ons : Form
    {
        public Over_Ons()
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

        private void MenuSoorten_Click(object sender, EventArgs e)
        {
            var myForm = new Soorten();
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

        private void Over_Ons_Load(object sender, EventArgs e)
        {

        }
    }
}
