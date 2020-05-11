using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMeInside
{
    public partial class Tables : Form
    {
        public string usernameLabelText
        {
            get
            {
                return this.usernameLabel.Text;
            }

            set 
            {
                this.usernameLabel.Text = value;
            }
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            if (usernameLabelText != "admin")
            {
                stockButton.Enabled = false;
            }
        }

        public Tables()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginWindow = new Login();
            loginWindow.Show();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            Stock stockWindow = new Stock();
            stockWindow.ShowDialog(this);
        }
    }
}
