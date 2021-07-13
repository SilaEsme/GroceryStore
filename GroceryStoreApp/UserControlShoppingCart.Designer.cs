
namespace GroceryStoreApp
{
    partial class UserControlShoppingCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalItemsHeader = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelShoppingCart = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(9, 354);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(162, 45);
            this.btnCancelOrder.TabIndex = 11;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(821, 354);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(175, 45);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Buy Now";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(572, 391);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(19, 21);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "4";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalItemsHeader
            // 
            this.lblTotalItemsHeader.AutoSize = true;
            this.lblTotalItemsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalItemsHeader.Location = new System.Drawing.Point(538, 364);
            this.lblTotalItemsHeader.Name = "lblTotalItemsHeader";
            this.lblTotalItemsHeader.Size = new System.Drawing.Size(102, 21);
            this.lblTotalItemsHeader.TabIndex = 8;
            this.lblTotalItemsHeader.Text = "Total Amount";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(383, 391);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(37, 21);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "350";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceHeader
            // 
            this.lblTotalPriceHeader.AutoSize = true;
            this.lblTotalPriceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPriceHeader.Location = new System.Drawing.Point(362, 364);
            this.lblTotalPriceHeader.Name = "lblTotalPriceHeader";
            this.lblTotalPriceHeader.Size = new System.Drawing.Size(80, 21);
            this.lblTotalPriceHeader.TabIndex = 6;
            this.lblTotalPriceHeader.Text = "Total Price";
            // 
            // flowLayoutPanelShoppingCart
            // 
            this.flowLayoutPanelShoppingCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelShoppingCart.AutoScroll = true;
            this.flowLayoutPanelShoppingCart.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanelShoppingCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelShoppingCart.Name = "flowLayoutPanelShoppingCart";
            this.flowLayoutPanelShoppingCart.Size = new System.Drawing.Size(993, 348);
            this.flowLayoutPanelShoppingCart.TabIndex = 15;
            // 
            // UserControlShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelShoppingCart);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalItemsHeader);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPriceHeader);
            this.Name = "UserControlShoppingCart";
            this.Size = new System.Drawing.Size(999, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblTotalItemsHeader;
        private System.Windows.Forms.Label lblTotalPriceHeader;
        public System.Windows.Forms.Label lblTotalAmount;
        public System.Windows.Forms.Label lblTotalPrice;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShoppingCart;
    }
}
