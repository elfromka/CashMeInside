using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CashMeInside
{
    public partial class Table : Form
    {
        string drinkStockFilePath = String.Format(@"{0}stock\drink.txt", AppDomain.CurrentDomain.BaseDirectory);
        string foodStockFilePath = String.Format(@"{0}stock\food.txt", AppDomain.CurrentDomain.BaseDirectory);

        List<string> onStockProductsList;
        string selectedItemText;
        int selectedIndex;
        double totalClientCost = 0;

        public string tableNumber
        {
            get
            {
                return this.tableNumberLabel.Text;
            }

            set
            {
                this.tableNumberLabel.Text = value;
            }
        }

        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            string currentTableFilePath = String.Format(@"{0}\\tables\\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            List<string> currentTableProducts = File.ReadAllLines(currentTableFilePath).ToList();

            if (currentTableProducts.Count == 0)
            {
                clientsPayButton.Enabled = false;
            }
            else
            {
                totalClientCost = getTotalCost(currentTableProducts);
                clientsPayButton.Enabled = true;
            }

            totalPayNumberLabel.Text = Convert.ToString(totalClientCost);

            bindProducts();
        }

        private void bindProducts()
        {
            string currentTableFilePath = String.Format(@"{0}\\tables\\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);

            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();
            List<string> currentTableProducts = File.ReadAllLines(currentTableFilePath).ToList();

            if (drinkProductsFromStock.Count == 0 && foodProductsFromStock.Count > 0)
            {
                onStockProductsList = foodProductsFromStock.ToList();
            }
            else if (foodProductsFromStock.Count == 0 && drinkProductsFromStock.Count > 0)
            {
                onStockProductsList = drinkProductsFromStock.ToList();
            }
            else
            {
                onStockProductsList = drinkProductsFromStock.Concat(foodProductsFromStock).ToList();
            }

            if (currentTableProducts.Count > 0)
            {
                boughtProductsListBox.DataSource = currentTableProducts;
            }

            stockProductsListBox.DataSource = onStockProductsList;
        }

        private void addBPListButton_Click(object sender, EventArgs e)
        {
            string productCategoryFirstLetter = "D";
            selectedItemText = stockProductsListBox.SelectedItem.ToString();
            selectedIndex = stockProductsListBox.SelectedIndex;
            boughtProductsListBox.Items.Add(selectedItemText);

            if (onStockProductsList != null)
            {
                onStockProductsList.RemoveAt(selectedIndex);
            }

            string currentTableFilePath = String.Format(@"{0}\\tables\\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            List<string> currentTableProducts = File.ReadAllLines(currentTableFilePath).ToList();
            currentTableProducts.Add(selectedItemText);
            File.WriteAllLines(currentTableFilePath, currentTableProducts);

            int commaLocation = selectedItemText.IndexOf(",", StringComparison.Ordinal);

            if (currentTableProducts.Count == 0)
            {
                clientsPayButton.Enabled = false;
            }
            else
            {
                clientsPayButton.Enabled = true;
            }

            if (commaLocation > 0)
            {
                productCategoryFirstLetter = selectedItemText.Substring(0, 1);
            }

            if (productCategoryFirstLetter != "D")
            {
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();
                foodProductsFromStock.Remove(selectedItemText);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
            }
            else
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
                drinkProductsFromStock.Remove(selectedItemText);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
            }

            totalClientCost += getProductPrice(selectedItemText);
            totalPayNumberLabel.Text = Convert.ToString(totalClientCost);

            dataBinding();
        }

        private void dataBinding()
        {
            stockProductsListBox.DataSource = null;
            stockProductsListBox.DataSource = onStockProductsList;
        }

        private void removeBPListButton_Click(object sender, EventArgs e)
        {
            string currentTableFilePath = String.Format(@"{0}\\tables\\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            string productCategoryFirstLetter = "D";
            selectedItemText = boughtProductsListBox.SelectedItem.ToString();
            selectedIndex = boughtProductsListBox.SelectedIndex;

            onStockProductsList.Add(selectedItemText);
            boughtProductsListBox.Items.RemoveAt(boughtProductsListBox.Items.IndexOf(boughtProductsListBox.SelectedItem));

            List<string> currentTableProducts = File.ReadAllLines(currentTableFilePath).ToList();
            currentTableProducts.Remove(selectedItemText);
            File.WriteAllLines(currentTableFilePath, currentTableProducts);

            if (currentTableProducts.Count == 0)
            {
                clientsPayButton.Enabled = false;
            }
            else
            {
                clientsPayButton.Enabled = true;
            }

            int commaLocation = selectedItemText.IndexOf(",", StringComparison.Ordinal);

            if (commaLocation > 0)
            {
                productCategoryFirstLetter = selectedItemText.Substring(0, 1);
            }

            if (productCategoryFirstLetter != "D")
            {
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();
                foodProductsFromStock.Add(selectedItemText);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
            }
            else
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
                drinkProductsFromStock.Add(selectedItemText);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
            }

            totalClientCost -= getProductPrice(selectedItemText);
            totalPayNumberLabel.Text = Convert.ToString(totalClientCost);

            dataBinding();
        }

        private void stockProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeBPListButton.Enabled = false;
            addBPListButton.Enabled = true;
        }

        private void boughtProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addBPListButton.Enabled = false;
            removeBPListButton.Enabled = true;
        }

        private double getProductPrice(string productInfo)
        {
            double productPrice = 0;
            int lastIndexComma = productInfo.LastIndexOf(',');

            productPrice = Double.Parse(productInfo.Substring(++lastIndexComma));

            return productPrice;
        }

        private double getTotalCost(List<string> boughtProducts)
        {
            double totalCost = 0;

            foreach (var boughtProduct in boughtProducts)
            {
                int lastIndexComma = boughtProduct.LastIndexOf(',');
                totalCost += Double.Parse(boughtProduct.Substring(++lastIndexComma));
            }

            return totalCost;
        }

        private void clientsPayButton_Click(object sender, EventArgs e)
        {
            string currentTableFilePath = String.Format(@"{0}\\tables\\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            List<string> currentTableProducts = File.ReadAllLines(currentTableFilePath).ToList();
            currentTableProducts.Clear();
            File.WriteAllLines(currentTableFilePath, currentTableProducts);

            boughtProductsListBox.DataSource = null;
            boughtProductsListBox.DataSource = currentTableProducts;

            totalPayNumberLabel.Text = "0";
        }
    }
}
