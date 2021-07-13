//LOGIN FOR CUSTOMER
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace GroceryStoreApp
{
    public partial class FormLoginCustomer : Form
    {
        SqlCommand Command;
        static int ID = 4;
        public int MyID
        {
            get => ID;
            set => ID = value;
        }
        public FormLoginCustomer()
        {
            InitializeComponent();
            Watermark();
        }

        private void Watermark()
        {
            txtUsername.ForeColor = SystemColors.GrayText;
            txtPassword.ForeColor = SystemColors.GrayText;
            
            txtUsername.Text = "Please Enter Your Username";
            txtPassword.Text = "Please Enter Your Password";

            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);

            txtUsernameS.ForeColor = SystemColors.GrayText;
            txtPasswordS.ForeColor = SystemColors.GrayText;
            txtConfirmPassword.ForeColor = SystemColors.GrayText;
            
            txtName.Text = "Please Enter Your Name";
            txtAdres.Text = "Please Enter Your Address";
            txtTelefon.Text = "Please Enter Your Telephone Number";
            txtUsernameS.Text = "Please Enter Your Username";
            txtPasswordS.Text = "Please Enter Your Password";
            txtConfirmPassword.Text = "Please Confirm Your Password";

            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtAdres.Leave += new System.EventHandler(this.txtAdres_Leave);
            this.txtAdres.Enter += new System.EventHandler(this.txtAdres_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            this.txtUsernameS.Leave += new System.EventHandler(this.txtUsernameS_Leave);
            this.txtUsernameS.Enter += new System.EventHandler(this.txtUsernameS_Enter);
            this.txtPasswordS.Leave += new System.EventHandler(this.txtPasswordS_Leave);
            this.txtPasswordS.Enter += new System.EventHandler(this.txtPasswordS_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
        }

        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "Please Enter Your Telephone Number")
            {
                txtTelefon.Text = "";
                txtTelefon.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length == 0)
            {
                txtTelefon.Text = "Please Enter Your Telephone Number";
                txtTelefon.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtAdres_Enter(object sender, EventArgs e)
        {
            if (txtAdres.Text == "Please Enter Your Address")
            {
                txtAdres.Text = "";
                txtAdres.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text.Length == 0)
            {
                txtAdres.Text = "Please Enter Your Address";
                txtAdres.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                txtName.Text = "Please Enter Your Name";
                txtName.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Please Enter Your Name")
            {
                txtName.Text = "";
                txtName.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Please Enter Your Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "Please Enter Your Username";
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

        private void FormLoginCustomer_Load(object sender, EventArgs e)
        {
        }

        private void txtUsernameS_Enter(object sender, EventArgs e)
        {
            if (txtUsernameS.Text == "Please Enter Your Username")
            {
                txtUsernameS.Text = "";
                txtUsernameS.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUsernameS_Leave(object sender, EventArgs e)
        {
            if (txtUsernameS.Text.Length == 0)
            {
                txtUsernameS.Text = "Please Enter Your Username";
                txtUsernameS.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPasswordS_Enter(object sender, EventArgs e)
        {
            if (txtPasswordS.Text == "Please Enter Your Password")
            {
                txtPasswordS.Text = "";
                txtPasswordS.ForeColor = SystemColors.WindowText;
                txtPasswordS.PasswordChar = '*';
            }
        }

        private void txtPasswordS_Leave(object sender, EventArgs e)
        {
            if (txtPasswordS.Text.Length == 0)
            {
                txtPasswordS.Text = "Please Enter Your Password";
                txtPasswordS.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Please Confirm Your Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = SystemColors.WindowText;
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Length == 0)
            {
                txtConfirmPassword.Text = "Please Confirm Your Password";
                txtConfirmPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void ShowPass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass_checkbox.Checked)
            {
                txtPasswordS.PasswordChar = '\0';
                ShowPass_checkbox.Text = "Hide Password";
            }
            else
            {
                txtPasswordS.PasswordChar = '*';
                ShowPass_checkbox.Text = "Show Password";
            }
        }

        private void ShowPass2_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass2_checkbox.Checked)
            {
                txtConfirmPassword.PasswordChar = '\0';
                ShowPass2_checkbox.Text = "Hide Password";
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
                ShowPass2_checkbox.Text = "Show Password";
            }
        }

        private void exit_picturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Database database = Database.CreateSingle();
            database.GetConnection();
            
            SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

           
            while (dr.Read())
            {

                if (dr.GetString(5) == txtUsername.Text)
                {
                        
                    if (dr.GetString(4) == txtPassword.Text)
                    {
                        CustomerUser loginedCustomer = new CustomerUser();

                        loginedCustomer.Name = dr.GetString(1);
                        loginedCustomer.Telephone = dr.GetString(2);
                        loginedCustomer.Address = dr.GetString(3);
                        loginedCustomer.Password = dr.GetString(4);
                        loginedCustomer.Username = dr.GetString(5);
                        //loginedCustomer.Path = dr.GetString(6);

                        LoginedCustomer.Instance().CustomerUser = loginedCustomer;

                        FormGroceryStoreCustomerPanel customerPanel = new();
                        customerPanel.Show();
                        this.Hide();
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = true;
                        MessageBox.Show("Your password or username is not correct. Please check your informations.", "Opppppps");
                        break;
                    }
                }
            }

            if(flag==false)
                MessageBox.Show("Your password or username is not correct. Please check your informations.", "Opppppps");

            Database.CreateSingle().Sqlconnection.Close();
        }
        
        private void sign_up_Click(object sender, EventArgs e)
        {
            Database database=Database.CreateSingle();
            database.GetConnection();
            FormGroceryStoreAdminPanel formGroceryStoreAdminPanel = new FormGroceryStoreAdminPanel();
            if (txtPasswordS.Text == txtConfirmPassword.Text)
            {
                string command = "INSERT INTO Customer(ID,_Name,Phone,Address, Password, Username,Path) VALUES(@id,@_Name,@Phone,@Address,@Password,@Username,@path)";
                Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);
                Command.Parameters.AddWithValue("@id", ID);
                Command.Parameters.AddWithValue("@_Name", txtName.Text);
                Command.Parameters.AddWithValue("@Phone", txtTelefon.Text);
                Command.Parameters.AddWithValue("@Address", txtAdres.Text);
                Command.Parameters.AddWithValue("@Password", txtPasswordS.Text);
                Command.Parameters.AddWithValue("@Username", txtUsernameS.Text);
                Command.Parameters.AddWithValue("@path", "default-picture.jpg");

                Database.CreateSingle().Sqlconnection.Open();
                Command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
                ID++;
                labelSuccess.Text = "Your account has been created succesfully!";
            }
            else
            {
                MessageBox.Show("Your password and confirm password doesn't match!", "Opppppps");
            }
        }
    }
}