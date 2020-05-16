namespace CashMeInside
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.tablePB = new System.Windows.Forms.PictureBox();
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.stockProductsList = new System.Windows.Forms.ListBox();
            this.boughtProductsList = new System.Windows.Forms.ListBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.totalToPayLabel = new System.Windows.Forms.Label();
            this.totalPayNumberLabel = new System.Windows.Forms.Label();
            this.totalPayCurrencyLabel = new System.Windows.Forms.Label();
            this.clientsPayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePB)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePB
            // 
            this.tablePB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tablePB.Image = ((System.Drawing.Image)(resources.GetObject("tablePB.Image")));
            this.tablePB.Location = new System.Drawing.Point(266, 35);
            this.tablePB.Name = "tablePB";
            this.tablePB.Size = new System.Drawing.Size(118, 150);
            this.tablePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tablePB.TabIndex = 2;
            this.tablePB.TabStop = false;
            // 
            // tableNumberLabel
            // 
            this.tableNumberLabel.AutoSize = true;
            this.tableNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tableNumberLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableNumberLabel.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberLabel.Location = new System.Drawing.Point(318, 64);
            this.tableNumberLabel.Name = "tableNumberLabel";
            this.tableNumberLabel.Size = new System.Drawing.Size(22, 25);
            this.tableNumberLabel.TabIndex = 3;
            this.tableNumberLabel.Text = "?";
            this.tableNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockProductsList
            // 
            this.stockProductsList.Font = new System.Drawing.Font("Raleway", 12F);
            this.stockProductsList.FormattingEnabled = true;
            this.stockProductsList.ItemHeight = 19;
            this.stockProductsList.Location = new System.Drawing.Point(26, 234);
            this.stockProductsList.Name = "stockProductsList";
            this.stockProductsList.Size = new System.Drawing.Size(224, 194);
            this.stockProductsList.TabIndex = 4;
            // 
            // boughtProductsList
            // 
            this.boughtProductsList.Font = new System.Drawing.Font("Raleway", 12F);
            this.boughtProductsList.FormattingEnabled = true;
            this.boughtProductsList.ItemHeight = 19;
            this.boughtProductsList.Location = new System.Drawing.Point(403, 234);
            this.boughtProductsList.Name = "boughtProductsList";
            this.boughtProductsList.Size = new System.Drawing.Size(231, 194);
            this.boughtProductsList.TabIndex = 5;
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(271, 267);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(113, 48);
            this.addProductButton.TabIndex = 6;
            this.addProductButton.Text = "Add >>";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // removeProductButton
            // 
            this.removeProductButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProductButton.Location = new System.Drawing.Point(271, 345);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(113, 48);
            this.removeProductButton.TabIndex = 7;
            this.removeProductButton.Text = "Remove >>";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // totalToPayLabel
            // 
            this.totalToPayLabel.AutoSize = true;
            this.totalToPayLabel.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToPayLabel.Location = new System.Drawing.Point(262, 465);
            this.totalToPayLabel.Name = "totalToPayLabel";
            this.totalToPayLabel.Size = new System.Drawing.Size(140, 19);
            this.totalToPayLabel.TabIndex = 8;
            this.totalToPayLabel.Text = "Total of payment";
            // 
            // totalPayNumberLabel
            // 
            this.totalPayNumberLabel.AutoSize = true;
            this.totalPayNumberLabel.Font = new System.Drawing.Font("Raleway SemiBold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalPayNumberLabel.Location = new System.Drawing.Point(281, 485);
            this.totalPayNumberLabel.Name = "totalPayNumberLabel";
            this.totalPayNumberLabel.Size = new System.Drawing.Size(61, 64);
            this.totalPayNumberLabel.TabIndex = 9;
            this.totalPayNumberLabel.Text = "0";
            // 
            // totalPayCurrencyLabel
            // 
            this.totalPayCurrencyLabel.AutoSize = true;
            this.totalPayCurrencyLabel.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayCurrencyLabel.Location = new System.Drawing.Point(342, 510);
            this.totalPayCurrencyLabel.Name = "totalPayCurrencyLabel";
            this.totalPayCurrencyLabel.Size = new System.Drawing.Size(44, 19);
            this.totalPayCurrencyLabel.TabIndex = 10;
            this.totalPayCurrencyLabel.Text = "RON";
            // 
            // clientsPayButton
            // 
            this.clientsPayButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsPayButton.Location = new System.Drawing.Point(281, 562);
            this.clientsPayButton.Name = "clientsPayButton";
            this.clientsPayButton.Size = new System.Drawing.Size(94, 48);
            this.clientsPayButton.TabIndex = 11;
            this.clientsPayButton.Text = "Pay";
            this.clientsPayButton.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 651);
            this.Controls.Add(this.clientsPayButton);
            this.Controls.Add(this.totalPayCurrencyLabel);
            this.Controls.Add(this.totalPayNumberLabel);
            this.Controls.Add(this.totalToPayLabel);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.boughtProductsList);
            this.Controls.Add(this.stockProductsList);
            this.Controls.Add(this.tableNumberLabel);
            this.Controls.Add(this.tablePB);
            this.MaximizeBox = false;
            this.Name = "Table";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashMeInside - Table";
            ((System.ComponentModel.ISupportInitialize)(this.tablePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox tablePB;
        private System.Windows.Forms.Label tableNumberLabel;
        private System.Windows.Forms.ListBox stockProductsList;
        private System.Windows.Forms.ListBox boughtProductsList;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Label totalToPayLabel;
        private System.Windows.Forms.Label totalPayNumberLabel;
        private System.Windows.Forms.Label totalPayCurrencyLabel;
        private System.Windows.Forms.Button clientsPayButton;
    }
}