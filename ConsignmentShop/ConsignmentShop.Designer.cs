namespace ConsignmentShop
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingcartlistboxLabel = new System.Windows.Forms.Label();
            this.shoppingcartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(-1, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(403, 45);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 21;
            this.itemsListbox.Location = new System.Drawing.Point(12, 116);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(198, 172);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsListboxLabel.Location = new System.Drawing.Point(12, 92);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(96, 21);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(231, 185);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(145, 31);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingcartlistboxLabel
            // 
            this.shoppingcartlistboxLabel.AutoSize = true;
            this.shoppingcartlistboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoppingcartlistboxLabel.Location = new System.Drawing.Point(412, 92);
            this.shoppingcartlistboxLabel.Name = "shoppingcartlistboxLabel";
            this.shoppingcartlistboxLabel.Size = new System.Drawing.Size(119, 21);
            this.shoppingcartlistboxLabel.TabIndex = 5;
            this.shoppingcartlistboxLabel.Text = "Shopping Cart";
            // 
            // shoppingcartListBox
            // 
            this.shoppingcartListBox.FormattingEnabled = true;
            this.shoppingcartListBox.ItemHeight = 21;
            this.shoppingcartListBox.Location = new System.Drawing.Point(412, 116);
            this.shoppingcartListBox.Name = "shoppingcartListBox";
            this.shoppingcartListBox.Size = new System.Drawing.Size(201, 172);
            this.shoppingcartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(526, 294);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(87, 30);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListLabel
            // 
            this.vendorListLabel.AutoSize = true;
            this.vendorListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorListLabel.Location = new System.Drawing.Point(12, 319);
            this.vendorListLabel.Name = "vendorListLabel";
            this.vendorListLabel.Size = new System.Drawing.Size(72, 21);
            this.vendorListLabel.TabIndex = 8;
            this.vendorListLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 21;
            this.vendorListBox.Location = new System.Drawing.Point(12, 343);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(198, 172);
            this.vendorListBox.TabIndex = 7;
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Location = new System.Drawing.Point(352, 343);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(91, 21);
            this.StoreProfitLabel.TabIndex = 9;
            this.StoreProfitLabel.Text = "Store Profit:";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Location = new System.Drawing.Point(482, 343);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(49, 21);
            this.StoreProfitValue.TabIndex = 10;
            this.StoreProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.vendorListLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingcartlistboxLabel);
            this.Controls.Add(this.shoppingcartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerText;
        private ListBox itemsListbox;
        private Label itemsListboxLabel;
        private Button addToCart;
        private Label shoppingcartlistboxLabel;
        private ListBox shoppingcartListBox;
        private Button makePurchase;
        private Label vendorListLabel;
        private ListBox vendorListBox;
        private Label StoreProfitLabel;
        private Label StoreProfitValue;
    }
}