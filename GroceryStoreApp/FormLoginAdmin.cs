//LOGIN FOR ADMIN
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class FormLoginAdmin : Form
    {
        //private Admins admins;

        public FormLoginAdmin()
        {
            InitializeComponent();

            //admins = admins.Instance();
            Watermark();
        }

        private void Watermark()
        {
            txtUsername.ForeColor = SystemColors.GrayText;
            txtPassword.ForeColor = SystemColors.GrayText;
            txtUsername.Text = "Please Enter Your Name";
            txtPassword.Text = "Please Enter Your Password";

            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);

           
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Please Enter Your Name")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "Please Enter Your Name";
                txtUsername.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Please Enter Your Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Text = "Please Enter Your Password";
                txtPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin")
            {
                if (txtPassword.Text == "admin123")
                {
                    FormGroceryStoreAdminPanel formGroceryStoreAdminPanel = new FormGroceryStoreAdminPanel();
                    formGroceryStoreAdminPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You are not authorized to login.", "Invalid");
                }
            }
            else
            {
                MessageBox.Show("You are not authorized to login.", "Invalid");
            }
        }

    }
}