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

        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            if (usernameLabelText != "admin")
            {
                stockButton.Enabled = false;
            }
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            Stock stockWindow = new Stock();
            stockWindow.ShowDialog(this);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginWindow = new Login();
            loginWindow.ShowDialog();
            this.Close();
        }

        private void tableOne_Click(object sender, EventArgs e)
        {
            Table tableWindow = new Table();
            tableWindow.tableNumber = "1";
            tableWindow.ShowDialog();
        }

        private void tabelTwo_Click(object sender, EventArgs e)
        {
            Table tableWindow = new Table();
            tableWindow.tableNumber = "2";
            tableWindow.ShowDialog();
        }

        private void tableThree_Click(object sender, EventArgs e)
        {
            Table tableWindow = new Table();
            tableWindow.tableNumber = "3";
            tableWindow.ShowDialog();
        }
    }
}
