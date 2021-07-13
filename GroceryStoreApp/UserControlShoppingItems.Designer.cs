
namespace GroceryStoreApp
{
    partial class UserControlShoppingItems
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceHeader = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitPriceHeader = new System.Windows.Forms.Label();
            this.pictureBox_Item = new System.Windows.Forms.PictureBox();
            this.lblNameHeader = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblTotalAmountH = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Peach";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(245, 59);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 15);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "$1";
            // 
            // lblTotalPriceHeader
            // 
            this.lblTotalPriceHeader.AutoSize = true;
            this.lblTotalPriceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPriceHeader.Location = new System.Drawing.Point(208, 27);
            this.lblTotalPriceHeader.Name = "lblTotalPriceHeader";
            this.lblTotalPriceHeader.Size = new System.Drawing.Size(73, 17);
            this.lblTotalPriceHeader.TabIndex = 3;
            this.lblTotalPriceHeader.Text = "Total Price";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(156, 59);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(19, 15);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "$1";
            // 
            // lblUnitPriceHeader
            // 
            this.lblUnitPriceHeader.AutoSize = true;
            this.lblUnitPriceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnitPriceHeader.Location = new System.Drawing.Point(134, 27);
            this.lblUnitPriceHeader.Name = "lblUnitPriceHeader";
            this.lblUnitPriceHeader.Size = new System.Drawing.Size(68, 17);
            this.lblUnitPriceHeader.TabIndex = 5;
            this.lblUnitPriceHeader.Text = "Unit Price";
            // 
            // pictureBox_Item
            // 
            this.pictureBox_Item.Location = new System.Drawing.Point(3, 18);
            this.pictureBox_Item.Name = "pictureBox_Item";
            this.pictureBox_Item.Size = new System.Drawing.Size(75, 69);
            this.pictureBox_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Item.TabIndex = 6;
            this.pictureBox_Item.TabStop = false;
            // 
            // lblNameHeader
            // 
            this.lblNameHeader.AutoSize = true;
            this.lblNameHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameHeader.Location = new System.Drawing.Point(84, 27);
            this.lblNameHeader.Name = "lblNameHeader";
            this.lblNameHeader.Size = new System.Drawing.Size(44, 17);
            this.lblNameHeader.TabIndex = 1;
            this.lblNameHeader.Text = "Name";
            this.lblNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(311, 58);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(18, 19);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(356, 58);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(18, 19);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "-";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblTotalAmountH
            // 
            this.lblTotalAmountH.AutoSize = true;
            this.lblTotalAmountH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmountH.Location = new System.Drawing.Point(300, 27);
            this.lblTotalAmountH.Name = "lblTotalAmountH";
            this.lblTotalAmountH.Size = new System.Drawing.Size(97, 17);
            this.lblTotalAmountH.TabIndex = 9;
            this.lblTotalAmountH.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(335, 60);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(15, 17);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 30);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 47);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserControlShoppingItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalAmountH);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pictureBox_Item);
            this.Controls.Add(this.lblUnitPriceHeader);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblTotalPriceHeader);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblNameHeader);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlShoppingItems";
            this.Size = new System.Drawing.Size(465, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceHeader;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnitPriceHeader;
        private System.Windows.Forms.PictureBox pictureBox_Item;
        private System.Windows.Forms.Label lblNameHeader;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblTotalAmountH;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnCancel;
    }
}
