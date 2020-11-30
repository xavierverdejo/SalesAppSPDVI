using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAppSPDVI
{
    public partial class ProductInfo : Form
    {
        Product lProduct;
        public ProductInfo(Product p)
        {
            InitializeComponent();
            this.lProduct = p;
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            nameLabel.Text = lProduct.Name;
            idTextBox.Text = lProduct.ProductNumber;
            nameTextBox.Text = lProduct.Name;
            colorTextBox.Text = lProduct.Color;
            sizeTextBox.Text = lProduct.Size;
        }

        private void modifyButtom_Click(object sender, EventArgs e)
        {
            AuthHelper.modifyAuth = false;
            AuthForm auth = new AuthForm(1);
            auth.ShowDialog();
            if (AuthHelper.modifyAuth)
                modifySet();
            else
                MessageBox.Show("You don't have the credentials to modify this items.");

        }
        private void modifySet()
        {
            nameLabel.Enabled = true;
            idTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            colorTextBox.Enabled = true;
            sizeTextBox.Enabled = true;
            saveButton.Visible = true;
            modifyButtom.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TO-DO SAVE QUERY UPDATE
            this.Visible = false;
            ProductInfo nForm = new ProductInfo(lProduct);
            this.Close();
            nForm.ShowDialog();
            
        }
    }
}
