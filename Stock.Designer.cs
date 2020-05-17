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
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceInput = new System.Windows.Forms.TextBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.drinkListBox = new System.Windows.Forms.ListBox();
            this.foodListLabel = new System.Windows.Forms.Label();
            this.drinkListLabel = new System.Windows.Forms.Label();
            this.addNewProductTitleLabel = new System.Windows.Forms.Label();
            this.removeExistingProductTitleLabel = new System.Windows.Forms.Label();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.removeProductLabel = new System.Windows.Forms.Label();
            this.productCodesCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // productNameInput
            // 
            this.productNameInput.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameInput.Location = new System.Drawing.Point(24, 380);
            this.productNameInput.Name = "productNameInput";
            this.productNameInput.Size = new System.Drawing.Size(225, 23);
            this.productNameInput.TabIndex = 7;
            // 
            // productCategoryCB
            // 
            this.productCategoryCB.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryCB.FormattingEnabled = true;
            this.productCategoryCB.Location = new System.Drawing.Point(400, 380);
            this.productCategoryCB.Name = "productCategoryCB";
            this.productCategoryCB.Size = new System.Drawing.Size(150, 23);
            this.productCategoryCB.TabIndex = 15;
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(565, 373);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(95, 34);
            this.addProductButton.TabIndex = 16;
            this.addProductButton.Text = "+ Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // foodListBox
            // 
            this.foodListBox.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListBox.FormattingEnabled = true;
            this.foodListBox.ItemHeight = 19;
            this.foodListBox.Location = new System.Drawing.Point(23, 47);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(366, 251);
            this.foodListBox.TabIndex = 2;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(20, 358);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(115, 19);
            this.productNameLabel.TabIndex = 6;
            this.productNameLabel.Text = "Product name";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(264, 358);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(46, 19);
            this.productPriceLabel.TabIndex = 12;
            this.productPriceLabel.Text = "Price";
            // 
            // productPriceInput
            // 
            this.productPriceInput.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceInput.Location = new System.Drawing.Point(268, 380);
            this.productPriceInput.Name = "productPriceInput";
            this.productPriceInput.Size = new System.Drawing.Size(116, 23);
            this.productPriceInput.TabIndex = 13;
            this.productPriceInput.Text = "1";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryLabel.Location = new System.Drawing.Point(396, 358);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(140, 19);
            this.productCategoryLabel.TabIndex = 14;
            this.productCategoryLabel.Text = "Product category";
            // 
            // drinkListBox
            // 
            this.drinkListBox.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkListBox.FormattingEnabled = true;
            this.drinkListBox.ItemHeight = 19;
            this.drinkListBox.Location = new System.Drawing.Point(422, 47);
            this.drinkListBox.Name = "drinkListBox";
            this.drinkListBox.Size = new System.Drawing.Size(368, 251);
            this.drinkListBox.TabIndex = 4;
            // 
            // foodListLabel
            // 
            this.foodListLabel.AutoSize = true;
            this.foodListLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListLabel.Location = new System.Drawing.Point(20, 25);
            this.foodListLabel.Name = "foodListLabel";
            this.foodListLabel.Size = new System.Drawing.Size(71, 19);
            this.foodListLabel.TabIndex = 1;
            this.foodListLabel.Text = "Food list";
            // 
            // drinkListLabel
            // 
            this.drinkListLabel.AutoSize = true;
            this.drinkListLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkListLabel.Location = new System.Drawing.Point(418, 25);
            this.drinkListLabel.Name = "drinkListLabel";
            this.drinkListLabel.Size = new System.Drawing.Size(70, 19);
            this.drinkListLabel.TabIndex = 3;
            this.drinkListLabel.Text = "Drink list";
            // 
            // addNewProductTitleLabel
            // 
            this.addNewProductTitleLabel.AutoSize = true;
            this.addNewProductTitleLabel.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewProductTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addNewProductTitleLabel.Location = new System.Drawing.Point(20, 329);
            this.addNewProductTitleLabel.Name = "addNewProductTitleLabel";
            this.addNewProductTitleLabel.Size = new System.Drawing.Size(142, 19);
            this.addNewProductTitleLabel.TabIndex = 5;
            this.addNewProductTitleLabel.Text = "Add new product";
            // 
            // removeExistingProductTitleLabel
            // 
            this.removeExistingProductTitleLabel.AutoSize = true;
            this.removeExistingProductTitleLabel.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeExistingProductTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.removeExistingProductTitleLabel.Location = new System.Drawing.Point(20, 433);
            this.removeExistingProductTitleLabel.Name = "removeExistingProductTitleLabel";
            this.removeExistingProductTitleLabel.Size = new System.Drawing.Size(203, 19);
            this.removeExistingProductTitleLabel.TabIndex = 23;
            this.removeExistingProductTitleLabel.Text = "Remove existing product";
            // 
            // removeProductButton
            // 
            this.removeProductButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductButton.Location = new System.Drawing.Point(212, 476);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(104, 34);
            this.removeProductButton.TabIndex = 26;
            this.removeProductButton.Text = "- Remove";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // removeProductLabel
            // 
            this.removeProductLabel.AutoSize = true;
            this.removeProductLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductLabel.Location = new System.Drawing.Point(20, 461);
            this.removeProductLabel.Name = "removeProductLabel";
            this.removeProductLabel.Size = new System.Drawing.Size(111, 19);
            this.removeProductLabel.TabIndex = 24;
            this.removeProductLabel.Text = "Product code";
            // 
            // productCodesCB
            // 
            this.productCodesCB.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCodesCB.FormattingEnabled = true;
            this.productCodesCB.Location = new System.Drawing.Point(24, 483);
            this.productCodesCB.Name = "productCodesCB";
            this.productCodesCB.Size = new System.Drawing.Size(173, 23);
            this.productCodesCB.TabIndex = 25;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 533);
            this.Controls.Add(this.removeExistingProductTitleLabel);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.removeProductLabel);
            this.Controls.Add(this.productCodesCB);
            this.Controls.Add(this.addNewProductTitleLabel);
            this.Controls.Add(this.drinkListLabel);
            this.Controls.Add(this.foodListLabel);
            this.Controls.Add(this.drinkListBox);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceInput);
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
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceInput;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.ListBox drinkListBox;
        private System.Windows.Forms.Label foodListLabel;
        private System.Windows.Forms.Label drinkListLabel;
        private System.Windows.Forms.Label addNewProductTitleLabel;
        private System.Windows.Forms.Label removeExistingProductTitleLabel;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Label removeProductLabel;
        private System.Windows.Forms.ComboBox productCodesCB;
    }
}