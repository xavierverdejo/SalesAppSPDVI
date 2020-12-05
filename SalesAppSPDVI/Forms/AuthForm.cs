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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            setLanguage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text.Equals("") && passTextBox.Text.Equals(""))
            { 
                AuthHelper.auth = true;
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageHelper.lan = LanguageHelper.langNames[comboBox1.SelectedIndex];
            setLanguage();
        }

        private void setLanguage()
        {
            label3.Text = LanguageHelper.dict[LanguageHelper.lan+".login.message"];
            label1.Text = LanguageHelper.dict[LanguageHelper.lan + ".login.user"];
            label2.Text = LanguageHelper.dict[LanguageHelper.lan + ".login.password"];
            button1.Text = LanguageHelper.dict[LanguageHelper.lan + ".login.login"];
        }

        private void sqlTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionHelper.selectedSQL = ConnectionHelper.stringNames[sqlTypeComboBox.SelectedIndex];
        }
    }
}
