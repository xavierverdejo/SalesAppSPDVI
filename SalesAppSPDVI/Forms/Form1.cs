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
    public partial class Form1 : Form
    {
        // VARIABLES

        List<Product> products = new List<Product>();
        int filmsPerPage;
        int numberOfPages;
        int currentPage = 0;
        int totalProducts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*while(!AuthHelper.auth)
            {
                AuthForm auth = new AuthForm(0);
                auth.ShowDialog();
            }*/
            onAuth();
        }
        private void onAuth()
        {
            productsListView.Scrollable = true;
            productsListView.View = View.Details;

            updateCategories();
            updateSubCategories();

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = productsListView.Width - 50;
            productsListView.HeaderStyle = ColumnHeaderStyle.None;
            productsListView.Columns.Add(header);

            filmsPerPage = int.Parse(numberRowsBox.Text);
            label1.Text = $"{totalProducts} products";

            updateList();
        }
        private void updateCategories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
            {
                List<string> products = connection.Query<string>("dbo.getCategories").ToList();
                categoriesComboBox.Items.AddRange(products.ToArray());
            }
        }
        private void updateSubCategories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
            {
                List<string> products = connection.Query<string>("dbo.getSubCategories").ToList();
                subCategoriesComboBox.Items.AddRange(products.ToArray());
            }
        }
        private void numberRowsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsPerPage = int.Parse(numberRowsBox.Text);
            currentPage = 0;
            refreshNumberOfPages();
            refreshButtons();

            updateList();
        }
        void refreshButtons()
        {
            if (currentPage != numberOfPages)
                button2.Enabled = true;
            else
                button2.Enabled = false;

            if (currentPage != 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
        void refreshNumberOfPages()
        {
            label1.Text = $"{totalProducts} products found";
            numberOfPages = (totalProducts / filmsPerPage);
            label2.Text = $"{numberOfPages+1} pages";
            label3.Text = currentPage.ToString();
        }
		void updateList()
		{
            refreshNumberOfPages();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
			{
				products.Clear();
                string queryCount = "SELECT COUNT(*) " +
                                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL ";

                string query = "SELECT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description, Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size, Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.ProductCategory.Name AS[ProductCategory], Production.ProductSubcategory.Name AS[ProductSubCategory] " +
                                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL ";
                if (categoriesComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                    queryCount+=$"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                }

                query+=$"ORDER BY Production.ProductModel.Name OFFSET {currentPage * filmsPerPage} ROWS FETCH NEXT {filmsPerPage} ROWS ONLY";

                products = connection.Query<Product>(query).ToList();
                totalProducts = connection.ExecuteScalar<int>(queryCount);

                // $" ORDER BY ProductID OFFSET {currentPage * filmsPerPage} ROWS FETCH NEXT {filmsPerPage} ROWS ONLY"

                productsListView.Items.Clear();
				foreach (Product prod in products)
				{
					productsListView.Items.Add(prod.ProductNumber, prod.Name, 0);
				}
			}
            refreshNumberOfPages();
            refreshButtons();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            currentPage++;
            refreshNumberOfPages();
            updateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPage--;
            refreshNumberOfPages();
            updateList();
        }

        private void productsListView_DoubleClick(object sender, EventArgs e)
        {
            //int id = int.Parse(productsListView.SelectedItems[0].Name);
            //MessageBox.Show($"Product id -> {id}");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
            {
                //List<Product> products = connection.Query<Product>("dbo.getProductById @ProductID", new { ProductID = id }).ToList();
                //MessageBox.Show(products[0].ToString());
                ProductInfo pInfoForm = new ProductInfo(products[productsListView.SelectedIndices[0]]);
                pInfoForm.ShowDialog();
            }
        }

        private void productsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            updateList();
        }
    }
}
