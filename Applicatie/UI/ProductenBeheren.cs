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
    public partial class ProductenBeheren : Form
    {
        public ProductenBeheren()
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BtnOverzicht_Click(object sender, EventArgs e)
        {
            var myForm = new Producten();
            myForm.Show();
            this.Visible = false;
        }

        private void ProductenBeheren_Load(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();

            LvGrid.DataSource = productBLL.ReadProducten();




            // Soorten
            SoortBLL soortBLL = new SoortBLL();

            DataSet dsSoorten = soortBLL.ReadSoortNaam();

            if (dsSoorten.Tables.Count == 0)
            {
                // Fout melding
                MessageBox.Show("Fout opgetreden bij het ophalen van de soorten tabel");
            }
            // Bouw de items lijst op van de ComboBox
            CobSoort.DataSource = dsSoorten.Tables["tblSoort"];
            CobSoort.DisplayMember = "soortNaam";
            CobSoort.ValueMember = "soortNaam";

            // Containers
            ContainerBLL containerBLL = new ContainerBLL();

            DataSet dsContainer = containerBLL.ReadContainernaam();

            if (dsContainer.Tables.Count == 0)
            {
                // Fout melding
                MessageBox.Show("Fout opgetreden bij het ophalen van de container tabel");
            }
            // Bouw de items lijst op van de ComboBox
            ComContainer.DataSource = dsContainer.Tables["tblContainer"];
            ComContainer.DisplayMember = "containerNaam";
            ComContainer.ValueMember = "containerNaam";

        }


        int geselecteerdProductID;
        string geselecteerdeProductnaam;
        private void LvGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            geselecteerdProductID = Convert.ToInt32(LvGrid.Rows[rowIndex].Cells[0].Value.ToString());
            TbNaam.Text = LvGrid.Rows[rowIndex].Cells[1].Value.ToString();
            CobSoort.Text = LvGrid.Rows[rowIndex].Cells[2].Value.ToString();
            ComContainer.Text = LvGrid.Rows[rowIndex].Cells[3].Value.ToString();
            TbBarCode.Text = LvGrid.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            ProductBO productBO = new ProductBO();
            ProductBLL productBLL = new ProductBLL();

            SoortBO soortBO = new SoortBO();
            SoortBLL soortBLL = new SoortBLL();

            soortBO.SoortNaam = CobSoort.SelectedValue.ToString();

            int soortID = soortBLL.ReadSoortID(soortBO);


            productBO.ProductNaam = TbNaam.Text.Trim();
            productBO.SoortIdD203 = soortID;
            productBO.GebruikerIdD201 = Inloggen.gebruikerID;
            productBO.ProductBarcode = TbBarCode.Text.Trim();


            bool success = productBLL.ProductBarcode(productBO);



            if (success == false)
            {
                lb.Text = "Product bestaat al!";
            }
            else
            {
                // Ga toevoegen
                if (productBLL.Create(productBO) == 0)
                {
                    lb.Text = "product is niet toegevoegd";
                }
                else
                {
                    lb.Text = "product is toegevoegd";

                    LvGrid.DataSource = productBLL.ReadProducten();
                }
            }
        }

        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            ProductBO productBO = new ProductBO();
            ProductBLL productBLL = new ProductBLL();

            productBO.ProductBarcode = TbBarCode.Text.Trim();

            dataZoeken.DataSource = productBLL.ReadOneProduct(productBO);
            ZoekenPanel.Visible = true;

        }

        private void TbBarCode_Leave(object sender, EventArgs e)
        {
            if ((TbBarCode.Text.Length == 11) && (TbBarCode.Text.Length > 0))
            {
                MessageBox.Show("Barcode moet minimaal 10 getalen zijn!");
                TbBarCode.Focus();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ProductBO productBO = new ProductBO();
            ProductBLL productBLL = new ProductBLL();

            SoortBO soortBO = new SoortBO();
            SoortBLL soortBLL = new SoortBLL();

            soortBO.SoortNaam = CobSoort.SelectedValue.ToString();

            int soortID = soortBLL.ReadSoortID(soortBO);

            productBO.ProductIdH202 = geselecteerdProductID;
            productBO.ProductNaam = TbNaam.Text.Trim();
            productBO.SoortIdD203 = soortID;
            productBO.GebruikerIdD201 = Inloggen.gebruikerID;
            productBO.ProductBarcode = TbBarCode.Text.Trim();


            bool success = productBLL.ProductBarcode(productBO);

            if (Inloggen.gebruikerRol != "Admin")
            {
                lb.Text = "Je hebt geen toegang om een product aan te passen, neem contact met een admin op";
            }
            else
            {
                if (success == false)
                {
                    lb.Text = "Product bestaat al!";
                }
                else
                {
                    // Ga toevoegen
                    if (productBLL.Update(productBO) == false)
                    {
                        lb.Text = "product is niet aangepast";
                    }
                    else
                    {
                        lb.Text = "product is aangepast";

                        LvGrid.DataSource = productBLL.ReadProducten();
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ProductBO productBO = new ProductBO();
            ProductBLL productBLL = new ProductBLL();
            productBO.ProductIdH202 = geselecteerdProductID;

            if (Inloggen.gebruikerRol != "Admin")
            {
                lb.Text = "Je hebt geen toegang om een product te verwijderen, neem contact met een admin op";
            }
            else
            {
                // Ga updaten
                if (productBLL.Delete(productBO) == false)
                {
                    lb.Text = "Product is niet verwijderd";
                }
                else
                {
                    lb.Text = "Product is verwijderd";

                    LvGrid.DataSource = productBLL.ReadProducten();
                }

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            TbBarCode.Text = "";
            TbNaam.Text = "";
            // Soorten
            SoortBLL soortBLL = new SoortBLL();

            DataSet dsSoorten = soortBLL.ReadSoortNaam();

            if (dsSoorten.Tables.Count == 0)
            {
                // Fout melding
                MessageBox.Show("Fout opgetreden bij het ophalen van de soorten tabel");
            }
            // Bouw de items lijst op van de ComboBox
            CobSoort.DataSource = dsSoorten.Tables["tblSoort"];
            CobSoort.DisplayMember = "soortNaam";
            CobSoort.ValueMember = "soortNaam";

            // Containers
            ContainerBLL containerBLL = new ContainerBLL();

            DataSet dsContainer = containerBLL.ReadContainernaam();

            if (dsContainer.Tables.Count == 0)
            {
                // Fout melding
                MessageBox.Show("Fout opgetreden bij het ophalen van de container tabel");
            }
            // Bouw de items lijst op van de ComboBox
            ComContainer.DataSource = dsContainer.Tables["tblContainer"];
            ComContainer.DisplayMember = "containerNaam";
            ComContainer.ValueMember = "containerNaam";

        }

        private void dataZoeken_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            geselecteerdProductID = Convert.ToInt32(LvGrid.Rows[rowIndex].Cells[0].Value.ToString());
            TbNaam.Text = LvGrid.Rows[rowIndex].Cells[1].Value.ToString();
            CobSoort.Text = LvGrid.Rows[rowIndex].Cells[2].Value.ToString();
            ComContainer.Text = LvGrid.Rows[rowIndex].Cells[3].Value.ToString();
            TbBarCode.Text = LvGrid.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
