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
        int totalProducts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while(!AuthHelper.auth)
            {
                AuthForm auth = new AuthForm(0);
                auth.ShowDialog();
            }
            onAuth();
        }
        private void onAuth()
        {
            productsListView.Scrollable = true;
            productsListView.View = View.Details;

            updateCategories();

            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = productsListView.Width - 50;
            productsListView.HeaderStyle = ColumnHeaderStyle.None;
            productsListView.Columns.Add(header);

            filmsPerPage = int.Parse(numberRowsBox.Text);
            totalProducts = countAllProducts();
            label1.Text = $"{totalProducts} products";
            refreshButtons();
            refreshNumberOfPages();

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
        private void numberRowsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsPerPage = int.Parse(numberRowsBox.Text);
            currentPage = 0;
            refreshNumberOfPages();
            refreshButtons();

            updateList();
        }
        int countAllProducts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
            {
                int count = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM [AdventureWorks2016].[Production].[Product]");
                return count;
            }
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
            numberOfPages = (totalProducts / filmsPerPage);
            label2.Text = $"{numberOfPages} pages";
            label3.Text = currentPage.ToString();
        }
        void updateList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
            {
                products.Clear();
                products = connection.Query<Product>("SELECT ProductID, Name, ProductNumber, Color, ProductModelID, Size FROM [AdventureWorks2016].[Production].[Product]" +
                                                      $" ORDER BY ProductID OFFSET {currentPage * filmsPerPage} ROWS FETCH NEXT {filmsPerPage} ROWS ONLY").ToList();

                productsListView.Items.Clear();
                foreach (Product prod in products)
                {
                    productsListView.Items.Add(prod.ProductID.ToString(), prod.ToString(), 0);
                }
            }
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
            int id = int.Parse(productsListView.SelectedItems[0].Name);
            //MessageBox.Show($"Product id -> {id}");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
            {
                List<Product> products = connection.Query<Product>("dbo.getProductById @ProductID", new { ProductID = id }).ToList();
                //MessageBox.Show(products[0].ToString());
                ProductInfo pInfoForm = new ProductInfo(products[0]);
                pInfoForm.ShowDialog();
            }
        }

        private void productsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
