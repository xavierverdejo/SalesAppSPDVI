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
        private int typeAuth;
        public AuthForm(int type)
        {
            InitializeComponent();
            this.typeAuth = type;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(LanguageHelper.langNames);
            setLanguage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text.Equals("admin") && passTextBox.Text.Equals("admin"))
            {
                switch (this.typeAuth)
                {
                    case 0:
                        AuthHelper.auth = true;
                        break;
                    case 1:
                        AuthHelper.modifyAuth = true;
                        break;
                }
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageHelper.lan = comboBox1.SelectedIndex;
            setLanguage();
        }

        private void setLanguage()
        {
            label3.Text = LanguageHelper.langs[LanguageHelper.lan, 0];
            label1.Text = LanguageHelper.langs[LanguageHelper.lan, 1];
            label2.Text = LanguageHelper.langs[LanguageHelper.lan, 2];
            button1.Text = LanguageHelper.langs[LanguageHelper.lan, 3];
        }
    }
}
