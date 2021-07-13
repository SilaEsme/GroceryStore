
namespace GroceryStoreApp
{
    partial class UserControlProductPanel
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(1, 210);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(216, 18);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(1, 177);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(216, 18);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReadMore
            // 
            this.btnReadMore.BackColor = System.Drawing.Color.LightCoral;
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Location = new System.Drawing.Point(62, 242);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(94, 29);
            this.btnReadMore.TabIndex = 7;
            this.btnReadMore.Text = "Read More";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Location = new System.Drawing.Point(39, 24);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(141, 137);
            this.pictureBoxItem.TabIndex = 9;
            this.pictureBoxItem.TabStop = false;
            // 
            // UserControlProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.pictureBoxItem);
            this.Name = "UserControlProductPanel";
            this.Size = new System.Drawing.Size(221, 296);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.PictureBox pictureBoxItem;
    }
}
