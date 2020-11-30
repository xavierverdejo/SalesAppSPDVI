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
    }
}
