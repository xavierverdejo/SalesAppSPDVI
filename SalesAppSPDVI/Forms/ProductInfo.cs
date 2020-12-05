using Dapper;
using SalesAppSPDVI.Helpers;
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
        ProductModel lProduct;
        List<string> availableSizes = new List<string>();
        List<string> availablePrices = new List<string>();
        List<string> availableColors = new List<string>();
        public ProductInfo(ProductModel p)
        {
            InitializeComponent();
            this.lProduct = p;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal()))
            {
                p.Products.Clear();
                string query = "SELECT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description, Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size, Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.ProductCategory.Name AS[ProductCategory], Production.ProductSubcategory.Name AS[ProductSubCategory] " +
                                                   $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                                   $"WHERE ProductModelProductDescriptionCulture.CultureID = '{LanguageHelper.lan}' AND Production.ProductModel.Name = '{p.ProductModelName}'";
                p.Products = connection.Query<Product>(query).ToList();
            }
            setLists();
        }
        private void setLists()
        {
            foreach(Product product in this.lProduct.Products)
            {
                if (product.Size != null && !sizesListBox.Items.Contains(product.Size))
                    sizesListBox.Items.Add(product.Size);
                if (product.ListPrice != null  && !priceListBox.Items.Contains(product.ListPrice))
                    priceListBox.Items.Add(product.ListPrice);
                if (product.Color != null && !colorsListBox.Items.Contains(product.Color))
                    colorsListBox.Items.Add(product.Color);
            }
        }
        private void ProductInfo_Load(object sender, EventArgs e)
        {
            nameLabel.Text = lProduct.ProductModelName;
            nameTextBox.Text = lProduct.ProductModelName;
            descriptionTextBox.Text = lProduct.Description;
        }

        private void modifyButtom_Click(object sender, EventArgs e)
        {
            modifySet();
        }
        private void modifySet()
        {
            nameLabel.Enabled = true;
            //idTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            saveButton.Visible = true;
            modifyButtom.Visible = false;
        }
        private void save()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal()))
            {
                string query = $"SELECT ProductDescriptionID FROM Production.ProductModelProductDescriptionCulture WHERE ProductModelID = {lProduct.ProductModelID} AND CultureID = '{LanguageHelper.lan}'";
                int descId = connection.ExecuteScalar<int>(query);
                string updateDesc = $"UPDATE Production.ProductDescription SET Description = '{descriptionTextBox.Text}' WHERE ProductDescriptionID = {descId}";
                string updateName = $"UPDATE Production.ProductModel SET Name = '{nameTextBox.Text}' WHERE ProductModelID = {lProduct.ProductModelID}";
                connection.Execute(updateDesc);
                connection.Execute(updateDesc);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // TO-DO SAVE QUERY UPDATE
            save();
            this.Close();
        }
    }
}
