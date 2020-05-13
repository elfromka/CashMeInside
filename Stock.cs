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

            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            List<string> existingDrinkProductCodes = new List<string>();
            List<string> existingFoodProductCodes = new List<string>();

            foreach (var drinkProd in drinkProductsFromStock)
            {
                int charLocation = drinkProd.IndexOf(",", StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    existingDrinkProductCodes.Add(drinkProd.Substring(0, charLocation));
                }
            }

            foreach (var foodProd in foodProductsFromStock)
            {
                int charLocation = foodProd.IndexOf(",", StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    existingFoodProductCodes.Add(foodProd.Substring(0, charLocation));
                }
            }

            var newList = existingDrinkProductCodes.Concat(existingFoodProductCodes).ToList();

            productCodesCB.DataSource = newList;
            productCodesCB.SelectedIndex = 0;
            productCodesCB.DropDownStyle = ComboBoxStyle.DropDownList;

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
            productCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameInput.Text;
            int productQuantity = Convert.ToInt32(productQuantityInput.Text);
            double productPrice = Convert.ToDouble(productPriceInput.Text);
            string productCategory = productCategoryCB.Text;
            string productCode;
            string newProduct;

            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            bool successfullySaved = false;

            if (productCategory == "drink")
            {
                productCode = generateProductCode(productCategory);
                newProduct = String.Format("{0},{1},{2},{3}", productCode, productName, productQuantity, productPrice);

                drinkProductsFromStock.Add(newProduct);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
                drinkListBox.DataSource = null;
                drinkListBox.DataSource = drinkProductsFromStock;
                successfullySaved = true;
            }
            else if (productCategory == "food")
            {
                productCode = generateProductCode(productCategory);
                newProduct = String.Format("{0},{1},{2},{3}", productCode, productName, productQuantity, productPrice);

                foodProductsFromStock.Add(newProduct);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
                foodListBox.DataSource = null;
                foodListBox.DataSource = foodProductsFromStock;
                successfullySaved = true;
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
        }

        private string generateProductCode(string productCategory)
        {
            string extractExistingProductCode;
            string firstLetterProductCode = (productCategory.Substring(0, 1)).ToUpper();
            List<string> productCodes = new List<string>();
            List<int> productCodeNumbers = new List<int>();

            if (productCategory == "drink")
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();

                foreach (var drinkProd in drinkProductsFromStock)
                {
                    int charLocation = drinkProd.IndexOf(",", StringComparison.Ordinal);

                    if (charLocation > 0)
                    {
                        extractExistingProductCode = drinkProd.Substring(0, charLocation);
                        productCodes.Add(extractExistingProductCode);
                    }
                }
            }
            else
            { 
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

                foreach (var foodProd in foodProductsFromStock)
                {
                    int charLocation = foodProd.IndexOf(",", StringComparison.Ordinal);

                    if (charLocation > 0)
                    {
                        extractExistingProductCode = foodProd.Substring(0, charLocation);
                        productCodes.Add(extractExistingProductCode);
                    }
                }
            }

            foreach (var productCode in productCodes)
            {
                foreach (var productCodeCharacter in productCode)
                {
                    if (Char.IsDigit(productCodeCharacter))
                    {
                        productCodeNumbers.Add(int.Parse(productCodeCharacter.ToString()));
                    }
                }
            }

            return firstLetterProductCode + (productCodeNumbers.Max()+1);
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            string removeableProductCode = productCodesCB.Text;

            bool found = false;
            bool contains = false;

            foreach (var drinkProd in drinkProductsFromStock)
            {
                contains = drinkProd.Split(',').Contains(removeableProductCode);
                if (contains)
                {
                    found = true;
                    break;
                }
            }

            if (contains == false) {
                foreach (var foodProd in foodProductsFromStock)
                {
                    contains = foodProd.Split(',').Contains(removeableProductCode);
                    if (contains)
                    {
                        found = true;
                        break;
                    }
                }
            }
        }
    }
}
