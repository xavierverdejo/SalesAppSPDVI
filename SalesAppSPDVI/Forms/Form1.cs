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
        #region VARIABLES
        List<Product> products = new List<Product>();
        List<string> sizes = new List<string>();
        List<string> productLines = new List<string>();
        List<string> classes = new List<string>();
        List<string> styles = new List<string>();

        int[] maxArray, minArray;

        int filmsPerPage;
        int numberOfPages;
        int currentPage = 0;
        int totalProducts = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region FUNCTIONS
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
            setLanguage();
            updateCategories();
            updateSubCategories();
            setMinMax();

            foreach (int i in minArray)
                minComboBox.Items.Add(i.ToString());

            updateHeader();

            updateList();
        }
        private void updateHeader()
        {  
            productsListView.Scrollable = true;
            productsListView.View = View.Details;
            ColumnHeader header = new ColumnHeader();
            header.Text = "Name";
            header.Name = "col1";
            header.Width = productsListView.Width/6;
            //productsListView.HeaderStyle = ColumnHeaderStyle.None;
            productsListView.Columns.Add(header);
            ColumnHeader header2 = new ColumnHeader();
            header2.Text = "Description";
            header2.Name = "col2";
            header2.Width = 4*(productsListView.Width/6);
            //productsListView.HeaderStyle = ColumnHeaderStyle.None;
            productsListView.Columns.Add(header2);
            ColumnHeader header3 = new ColumnHeader();
            header3.Text = "Price";
            header3.Name = "col3";
            header3.Width = productsListView.Width / 4;
            //productsListView.HeaderStyle = ColumnHeaderStyle.None;
            productsListView.Columns.Add(header3);
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
            if (categoriesComboBox.SelectedItem != null)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
                {
                    subCategoriesComboBox.Items.Clear();
                    subCategoriesComboBox.Text = "Subcategory";
                    List<string> products = connection.Query<string>("dbo.getSubCategoriesByCategoryName @Name", new { Name = categoriesComboBox.Text }).ToList();
                    subCategoriesComboBox.Items.AddRange(products.ToArray());
                }
            }

        }
        private void clearSecondaryFilters()
        {
            sizeComboBox.Items.Clear();
            productLineComboBox.Items.Clear();
            classComboBox.Items.Clear();
            styleComboBox.Items.Clear();
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
            label1.Text = $"{totalProducts}"+ LanguageHelper.dict[LanguageHelper.lan + ".main.products_found"]; ;
            numberOfPages = (totalProducts / filmsPerPage);
            label2.Text = $"{numberOfPages+1}"+ LanguageHelper.dict[LanguageHelper.lan + ".main.pages"]; ;
            label3.Text = currentPage.ToString();
        }
        private void setMinMax()
        {
            minArray = new int[] { 0, 200, 500, 700, 1000, 1500, 2000, 2500, 3000, 3500 };
            maxArray = new int[] {200, 500, 700, 1000, 1500, 2000, 2500, 3000, 3500, 4000 };
        }
		void updateList()
		{
            filmsPerPage = int.Parse(numberRowsBox.Text);
            label1.Text = $"{totalProducts}"+LanguageHelper.dict[LanguageHelper.lan + ".main.products_found"];
            refreshNumberOfPages();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.cnnVal("Sample")))
			{
				products.Clear();
                string queryCount = "SELECT COUNT(*) " +
                                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL ";
                string query = "SELECT Production.ProductModel.Name AS ProductModel, Production.ProductDescription.Description, Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.ListPrice, Production.Product.Size, Production.Product.ProductLine, Production.Product.Class, Production.Product.Style, Production.ProductCategory.Name AS[ProductCategory], Production.ProductSubcategory.Name AS[ProductSubCategory] " +
                                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = '{LanguageHelper.lan}' AND Product.ProductModelID IS NOT NULL ";
                string querySizes = "SELECT Production.Product.Size " +
                                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = '{LanguageHelper.lan}' AND Product.ProductModelID IS NOT NULL ";
                string queryProductLines = "SELECT Production.Product.ProductLine " +
                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = '{LanguageHelper.lan}' AND Product.ProductModelID IS NOT NULL ";
                string queryClass = "SELECT Production.Product.Class " +
                                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                                     $"WHERE ProductModelProductDescriptionCulture.CultureID = '{LanguageHelper.lan}' AND Product.ProductModelID IS NOT NULL ";
                string queryStyle = "SELECT Production.Product.Style " +
                     $"FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID  INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                     $"WHERE ProductModelProductDescriptionCulture.CultureID = '{LanguageHelper.lan}' AND Product.ProductModelID IS NOT NULL ";

                if (categoriesComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                    queryCount+=$"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                    querySizes += $"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                    queryProductLines += $"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                    queryClass += $"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                    queryStyle += $"AND Production.ProductCategory.Name = '{categoriesComboBox.Text}' ";
                }

                if (subCategoriesComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.ProductSubcategory.Name = '{subCategoriesComboBox.Text}' ";
                    queryCount += $"AND Production.ProductSubcategory.Name = '{subCategoriesComboBox.Text}' ";
                    querySizes += $"AND Production.ProductSubcategory.Name = '{subCategoriesComboBox.Text}' ";
                    queryProductLines += $"AND Production.ProductSubcategory.Name = '{subCategoriesComboBox.Text}' ";
                    queryClass += $"AND Production.ProductSubcategory.Name = '{subCategoriesComboBox.Text}' ";
                    queryStyle += $"AND Production.ProductSubcategory.Name = '{subCategoriesComboBox.Text}' ";
                }
                if (sizeComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.Product.Size = '{sizeComboBox.Text}' ";
                    queryCount += $"AND Production.Product.Size = '{sizeComboBox.Text}' ";
                }
                else
                {
                    sizeComboBox.Items.Clear();
                }
                if(productLineComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.Product.ProductLine = '{productLineComboBox.Text}' ";
                    queryCount += $"AND Production.Product.ProductLine = '{productLineComboBox.Text}' ";
                }
                else
                {
                    productLineComboBox.Items.Clear();
                }
                if (classComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.Product.Class = '{classComboBox.Text}' ";
                    queryCount += $"AND Production.Product.Class = '{classComboBox.Text}' ";
                }
                else
                {
                    classComboBox.Items.Clear();
                }
                if (styleComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.Product.Style = '{styleComboBox.Text}' ";
                    queryCount += $"AND Production.Product.Style = '{styleComboBox.Text}' ";
                }
                else
                {
                    styleComboBox.Items.Clear();
                }
                if(minComboBox.SelectedIndex != -1 && maxComboBox.SelectedIndex != -1)
                {
                    query += $"AND Production.Product.ListPrice BETWEEN {int.Parse(minComboBox.Text)} AND {int.Parse(maxComboBox.Text)} ";
                    queryCount += $"AND Production.Product.ListPrice BETWEEN {int.Parse(minComboBox.Text)} AND {int.Parse(maxComboBox.Text)} ";
                }
                if (searchTextBox.TextLength > 1)
                {
                    query += $"AND (Production.Product.Name LIKE '%{searchTextBox.Text}%' OR Production.ProductModel.Name LIKE '%{searchTextBox.Text}%') ";
                    queryCount += $"AND (Production.Product.Name LIKE '%{searchTextBox.Text}%' OR Production.ProductModel.Name LIKE '%{searchTextBox.Text}%') ";
                }
                if(sellEndDateCheckBox.Checked)
                {
                    query += $"AND Production.Product.SellEndDate IS NULL ";
                    queryCount += $"AND Production.Product.SellEndDate IS NULL ";

                }

                query +=$"ORDER BY Production.ProductModel.Name OFFSET {currentPage * filmsPerPage} ROWS FETCH NEXT {filmsPerPage} ROWS ONLY";

                products = connection.Query<Product>(query).ToList();
                totalProducts = connection.ExecuteScalar<int>(queryCount);
                sizes = connection.Query<string>(querySizes).ToList();
                productLines = connection.Query<string>(queryProductLines).ToList();
                classes = connection.Query<string>(queryClass).ToList();
                styles = connection.Query<string>(queryStyle).ToList();


                productsListView.Items.Clear();

                foreach(string size in sizes)
                {
                    if (size != null && !sizeComboBox.Items.Contains(size))
                        sizeComboBox.Items.Add(size);
                }
                foreach (string productLine in productLines)
                {
                    if (productLine != null && !productLineComboBox.Items.Contains(productLine))
                        productLineComboBox.Items.Add(productLine);
                }
                foreach (string pClass in classes)
                {
                    if (pClass != null && !classComboBox.Items.Contains(pClass))
                        classComboBox.Items.Add(pClass);
                }
                foreach (string style in styles)
                {
                    if (style != null && !styleComboBox.Items.Contains(style))
                        styleComboBox.Items.Add(style);
                }
                foreach (Product prod in products)
				{
                    ListViewItem item = new ListViewItem(prod.Name);
                    item.SubItems.Add(prod.Description);
                    item.SubItems.Add(prod.ListPrice);
                    productsListView.Items.Add(item);
                }
                
			}
            refreshNumberOfPages();
            refreshButtons();
		}
        private void setLanguage()
        {
            currentPage = 0;
            filteringGroupBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.filtering"];
            priceBetweenLabel.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.price_between"];
            andLabel.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.and"];
            clearButton.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.clear_all"];
            this.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.title"];
            searchLabel.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.search"];
            button1.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.previous"];
            button2.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.next"];


            categoriesComboBox.SelectedIndex = -1;
            categoriesComboBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.category"];
            subCategoriesComboBox.SelectedIndex = -1;
            subCategoriesComboBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.subcategory"];
            sizeComboBox.SelectedIndex = -1;
            sizeComboBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.size"];
            productLineComboBox.SelectedIndex = -1;
            productLineComboBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.productline"];
            classComboBox.SelectedIndex = -1;
            classComboBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.class"];
            styleComboBox.SelectedIndex = -1;
            styleComboBox.Text = LanguageHelper.dict[LanguageHelper.lan + ".main.style"];
            minComboBox.SelectedIndex = -1;
            minComboBox.Text = "Min";
            maxComboBox.SelectedIndex = -1;
            maxComboBox.Text = "Max";
            maxComboBox.BackColor = Color.White;
            searchTextBox.Text = "";
            sellEndDateCheckBox.Checked = false;
        }
        #endregion

        #region HANDLERS
        private void numberRowsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsPerPage = int.Parse(numberRowsBox.Text);
            currentPage = 0;
            refreshNumberOfPages();
            refreshButtons();

            updateList();
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
        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            currentPage = 0;
            clearSecondaryFilters();
            subCategoriesComboBox.SelectedIndex = -1;
            updateList();
            updateSubCategories();
        }
        private void subCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            clearSecondaryFilters();
            updateList();
        }
        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            updateList();
        }
        private void productLineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            updateList();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            setLanguage();
            updateList();
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            updateList();
        }
        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            updateList();
        }
        private void maxComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxComboBox.BackColor = Color.White;
            updateList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            updateList();
        }
        private void sellEndDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            updateList();

            // SELECT DATES NOT IMPLEMENTED YET, SO NOT ADDED THE COLUMNS TO SHOW THAT  ------------->  TO-DO
        }
        private void minComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 0;
            maxComboBox.BackColor = Color.LightCoral;
            maxComboBox.Items.Clear();
            foreach (int i in maxArray)
            {
                if(minComboBox.SelectedItem != null && i>int.Parse(minComboBox.SelectedItem.ToString()))
                    maxComboBox.Items.Add(i.ToString());
            }
        }
        #endregion
    }
}
