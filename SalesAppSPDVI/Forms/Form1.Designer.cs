
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
            this.SuspendLayout();
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(16, 12);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(149, 26);
            this.categoriesComboBox.TabIndex = 8;
            this.categoriesComboBox.Text = "Category";
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 125);
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
            this.numberRowsBox.Location = new System.Drawing.Point(1032, 122);
            this.numberRowsBox.Name = "numberRowsBox";
            this.numberRowsBox.Size = new System.Drawing.Size(121, 26);
            this.numberRowsBox.TabIndex = 2;
            this.numberRowsBox.Text = "20";
            this.numberRowsBox.SelectedIndexChanged += new System.EventHandler(this.numberRowsBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "0 pages";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 615);
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
            this.label3.Location = new System.Drawing.Point(551, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "cPage";
            // 
            // productsListView
            // 
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(12, 157);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(1141, 452);
            this.productsListView.TabIndex = 7;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.SelectedIndexChanged += new System.EventHandler(this.productsListView_SelectedIndexChanged);
            this.productsListView.DoubleClick += new System.EventHandler(this.productsListView_DoubleClick);
            // 
            // subCategoriesComboBox
            // 
            this.subCategoriesComboBox.FormattingEnabled = true;
            this.subCategoriesComboBox.Location = new System.Drawing.Point(193, 12);
            this.subCategoriesComboBox.Name = "subCategoriesComboBox";
            this.subCategoriesComboBox.Size = new System.Drawing.Size(149, 26);
            this.subCategoriesComboBox.TabIndex = 9;
            this.subCategoriesComboBox.Text = "Subcategory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 658);
            this.Controls.Add(this.subCategoriesComboBox);
            this.Controls.Add(this.categoriesComboBox);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

