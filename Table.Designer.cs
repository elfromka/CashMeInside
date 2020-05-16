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
            this.stockProductsListBox = new System.Windows.Forms.ListBox();
            this.boughtProductsListBox = new System.Windows.Forms.ListBox();
            this.addBPListButton = new System.Windows.Forms.Button();
            this.removeBPListButton = new System.Windows.Forms.Button();
            this.totalToPayLabel = new System.Windows.Forms.Label();
            this.totalPayNumberLabel = new System.Windows.Forms.Label();
            this.totalPayCurrencyLabel = new System.Windows.Forms.Label();
            this.clientsPayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tableNumberLabel.TabIndex = 0;
            this.tableNumberLabel.Text = "?";
            this.tableNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockProductsListBox
            // 
            this.stockProductsListBox.Font = new System.Drawing.Font("Raleway", 12F);
            this.stockProductsListBox.FormattingEnabled = true;
            this.stockProductsListBox.ItemHeight = 19;
            this.stockProductsListBox.Location = new System.Drawing.Point(26, 234);
            this.stockProductsListBox.Name = "stockProductsListBox";
            this.stockProductsListBox.Size = new System.Drawing.Size(224, 194);
            this.stockProductsListBox.TabIndex = 1;
            // 
            // boughtProductsListBox
            // 
            this.boughtProductsListBox.Font = new System.Drawing.Font("Raleway", 12F);
            this.boughtProductsListBox.FormattingEnabled = true;
            this.boughtProductsListBox.ItemHeight = 19;
            this.boughtProductsListBox.Location = new System.Drawing.Point(403, 234);
            this.boughtProductsListBox.Name = "boughtProductsListBox";
            this.boughtProductsListBox.Size = new System.Drawing.Size(231, 194);
            this.boughtProductsListBox.TabIndex = 2;
            // 
            // addBPListButton
            // 
            this.addBPListButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBPListButton.Location = new System.Drawing.Point(271, 267);
            this.addBPListButton.Name = "addBPListButton";
            this.addBPListButton.Size = new System.Drawing.Size(113, 48);
            this.addBPListButton.TabIndex = 3;
            this.addBPListButton.Text = "Add >>";
            this.addBPListButton.UseVisualStyleBackColor = true;
            this.addBPListButton.Click += new System.EventHandler(this.addBPListButton_Click);
            // 
            // removeBPListButton
            // 
            this.removeBPListButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBPListButton.Location = new System.Drawing.Point(271, 345);
            this.removeBPListButton.Name = "removeBPListButton";
            this.removeBPListButton.Size = new System.Drawing.Size(113, 48);
            this.removeBPListButton.TabIndex = 4;
            this.removeBPListButton.Text = "<< Back";
            this.removeBPListButton.UseVisualStyleBackColor = true;
            this.removeBPListButton.Click += new System.EventHandler(this.removeBPListButton_Click);
            // 
            // totalToPayLabel
            // 
            this.totalToPayLabel.AutoSize = true;
            this.totalToPayLabel.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToPayLabel.Location = new System.Drawing.Point(262, 465);
            this.totalToPayLabel.Name = "totalToPayLabel";
            this.totalToPayLabel.Size = new System.Drawing.Size(140, 19);
            this.totalToPayLabel.TabIndex = 0;
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
            this.totalPayNumberLabel.TabIndex = 0;
            this.totalPayNumberLabel.Text = "0";
            // 
            // totalPayCurrencyLabel
            // 
            this.totalPayCurrencyLabel.AutoSize = true;
            this.totalPayCurrencyLabel.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayCurrencyLabel.Location = new System.Drawing.Point(342, 510);
            this.totalPayCurrencyLabel.Name = "totalPayCurrencyLabel";
            this.totalPayCurrencyLabel.Size = new System.Drawing.Size(44, 19);
            this.totalPayCurrencyLabel.TabIndex = 0;
            this.totalPayCurrencyLabel.Text = "RON";
            // 
            // clientsPayButton
            // 
            this.clientsPayButton.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsPayButton.Location = new System.Drawing.Point(281, 562);
            this.clientsPayButton.Name = "clientsPayButton";
            this.clientsPayButton.Size = new System.Drawing.Size(94, 48);
            this.clientsPayButton.TabIndex = 5;
            this.clientsPayButton.Text = "Pay";
            this.clientsPayButton.UseVisualStyleBackColor = true;
            this.clientsPayButton.Click += new System.EventHandler(this.clientsPayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products on stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chosen products";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientsPayButton);
            this.Controls.Add(this.totalPayCurrencyLabel);
            this.Controls.Add(this.totalPayNumberLabel);
            this.Controls.Add(this.totalToPayLabel);
            this.Controls.Add(this.removeBPListButton);
            this.Controls.Add(this.addBPListButton);
            this.Controls.Add(this.boughtProductsListBox);
            this.Controls.Add(this.stockProductsListBox);
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
        private System.Windows.Forms.ListBox stockProductsListBox;
        private System.Windows.Forms.ListBox boughtProductsListBox;
        private System.Windows.Forms.Button addBPListButton;
        private System.Windows.Forms.Button removeBPListButton;
        private System.Windows.Forms.Label totalToPayLabel;
        private System.Windows.Forms.Label totalPayNumberLabel;
        private System.Windows.Forms.Label totalPayCurrencyLabel;
        private System.Windows.Forms.Button clientsPayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}