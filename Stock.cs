using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            bindProductCodesList();

            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            if (drinkProductsFromStock.Count == 0 && foodProductsFromStock.Count == 0)
            {
                removeProductButton.Enabled = false;
            }

            drinkListBox.DataSource = drinkProductsFromStock;
            foodListBox.DataSource = foodProductsFromStock;
        }

        private void bindProductCodesList()
        {
            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            List<string> existingDrinkProductCodes = new List<string>();
            List<string> existingFoodProductCodes = new List<string>();
            List<string> newList = new List<string>();

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

            if (existingDrinkProductCodes.Count == 0 && existingFoodProductCodes.Count > 0)
            {
                newList = existingFoodProductCodes.ToList();
            }
            else if (existingFoodProductCodes.Count == 0 && existingDrinkProductCodes.Count > 0)
            {
                newList = existingDrinkProductCodes.ToList();
            }
            else
            {
                newList = existingDrinkProductCodes.Concat(existingFoodProductCodes).ToList();
            }

            productCodesCB.DataSource = newList;
            productCodesCB.DropDownStyle = ComboBoxStyle.DropDownList;

            if (newList.Count > 0)
            {
                productCodesCB.SelectedIndex = 0;
                productCodesCB.Enabled = true;
            }
            else
            {
                productCodesCB.Enabled = false;
            }
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

        public bool validFields(string productName, double productPrice)
        {
            bool isValid = false;

            if (productName.Length > 0 && productPrice > 0)
            {
                isValid = true;
            }

            return isValid;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameInput.Text;
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
                bool validatedFields = validFields(productName, productPrice);
                if (validatedFields)
                {
                    newProduct = String.Format("{0},{1},{2}", productCode, productName, productPrice);

                    drinkProductsFromStock.Add(newProduct);
                    File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);
                    drinkListBox.DataSource = null;
                    drinkListBox.DataSource = drinkProductsFromStock;

                    successfullySaved = true;
                }
                else
                {
                    MessageBox.Show("Some fields aren't correctly completed. Please, re-check them!", "Something is wrong!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (productCategory == "food")
            {
                productCode = generateProductCode(productCategory);
                bool validatedFields = validFields(productName, productPrice);
                if (validatedFields)
                {
                    newProduct = String.Format("{0},{1},{2}", productCode, productName, productPrice);

                    foodProductsFromStock.Add(newProduct);
                    File.WriteAllLines(foodStockFilePath, foodProductsFromStock);
                    foodListBox.DataSource = null;
                    foodListBox.DataSource = foodProductsFromStock;

                    successfullySaved = true;
                }
                else
                {
                    MessageBox.Show("Some fields aren't correctly completed!", "Something is wrong!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (successfullySaved)
            {
                removeProductButton.Enabled = true;

                bindProductCodesList();
                clearAllFields();
            }
        }

        private void clearAllFields()
        {
            productNameInput.Text = "";
            productPriceInput.Text = "1";
        }

        private string generateProductCode(string productCategory)
        {
            int maxNumber;
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

            if (productCodes.Count > 0)
            {
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
                maxNumber = productCodeNumbers.Max();
            }
            else
            {
                maxNumber = 0;
            }

            return firstLetterProductCode + (maxNumber + 1);
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            bool contains = false;
            int productPositionInFile = 0;
            string stockFileName = "drink";
            string removeableProductCode = productCodesCB.Text;

            List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();
            List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

            foreach (var drinkProd in drinkProductsFromStock)
            {
                productPositionInFile++;
                contains = drinkProd.Split(',').Contains(removeableProductCode);
                if (contains)
                {
                    break;
                }
            }

            if (contains == false)
            {
                stockFileName = "food";
                productPositionInFile = 0;
                foreach (var foodProd in foodProductsFromStock)
                {
                    productPositionInFile++;
                    contains = foodProd.Split(',').Contains(removeableProductCode);
                    if (contains)
                    {
                        break;
                    }
                }
            }

            removeProduct(stockFileName, productPositionInFile);
            bindProductCodesList();
        }

        private void removeProduct(string stockFileName, int productPositionInFile)
        {
            productPositionInFile--;

            if (stockFileName == "drink")
            {
                List<string> drinkProductsFromStock = File.ReadAllLines(drinkStockFilePath).ToList();

                drinkProductsFromStock.RemoveAt(productPositionInFile);
                File.WriteAllLines(drinkStockFilePath, drinkProductsFromStock);

                drinkListBox.DataSource = null;
                drinkListBox.DataSource = drinkProductsFromStock;
            }
            else
            {
                List<string> foodProductsFromStock = File.ReadAllLines(foodStockFilePath).ToList();

                foodProductsFromStock.RemoveAt(productPositionInFile);
                File.WriteAllLines(foodStockFilePath, foodProductsFromStock);

                foodListBox.DataSource = null;
                foodListBox.DataSource = foodProductsFromStock;
            }
        }
    }
}
