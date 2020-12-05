
namespace SalesAppSPDVI
{
    partial class ProductInfo
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.modifyButtom = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorsListBox = new System.Windows.Forms.ListBox();
            this.sizesListBox = new System.Windows.Forms.ListBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(18, 12);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(142, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name of product";
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(18, 55);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(52, 18);
            this.nameTextLabel.TabIndex = 2;
            this.nameTextLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(18, 90);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(87, 18);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(160, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(295, 24);
            this.nameTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(160, 90);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 100);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // modifyButtom
            // 
            this.modifyButtom.Location = new System.Drawing.Point(355, 444);
            this.modifyButtom.Name = "modifyButtom";
            this.modifyButtom.Size = new System.Drawing.Size(100, 37);
            this.modifyButtom.TabIndex = 7;
            this.modifyButtom.Text = "Modify";
            this.modifyButtom.UseVisualStyleBackColor = true;
            this.modifyButtom.Click += new System.EventHandler(this.modifyButtom_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(355, 403);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 35);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(18, 205);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(57, 18);
            this.colorLabel.TabIndex = 11;
            this.colorLabel.Text = "Colors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sizes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prices:";
            // 
            // colorsListBox
            // 
            this.colorsListBox.Enabled = false;
            this.colorsListBox.FormattingEnabled = true;
            this.colorsListBox.ItemHeight = 18;
            this.colorsListBox.Location = new System.Drawing.Point(160, 208);
            this.colorsListBox.Name = "colorsListBox";
            this.colorsListBox.Size = new System.Drawing.Size(120, 76);
            this.colorsListBox.TabIndex = 24;
            // 
            // sizesListBox
            // 
            this.sizesListBox.Enabled = false;
            this.sizesListBox.FormattingEnabled = true;
            this.sizesListBox.ItemHeight = 18;
            this.sizesListBox.Location = new System.Drawing.Point(160, 308);
            this.sizesListBox.Name = "sizesListBox";
            this.sizesListBox.Size = new System.Drawing.Size(120, 76);
            this.sizesListBox.TabIndex = 25;
            // 
            // priceListBox
            // 
            this.priceListBox.Enabled = false;
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 18;
            this.priceListBox.Location = new System.Drawing.Point(160, 405);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(120, 76);
            this.priceListBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "NOTE: One product can\r\nhave some prices because\r\ndifferent properties.\r\n";
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.sizesListBox);
            this.Controls.Add(this.colorsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modifyButtom);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductInfo";
            this.Text = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button modifyButtom;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox colorsListBox;
        private System.Windows.Forms.ListBox sizesListBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Label label3;
    }
}