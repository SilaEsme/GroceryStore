using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class UserControlMyProfile : UserControl
    {
        private static UserControlMyProfile _object;

        protected UserControlMyProfile()
        {
            InitializeComponent();
        }

        //Set labels with up-to-date customer informations
        public void LoadInformations()
        {
            LoginedCustomer customer = LoginedCustomer.Instance();
            lblUsername.Text = customer.CustomerUser.Username;
            txtChangeAddress.Text = customer.CustomerUser.Address;
            txtChangeName.Text = customer.CustomerUser.Name;
            txtChangePhoneNumber.Text = customer.CustomerUser.Telephone;
            txtChangePassword.Text = customer.CustomerUser.Password;
            string imagename = "";
            var dirs = Directory.GetFiles(@"Profile Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT Path FROM dbo.Customer WHERE username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", customer.CustomerUser.Username);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                imagename = dr.GetString(0);
            }
            Database.CreateSingle().Sqlconnection.Close();

            foreach (var item in dirs)
            {
                if (Path.GetFileName(item) == imagename)
                {
                    pictureBoxCustomer.Image = new Bitmap(item);
                }
            }
        }

        public static UserControlMyProfile Instance()
        {
            if (_object == null)
            {
                _object = new UserControlMyProfile();
            }
            return _object;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE Username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", LoginedCustomer.Instance().CustomerUser.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

            SqlCommand command2 = new SqlCommand("DELETE FROM ShoppingCart WHERE Username = @username", Database.CreateSingle().Sqlconnection);
            command2.Parameters.AddWithValue("@username", LoginedCustomer.Instance().CustomerUser.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command2.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

            FormLoginCustomer logincus = new FormLoginCustomer();
            logincus.MyID--;
            logincus.Show();
            FormGroceryStoreCustomerPanel.Instance.Hide();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            LoginedCustomer customer = LoginedCustomer.Instance();
            SqlCommand command = new SqlCommand("UPDATE Customer SET _Name=@name,Address=@adress,phone=@Phone,password=@Password where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", txtChangeName.Text);
            command.Parameters.AddWithValue("@adress", txtChangeAddress.Text);
            command.Parameters.AddWithValue("@Phone", txtChangePhoneNumber.Text);
            command.Parameters.AddWithValue("@Password", txtChangePassword.Text);
            command.Parameters.AddWithValue("@username", customer.CustomerUser.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

           
            customer.CustomerUser.Name = txtChangeName.Text;
            customer.CustomerUser.Telephone = txtChangePhoneNumber.Text;
            customer.CustomerUser.Address = txtChangeAddress.Text;
            customer.CustomerUser.Password = txtChangePassword.Text;

            lblInfoUpdate.Text = "Your Informations is Updated Succesfully!";
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {

        }
    }
}