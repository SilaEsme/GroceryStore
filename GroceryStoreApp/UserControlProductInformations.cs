using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace GroceryStoreApp
{
    public partial class UserControlProductInformations : UserControl
    {
        SqlCommand Command;
        SqlCommand Command2;
        public UserControlProductInformations()
        {
            InitializeComponent();
            
            this.Visible = false;
        }

        public void WriteDown(string name, string desc, string price)
        {
            lblNameinfo.Text = name;
            lblDescriptioninfo.Text = desc;
            lblPriceinfo.Text = price;
        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            foreach (var item in FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls.OfType<UserControlProductPanel>())
            {
                item.Visible = true;
            }
            this.Visible = false;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int SqlAmount = 0;
            bool read;
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand amount = new SqlCommand("SELECT Amount from ShoppingCart where Product='" + lblNameinfo.Text + "' and Username='" + LoginedCustomer.Instance().CustomerUser.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = amount.ExecuteReader();
            read = dr.Read();
            Database.CreateSingle().Sqlconnection.Close();

            if (read==false)//data yoktur yeni eklenecek
            {
                string command = "INSERT INTO ShoppingCart(Product,UnitPrice,Amount, Username) VALUES(@Product,@UnitPrice,@Amount,@Username)";
                Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);
                Command.Parameters.AddWithValue("@Product", lblNameinfo.Text);
                Command.Parameters.AddWithValue("@Amount", "1");
                Command.Parameters.AddWithValue("@UnitPrice", lblPriceinfo.Text);
                Command.Parameters.AddWithValue("@Username", LoginedCustomer.Instance().CustomerUser.Username);
                Database.CreateSingle().Sqlconnection.Open();
                Command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
            else if(read==true)//data vardır amount arttırılcak
            {
                SqlCommand amount2 = new SqlCommand("SELECT Amount from ShoppingCart where Product='" + lblNameinfo.Text + "' and Username='" + LoginedCustomer.Instance().CustomerUser.Username + "'", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr2 = amount2.ExecuteReader();    
               
                while (dr2.Read())
                {
                    SqlAmount = Int32.Parse(dr2.GetString(0));
                }

                Database.CreateSingle().Sqlconnection.Close();
                SqlAmount++;
                string command2 = "UPDATE ShoppingCart SET Amount=@Amount where Product='" + lblNameinfo.Text + "' and Username='" + LoginedCustomer.Instance().CustomerUser.Username + "'";
                Command2 = new SqlCommand(command2, Database.CreateSingle().Sqlconnection);
                Command2.Parameters.AddWithValue("@Amount", SqlAmount.ToString());
                Database.CreateSingle().Sqlconnection.Open();
                Command2.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
        }
    }
}