
namespace GroceryStoreApp
{
    partial class FormGroceryStoreCustomerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroceryStoreCustomerPanel));
            this.flowPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.btn_sepet = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_exit2 = new System.Windows.Forms.PictureBox();
            this.lbl_midas = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_grstoreheader = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowPanelMain
            // 
            this.flowPanelMain.AutoScroll = true;
            this.flowPanelMain.BackColor = System.Drawing.Color.DarkGreen;
            this.flowPanelMain.Location = new System.Drawing.Point(210, 104);
            this.flowPanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowPanelMain.Name = "flowPanelMain";
            this.flowPanelMain.Size = new System.Drawing.Size(1160, 588);
            this.flowPanelMain.TabIndex = 0;
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exit.Image = global::GroceryStoreApp.Properties.Resources.exit;
            this.pictureBox_exit.Location = new System.Drawing.Point(1318, 7);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(34, 25);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 1;
            this.pictureBox_exit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_Profile);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.btn_switch);
            this.panel1.Controls.Add(this.btn_signout);
            this.panel1.Controls.Add(this.btn_sepet);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 597);
            this.panel1.TabIndex = 0;
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.Khaki;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Profile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Profile.Location = new System.Drawing.Point(0, 29);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(203, 79);
            this.btn_Profile.TabIndex = 4;
            this.btn_Profile.Text = "My Profile";
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Khaki;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Home.Location = new System.Drawing.Point(0, 143);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(203, 79);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.BackColor = System.Drawing.Color.Khaki;
            this.btn_switch.FlatAppearance.BorderSize = 0;
            this.btn_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_switch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_switch.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_switch.Location = new System.Drawing.Point(0, 369);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(203, 79);
            this.btn_switch.TabIndex = 2;
            this.btn_switch.Text = "Switch Account";
            this.btn_switch.UseVisualStyleBackColor = false;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.Color.Khaki;
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signout.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_signout.Location = new System.Drawing.Point(0, 483);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(203, 79);
            this.btn_signout.TabIndex = 1;
            this.btn_signout.Text = "Sign Out";
            this.btn_signout.UseVisualStyleBackColor = false;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // btn_sepet
            // 
            this.btn_sepet.BackColor = System.Drawing.Color.Khaki;
            this.btn_sepet.FlatAppearance.BorderSize = 0;
            this.btn_sepet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sepet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sepet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_sepet.Location = new System.Drawing.Point(0, 256);
            this.btn_sepet.Name = "btn_sepet";
            this.btn_sepet.Size = new System.Drawing.Size(203, 79);
            this.btn_sepet.TabIndex = 0;
            this.btn_sepet.Text = "Shopping Cart";
            this.btn_sepet.UseVisualStyleBackColor = false;
            this.btn_sepet.Click += new System.EventHandler(this.btn_sepet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.pictureBox_exit2);
            this.panel2.Controls.Add(this.lbl_midas);
            this.panel2.Controls.Add(this.pictureBox_exit);
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 61);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox_exit2
            // 
            this.pictureBox_exit2.Image = global::GroceryStoreApp.Properties.Resources.exit;
            this.pictureBox_exit2.Location = new System.Drawing.Point(1131, 7);
            this.pictureBox_exit2.Name = "pictureBox_exit2";
            this.pictureBox_exit2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox_exit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit2.TabIndex = 3;
            this.pictureBox_exit2.TabStop = false;
            this.pictureBox_exit2.Click += new System.EventHandler(this.pictureBox_exit2_Click);
            // 
            // lbl_midas
            // 
            this.lbl_midas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_midas.AutoSize = true;
            this.lbl_midas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_midas.ForeColor = System.Drawing.Color.Khaki;
            this.lbl_midas.Location = new System.Drawing.Point(53, 19);
            this.lbl_midas.Name = "lbl_midas";
            this.lbl_midas.Size = new System.Drawing.Size(120, 29);
            this.lbl_midas.TabIndex = 2;
            this.lbl_midas.Text = "M I D A S";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.lbl_grstoreheader);
            this.panel3.Controls.Add(this.lbl_header);
            this.panel3.Location = new System.Drawing.Point(202, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 45);
            this.panel3.TabIndex = 3;
            // 
            // lbl_grstoreheader
            // 
            this.lbl_grstoreheader.AutoSize = true;
            this.lbl_grstoreheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_grstoreheader.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_grstoreheader.Location = new System.Drawing.Point(21, 13);
            this.lbl_grstoreheader.Name = "lbl_grstoreheader";
            this.lbl_grstoreheader.Size = new System.Drawing.Size(182, 22);
            this.lbl_grstoreheader.TabIndex = 3;
            this.lbl_grstoreheader.Text = "GROCERY STORE";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_header.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_header.Location = new System.Drawing.Point(833, 13);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(273, 22);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Welcome to Midas Grocery Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox1.Image = global::GroceryStoreApp.Properties.Resources.icons8_grocery_bag_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormGroceryStoreCustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1374, 695);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGroceryStoreCustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroceryStoreCustomerPanel";
            this.Load += new System.EventHandler(this.FormGroceryStoreCustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Button btn_sepet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.FlowLayoutPanel flowPanelMain;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_midas;
        private System.Windows.Forms.Label lbl_grstoreheader;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_exit2;
        private System.Windows.Forms.Button btn_Profile;
    }
}