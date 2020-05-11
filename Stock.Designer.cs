namespace CashMeInside
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productNameInput = new System.Windows.Forms.TextBox();
            this.productCategoryCB = new System.Windows.Forms.ComboBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.foodListBox = new System.Windows.Forms.ListBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productQuantityInput = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceInput = new System.Windows.Forms.TextBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.drinkListBox = new System.Windows.Forms.ListBox();
            this.foodListLabel = new System.Windows.Forms.Label();
            this.drinkListLabel = new System.Windows.Forms.Label();
            this.productCodeInput = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productNameInput
            // 
            this.productNameInput.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameInput.Location = new System.Drawing.Point(23, 47);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(140, 23);
            this.productNameInput.TabIndex = 1;
            // 
            // productCategoryCB
            // 
            this.productCategoryCB.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryCB.FormattingEnabled = true;
            this.productCategoryCB.Location = new System.Drawing.Point(530, 47);
            this.productCategoryCB.Name = "productCategoryCB";
            this.productCategoryCB.Size = new System.Drawing.Size(150, 23);
            this.productCategoryCB.TabIndex = 9;
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(695, 40);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(95, 34);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "+ Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // foodListBox
            // 
            this.foodListBox.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListBox.FormattingEnabled = true;
            this.foodListBox.ItemHeight = 19;
            this.foodListBox.Location = new System.Drawing.Point(23, 135);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(378, 251);
            this.foodListBox.TabIndex = 12;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(19, 25);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(115, 19);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product name";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityLabel.Location = new System.Drawing.Point(312, 25);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(71, 19);
            this.productQuantityLabel.TabIndex = 4;
            this.productQuantityLabel.Text = "Quantity";
            // 
            // productQuantityInput
            // 
            this.productQuantityInput.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityInput.Location = new System.Drawing.Point(316, 47);
            this.productQuantityInput.Name = "productQuantityInput";
            this.productQuantityInput.Size = new System.Drawing.Size(67, 23);
            this.productQuantityInput.TabIndex = 5;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(398, 25);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(46, 19);
            this.productPriceLabel.TabIndex = 6;
            this.productPriceLabel.Text = "Price";
            // 
            // productPriceInput
            // 
            this.productPriceInput.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceInput.Location = new System.Drawing.Point(402, 47);
            this.productPriceInput.Name = "productPriceInput";
            this.productPriceInput.Size = new System.Drawing.Size(109, 23);
            this.productPriceInput.TabIndex = 7;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryLabel.Location = new System.Drawing.Point(526, 25);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(140, 19);
            this.productCategoryLabel.TabIndex = 8;
            this.productCategoryLabel.Text = "Product category";
            // 
            // drinkListBox
            // 
            this.drinkListBox.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkListBox.FormattingEnabled = true;
            this.drinkListBox.ItemHeight = 19;
            this.drinkListBox.Location = new System.Drawing.Point(439, 135);
            this.drinkListBox.Name = "drinkListBox";
            this.drinkListBox.Size = new System.Drawing.Size(351, 251);
            this.drinkListBox.TabIndex = 14;
            // 
            // foodListLabel
            // 
            this.foodListLabel.AutoSize = true;
            this.foodListLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListLabel.Location = new System.Drawing.Point(20, 113);
            this.foodListLabel.Name = "foodListLabel";
            this.foodListLabel.Size = new System.Drawing.Size(71, 19);
            this.foodListLabel.TabIndex = 11;
            this.foodListLabel.Text = "Food list";
            // 
            // drinkListLabel
            // 
            this.drinkListLabel.AutoSize = true;
            this.drinkListLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkListLabel.Location = new System.Drawing.Point(435, 113);
            this.drinkListLabel.Name = "drinkListLabel";
            this.drinkListLabel.Size = new System.Drawing.Size(70, 19);
            this.drinkListLabel.TabIndex = 13;
            this.drinkListLabel.Text = "Drink list";
            // 
            // productCodeInput
            // 
            this.productCodeInput.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCodeInput.Location = new System.Drawing.Point(176, 47);
            this.productCodeInput.Name = "productCodeInput";
            this.productCodeInput.Size = new System.Drawing.Size(123, 23);
            this.productCodeInput.TabIndex = 3;
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCodeLabel.Location = new System.Drawing.Point(172, 25);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(111, 19);
            this.productCodeLabel.TabIndex = 2;
            this.productCodeLabel.Text = "Product code";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 429);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productCodeInput);
            this.Controls.Add(this.drinkListLabel);
            this.Controls.Add(this.foodListLabel);
            this.Controls.Add(this.drinkListBox);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceInput);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productQuantityInput);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.foodListBox);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productCategoryCB);
            this.Controls.Add(this.productNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Stock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashMeIn - Stock of products";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameInput;
        private System.Windows.Forms.ComboBox productCategoryCB;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.ListBox foodListBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.TextBox productQuantityInput;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceInput;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.ListBox drinkListBox;
        private System.Windows.Forms.Label foodListLabel;
        private System.Windows.Forms.Label drinkListLabel;
        private System.Windows.Forms.TextBox productCodeInput;
        private System.Windows.Forms.Label productCodeLabel;
    }
}