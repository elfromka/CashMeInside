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
        string selectedStockItemText;
        int selectedStockIndex;

        List<string> boughtProductsList;
        string selectedBoughtItemText;
        int selectedBoughtIndex;

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
            bindBoughtProducts();
        }

        private void bindProducts()
        {
            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

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

            stockProductsListBox.DataSource = onStockProductsList;
        }

        private void bindBoughtProducts()
        {
            string currentFilePath = String.Format(@"{0}tables\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            List<string> currentTableProducts = File.ReadAllLines(currentFilePath).ToList();

            boughtProductsList = currentTableProducts.ToList();
            boughtProductsListBox.DataSource = boughtProductsList;
        }

        private void addBPListButton_Click(object sender, EventArgs e)
        {
            string currentFilePath = String.Format(@"{0}tables\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            string productCategoryFirstLetter = "D";

            selectedStockItemText = stockProductsListBox.SelectedItem.ToString();
            selectedStockIndex = stockProductsListBox.SelectedIndex;
            boughtProductsList.Add(selectedBoughtItemText);

            if (onStockProductsList != null)
            {
                onStockProductsList.RemoveAt(selectedStockIndex);
            }

            List<string> currentTableProducts = File.ReadAllLines(currentFilePath).ToList();
            currentTableProducts.Add(selectedStockItemText);
            File.WriteAllLines(currentFilePath, currentTableProducts);

            if (currentTableProducts.Count == 0)
            {
                clientsPayButton.Enabled = false;
            }
            else
            {
                clientsPayButton.Enabled = true;
            }

            int commaLocation = selectedStockItemText.IndexOf(",", StringComparison.Ordinal);

            if (commaLocation > 0)
            {
                productCategoryFirstLetter = selectedStockItemText.Substring(0, 1);
            }

            if (productCategoryFirstLetter != "D")
            {
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();
                foodProductsFromStock.Remove(selectedStockItemText);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
            }
            else
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
                drinkProductsFromStock.Remove(selectedStockItemText);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
            }

            totalClientCost += getProductPrice(selectedStockItemText);
            totalPayNumberLabel.Text = Convert.ToString(totalClientCost);

            bindProducts();
            bindBoughtProducts();
        }

        private void removeBPListButton_Click(object sender, EventArgs e)
        {
            string currentFilePath = String.Format(@"{0}tables\table{1}.txt", AppDomain.CurrentDomain.BaseDirectory, tableNumber);
            string productCategoryFirstLetter = "D";

            selectedBoughtItemText = boughtProductsListBox.SelectedItem.ToString();
            selectedBoughtIndex = boughtProductsListBox.SelectedIndex;
            onStockProductsList.Add(selectedBoughtItemText);

            if (boughtProductsList != null)
            {
                boughtProductsList.RemoveAt(selectedBoughtIndex);
            }

            List<string> currentTableProducts = File.ReadAllLines(currentFilePath).ToList();
            currentTableProducts.Remove(selectedBoughtItemText);
            File.WriteAllLines(currentFilePath, currentTableProducts);

            if (currentTableProducts.Count == 0)
            {
                clientsPayButton.Enabled = false;
            }
            else
            {
                clientsPayButton.Enabled = true;
            }

            int commaLocation = selectedBoughtItemText.IndexOf(",", StringComparison.Ordinal);

            if (commaLocation > 0)
            {
                productCategoryFirstLetter = selectedBoughtItemText.Substring(0, 1);
            }

            if (productCategoryFirstLetter != "D")
            {
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();
                foodProductsFromStock.Add(selectedBoughtItemText);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
            }
            else
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
                drinkProductsFromStock.Add(selectedBoughtItemText);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
            }

            totalClientCost -= getProductPrice(selectedBoughtItemText);
            totalPayNumberLabel.Text = Convert.ToString(totalClientCost);

            bindProducts();
            bindBoughtProducts();
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
            totalClientCost = 0;
        }
    }
}
