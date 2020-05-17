using System;
using System.IO;
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

            checkFoldersAndFiles();
        }

        private void checkFoldersAndFiles()
        {
            string stockFolderPath = String.Format(@"{0}stock", AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(stockFolderPath))
            {
                Directory.CreateDirectory(stockFolderPath);
            }

            string checkForDrinkFile = String.Format(@"{0}stock\drink.txt", AppDomain.CurrentDomain.BaseDirectory);
            if (!File.Exists(checkForDrinkFile))
            {
                var drinksFile = File.Create(checkForDrinkFile);
                drinksFile.Close();
            }

            string checkForFoodFile = String.Format(@"{0}stock\food.txt", AppDomain.CurrentDomain.BaseDirectory);
            if (!File.Exists(checkForFoodFile))
            {
                var foodsFile = File.Create(checkForFoodFile);
                foodsFile.Close();
            }

            string tablesFolderPath = String.Format(@"{0}tables", AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(tablesFolderPath))
            {
                Directory.CreateDirectory(tablesFolderPath);
            }

            string checkForTableOneFile = String.Format(@"{0}tables\table1.txt", AppDomain.CurrentDomain.BaseDirectory);
            if (!File.Exists(checkForTableOneFile))
            {
                var tableOneFile = File.Create(checkForTableOneFile);
                tableOneFile.Close();
            }

            string checkForTableTwoFile = String.Format(@"{0}tables\table2.txt", AppDomain.CurrentDomain.BaseDirectory);
            if (!File.Exists(checkForTableTwoFile))
            {
                var tableTwoFile = File.Create(checkForTableTwoFile);
                tableTwoFile.Close();
            }

            string checkForTableThreeFile = String.Format(@"{0}tables\table3.txt", AppDomain.CurrentDomain.BaseDirectory);
            if (!File.Exists(checkForTableThreeFile))
            {
                var tableThreeFile = File.Create(checkForTableThreeFile);
                tableThreeFile.Close();
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
