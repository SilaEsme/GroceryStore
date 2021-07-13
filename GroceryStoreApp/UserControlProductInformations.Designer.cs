
namespace GroceryStoreApp
{
    partial class UserControlProductInformations
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
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.lblPriceH = new System.Windows.Forms.Label();
            this.lblNameH = new System.Windows.Forms.Label();
            this.lblDescriptionH = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblPriceinfo = new System.Windows.Forms.Label();
            this.lblNameinfo = new System.Windows.Forms.Label();
            this.lblDescriptioninfo = new System.Windows.Forms.Label();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Location = new System.Drawing.Point(238, 147);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(280, 272);
            this.pictureBoxItem.TabIndex = 5;
            this.pictureBoxItem.TabStop = false;
            // 
            // lblPriceH
            // 
            this.lblPriceH.AutoSize = true;
            this.lblPriceH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriceH.Location = new System.Drawing.Point(585, 233);
            this.lblPriceH.Name = "lblPriceH";
            this.lblPriceH.Size = new System.Drawing.Size(59, 25);
            this.lblPriceH.TabIndex = 6;
            this.lblPriceH.Text = "Price:";
            // 
            // lblNameH
            // 
            this.lblNameH.AutoSize = true;
            this.lblNameH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameH.Location = new System.Drawing.Point(585, 177);
            this.lblNameH.Name = "lblNameH";
            this.lblNameH.Size = new System.Drawing.Size(67, 25);
            this.lblNameH.TabIndex = 7;
            this.lblNameH.Text = "Name:";
            // 
            // lblDescriptionH
            // 
            this.lblDescriptionH.AutoSize = true;
            this.lblDescriptionH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionH.Location = new System.Drawing.Point(585, 288);
            this.lblDescriptionH.Name = "lblDescriptionH";
            this.lblDescriptionH.Size = new System.Drawing.Size(114, 25);
            this.lblDescriptionH.TabIndex = 8;
            this.lblDescriptionH.Text = "Description:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(646, 380);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(119, 39);
            this.btnAddToCart.TabIndex = 9;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblPriceinfo
            // 
            this.lblPriceinfo.AutoSize = true;
            this.lblPriceinfo.Location = new System.Drawing.Point(757, 235);
            this.lblPriceinfo.Name = "lblPriceinfo";
            this.lblPriceinfo.Size = new System.Drawing.Size(50, 20);
            this.lblPriceinfo.TabIndex = 10;
            this.lblPriceinfo.Text = "label1";
            // 
            // lblNameinfo
            // 
            this.lblNameinfo.AutoSize = true;
            this.lblNameinfo.Location = new System.Drawing.Point(757, 180);
            this.lblNameinfo.Name = "lblNameinfo";
            this.lblNameinfo.Size = new System.Drawing.Size(50, 20);
            this.lblNameinfo.TabIndex = 11;
            this.lblNameinfo.Text = "label2";
            // 
            // lblDescriptioninfo
            // 
            this.lblDescriptioninfo.AutoSize = true;
            this.lblDescriptioninfo.Location = new System.Drawing.Point(757, 289);
            this.lblDescriptioninfo.Name = "lblDescriptioninfo";
            this.lblDescriptioninfo.Size = new System.Drawing.Size(50, 20);
            this.lblDescriptioninfo.TabIndex = 12;
            this.lblDescriptioninfo.Text = "label3";
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Image = global::GroceryStoreApp.Properties.Resources.back;
            this.pictureBoxReturn.Location = new System.Drawing.Point(32, 35);
            this.pictureBoxReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(40, 45);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 13;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Click += new System.EventHandler(this.pictureBoxReturn_Click);
            // 
            // UserControlProductInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.lblDescriptioninfo);
            this.Controls.Add(this.lblNameinfo);
            this.Controls.Add(this.lblPriceinfo);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblDescriptionH);
            this.Controls.Add(this.lblNameH);
            this.Controls.Add(this.lblPriceH);
            this.Controls.Add(this.pictureBoxItem);
            this.Name = "UserControlProductInformations";
            this.Size = new System.Drawing.Size(1160, 588);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.Label lblPriceH;
        private System.Windows.Forms.Label lblNameH;
        private System.Windows.Forms.Label lblDescriptionH;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblPriceinfo;
        private System.Windows.Forms.Label lblNameinfo;
        private System.Windows.Forms.Label lblDescriptioninfo;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
    }
}
