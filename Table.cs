using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CashMeInside
{
    public partial class Table : Form
    {
        string drinkStockFilePath = @"C:\Users\elfromka\source\repos\CashMeInside\stock\drink.txt";
        string foodStockFilePath = @"C:\Users\elfromka\source\repos\CashMeInside\stock\food.txt";

        List<string> onStockProductsList;
        string selectedItemText;
        int selectedIndex;

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

        string currentTableFilePath = String.Format(@"C:\\Users\\elfromka\\source\\repos\\CashMeInside\\tables\\table{0}.txt", "1");

        public Table()
        {
            InitializeComponent();
            bindProducts();
        }

        private void bindProducts()
        {
            //List<string> drinkProductsFromStock = getProductNameInfo("drink");
            //List<string> foodProductsFromStock = getProductNameInfo("food");
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

        private List<string> getProductNameInfo(string productCategoryName)
        {
            string productNameInfo;
            List<string> stockProducts = new List<string>();

            if (productCategoryName == "drink")
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
                foreach (var drinkProd in drinkProductsFromStock)
                {
                    int commaLocation = drinkProd.IndexOf(",", StringComparison.Ordinal);

                    if (commaLocation > 0)
                    {
                        productNameInfo = drinkProd.Substring(commaLocation, drinkProd.Length);
                        stockProducts.Add(productNameInfo);
                    }
                }
            }
            else
            {
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();
                foreach (var foodProd in foodProductsFromStock)
                {
                    int commaLocation = foodProd.IndexOf(",", StringComparison.Ordinal);

                    if (commaLocation > 0)
                    {
                        productNameInfo = foodProd.Substring(0, commaLocation);
                        stockProducts.Add(productNameInfo);
                    }
                }
            }

            return stockProducts;
        }

        private void addBPListButton_Click(object sender, EventArgs e)
        {
            selectedItemText = stockProductsListBox.SelectedItem.ToString();
            selectedIndex = stockProductsListBox.SelectedIndex;
            boughtProductsListBox.Items.Add(selectedItemText);

            if (onStockProductsList != null)
            {
                onStockProductsList.RemoveAt(selectedIndex);
            }

            dataBinding();
        }

        private void dataBinding()
        {
            stockProductsListBox.DataSource = null;
            stockProductsListBox.DataSource = onStockProductsList;
        }

        private void removeBPListButton_Click(object sender, EventArgs e)
        {
            selectedItemText = boughtProductsListBox.SelectedItem.ToString();
            selectedIndex = boughtProductsListBox.SelectedIndex;

            onStockProductsList.Add(selectedItemText);
            boughtProductsListBox.Items.RemoveAt(boughtProductsListBox.Items.IndexOf(boughtProductsListBox.SelectedItem));

            dataBinding();
        }

        private void clientsPayButton_Click(object sender, EventArgs e)
        {
            totalPayNumberLabel.Text = "0";
            // clear list from the table file too
            // clear listbox with products
        }
    }
}
