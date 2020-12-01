
namespace SalesAppSPDVI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberRowsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productsListView = new System.Windows.Forms.ListView();
            this.subCategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.filteringGroupBox = new System.Windows.Forms.GroupBox();
            this.sellEndDateCheckBox = new System.Windows.Forms.CheckBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.maxComboBox = new System.Windows.Forms.ComboBox();
            this.minComboBox = new System.Windows.Forms.ComboBox();
            this.andLabel = new System.Windows.Forms.Label();
            this.priceBetweenLabel = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.productLineComboBox = new System.Windows.Forms.ComboBox();
            this.filteringGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(8, 23);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(149, 26);
            this.categoriesComboBox.TabIndex = 8;
            this.categoriesComboBox.Text = "Category";
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "0 products found";
            // 
            // numberRowsBox
            // 
            this.numberRowsBox.FormattingEnabled = true;
            this.numberRowsBox.Items.AddRange(new object[] {
            "20",
            "40",
            "60"});
            this.numberRowsBox.Location = new System.Drawing.Point(1169, 147);
            this.numberRowsBox.Name = "numberRowsBox";
            this.numberRowsBox.Size = new System.Drawing.Size(121, 26);
            this.numberRowsBox.TabIndex = 2;
            this.numberRowsBox.Text = "20";
            this.numberRowsBox.SelectedIndexChanged += new System.EventHandler(this.numberRowsBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "0 pages";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 715);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 721);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "cPage";
            // 
            // productsListView
            // 
            this.productsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(12, 178);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(1278, 519);
            this.productsListView.TabIndex = 7;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.DoubleClick += new System.EventHandler(this.productsListView_DoubleClick);
            // 
            // subCategoriesComboBox
            // 
            this.subCategoriesComboBox.FormattingEnabled = true;
            this.subCategoriesComboBox.Location = new System.Drawing.Point(185, 23);
            this.subCategoriesComboBox.Name = "subCategoriesComboBox";
            this.subCategoriesComboBox.Size = new System.Drawing.Size(149, 26);
            this.subCategoriesComboBox.TabIndex = 9;
            this.subCategoriesComboBox.Text = "Subcategory";
            this.subCategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.subCategoriesComboBox_SelectedIndexChanged);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(358, 23);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(63, 26);
            this.sizeComboBox.TabIndex = 10;
            this.sizeComboBox.Text = "Size";
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // filteringGroupBox
            // 
            this.filteringGroupBox.Controls.Add(this.sellEndDateCheckBox);
            this.filteringGroupBox.Controls.Add(this.searchTextBox);
            this.filteringGroupBox.Controls.Add(this.searchLabel);
            this.filteringGroupBox.Controls.Add(this.maxComboBox);
            this.filteringGroupBox.Controls.Add(this.minComboBox);
            this.filteringGroupBox.Controls.Add(this.andLabel);
            this.filteringGroupBox.Controls.Add(this.priceBetweenLabel);
            this.filteringGroupBox.Controls.Add(this.styleComboBox);
            this.filteringGroupBox.Controls.Add(this.clearButton);
            this.filteringGroupBox.Controls.Add(this.classComboBox);
            this.filteringGroupBox.Controls.Add(this.productLineComboBox);
            this.filteringGroupBox.Controls.Add(this.categoriesComboBox);
            this.filteringGroupBox.Controls.Add(this.sizeComboBox);
            this.filteringGroupBox.Controls.Add(this.subCategoriesComboBox);
            this.filteringGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filteringGroupBox.Name = "filteringGroupBox";
            this.filteringGroupBox.Size = new System.Drawing.Size(1278, 129);
            this.filteringGroupBox.TabIndex = 11;
            this.filteringGroupBox.TabStop = false;
            this.filteringGroupBox.Text = "Filtering";
            // 
            // sellEndDateCheckBox
            // 
            this.sellEndDateCheckBox.AutoSize = true;
            this.sellEndDateCheckBox.Location = new System.Drawing.Point(1066, 26);
            this.sellEndDateCheckBox.Name = "sellEndDateCheckBox";
            this.sellEndDateCheckBox.Size = new System.Drawing.Size(179, 22);
            this.sellEndDateCheckBox.TabIndex = 23;
            this.sellEndDateCheckBox.Text = "Only available products";
            this.sellEndDateCheckBox.UseVisualStyleBackColor = true;
            this.sellEndDateCheckBox.CheckedChanged += new System.EventHandler(this.sellEndDateCheckBox_CheckedChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 91);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(536, 24);
            this.searchTextBox.TabIndex = 22;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(9, 69);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(55, 18);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "Search";
            // 
            // maxComboBox
            // 
            this.maxComboBox.FormattingEnabled = true;
            this.maxComboBox.Location = new System.Drawing.Point(970, 25);
            this.maxComboBox.Name = "maxComboBox";
            this.maxComboBox.Size = new System.Drawing.Size(63, 26);
            this.maxComboBox.TabIndex = 20;
            this.maxComboBox.Text = "Max";
            this.maxComboBox.SelectedIndexChanged += new System.EventHandler(this.maxComboBox_SelectedIndexChanged);
            // 
            // minComboBox
            // 
            this.minComboBox.FormattingEnabled = true;
            this.minComboBox.Location = new System.Drawing.Point(867, 25);
            this.minComboBox.Name = "minComboBox";
            this.minComboBox.Size = new System.Drawing.Size(63, 26);
            this.minComboBox.TabIndex = 19;
            this.minComboBox.Text = "Min";
            this.minComboBox.SelectedIndexChanged += new System.EventHandler(this.minComboBox_SelectedIndexChanged);
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(934, 27);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(32, 18);
            this.andLabel.TabIndex = 18;
            this.andLabel.Text = "and";
            // 
            // priceBetweenLabel
            // 
            this.priceBetweenLabel.AutoSize = true;
            this.priceBetweenLabel.Location = new System.Drawing.Point(762, 27);
            this.priceBetweenLabel.Name = "priceBetweenLabel";
            this.priceBetweenLabel.Size = new System.Drawing.Size(101, 18);
            this.priceBetweenLabel.TabIndex = 15;
            this.priceBetweenLabel.Text = "Price between";
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(647, 23);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(72, 26);
            this.styleComboBox.TabIndex = 14;
            this.styleComboBox.Text = "Style";
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1157, 90);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 33);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear all";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(563, 23);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(72, 26);
            this.classComboBox.TabIndex = 12;
            this.classComboBox.Text = "Class";
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // productLineComboBox
            // 
            this.productLineComboBox.FormattingEnabled = true;
            this.productLineComboBox.Location = new System.Drawing.Point(437, 23);
            this.productLineComboBox.Name = "productLineComboBox";
            this.productLineComboBox.Size = new System.Drawing.Size(111, 26);
            this.productLineComboBox.TabIndex = 11;
            this.productLineComboBox.Text = "Product line";
            this.productLineComboBox.SelectedIndexChanged += new System.EventHandler(this.productLineComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 758);
            this.Controls.Add(this.filteringGroupBox);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberRowsBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SPDVI Management Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.filteringGroupBox.ResumeLayout(false);
            this.filteringGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox numberRowsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.ComboBox subCategoriesComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.GroupBox filteringGroupBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox productLineComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.Label andLabel;
        private System.Windows.Forms.Label priceBetweenLabel;
        private System.Windows.Forms.ComboBox maxComboBox;
        private System.Windows.Forms.ComboBox minComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox sellEndDateCheckBox;
    }
}

