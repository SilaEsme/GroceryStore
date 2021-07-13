
namespace GroceryStoreApp
{
    partial class FormSelection
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
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.exit_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Image = global::GroceryStoreApp.Properties.Resources.admin;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(236, 264);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(294, 167);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 0;
            this.pictureBoxAdmin.TabStop = false;
            this.pictureBoxAdmin.Click += new System.EventHandler(this.pictureBoxAdmin_Click);
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Image = global::GroceryStoreApp.Properties.Resources.customer;
            this.pictureBoxCustomer.Location = new System.Drawing.Point(565, 264);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(294, 167);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustomer.TabIndex = 1;
            this.pictureBoxCustomer.TabStop = false;
            this.pictureBoxCustomer.Click += new System.EventHandler(this.pictureBoxCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(323, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(629, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Login";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(314, 126);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(479, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "MIDAS GROCERY STORE";
            // 
            // exit_picturebox
            // 
            this.exit_picturebox.Image = global::GroceryStoreApp.Properties.Resources.exit;
            this.exit_picturebox.Location = new System.Drawing.Point(1056, 12);
            this.exit_picturebox.Name = "exit_picturebox";
            this.exit_picturebox.Size = new System.Drawing.Size(72, 52);
            this.exit_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_picturebox.TabIndex = 5;
            this.exit_picturebox.TabStop = false;
            this.exit_picturebox.Click += new System.EventHandler(this.exit_picturebox_Click);
            // 
            // FormSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1140, 633);
            this.Controls.Add(this.exit_picturebox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Controls.Add(this.pictureBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.FormSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox exit_picturebox;
    }
}