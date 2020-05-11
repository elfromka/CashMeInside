using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CashMeInside
{
    public partial class Stock : Form
    {
        string drinkStockFilePath = @"C:\Users\elfromka\source\repos\CashMeInside\stock\drink.txt";
        string foodStockFilePath = @"C:\Users\elfromka\source\repos\CashMeInside\stock\food.txt";

        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            bindCategoryList();

            // list of string           //helper method ToList => convert the array of string to a list
            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            drinkListBox.DataSource = drinkProductsFromStock;
            foodListBox.DataSource = foodProductsFromStock;
        }

        private void bindCategoryList()
        {
            ArrayList CategoryList = new ArrayList();
            CategoryList.Add("drink");
            CategoryList.Add("food");
            productCategoryCB.DataSource = CategoryList;
            productCategoryCB.SelectedIndex = 0;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameInput.Text;
            int productQuantity = Convert.ToInt32(productQuantityInput.Text);
            double productPrice = Convert.ToDouble(productPriceInput.Text);
            string productCategory = productCategoryCB.Text;
            productCodeInput.MaxLength = 5;
            string productCode = productCodeInput.Text;

            string newProduct = String.Format("{0},{1},{2},{3}", productCode, productName, productQuantity, productPrice);

            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            bool successfullySaved = false;

            if (productCategory == "drink")
            {
                drinkProductsFromStock.Add(newProduct);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
                drinkListBox.DataSource = null;
                drinkListBox.DataSource = drinkProductsFromStock;
                successfullySaved = true;
            }
            else if (productCategory == "food")
            {
                foodProductsFromStock.Add(newProduct);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
                foodListBox.DataSource = null;
                foodListBox.DataSource = foodProductsFromStock;
                successfullySaved = true;
            }
            else
            {
                MessageBox.Show("Invalid stock category");
            }

            if (successfullySaved)
            {
                clearAllFields();
            }
        }

        private void clearAllFields()
        {
            productNameInput.Text = "";
            productQuantityInput.Text = "";
            productPriceInput.Text = "";
            productCodeInput.Text = "";
        }
    }
}
