using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class UserControlShoppingItems : UserControl
    {
        private UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.Instance();

        private double totalAmount = 0;
        
        public double TotalAmount
        {
            get => totalAmount;
            set => totalAmount = value;
        }

        private double totalPrice = 0;

        public double TotalPrice
        {
            get => totalPrice;
            set => totalPrice = value;
        }

        public UserControlShoppingItems()
        {
            InitializeComponent();
        }

        public void SetInformations(string name,string price,string amount)
        {
            lblName.Text = name;
            lblUnitPrice.Text = price;
            lblTotalAmount.Text = amount;

            lblTotalPrice.Text = (Double.Parse(price) * Int32.Parse(amount)).ToString();

            Database database = Database.CreateSingle();
            database.GetConnection();

            string imagename = "";
            var dirs = Directory.GetFiles(@"Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command2 = new SqlCommand("SELECT Path FROM dbo.Products WHERE name = @name", Database.CreateSingle().Sqlconnection);
            command2.Parameters.AddWithValue("@name", lblName.Text);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr2 = command2.ExecuteReader();

            while (dr2.Read())
            {
                imagename = dr2.GetString(0);
            }

            Database.CreateSingle().Sqlconnection.Close();

            foreach (var item in dirs)
            {
                if (Path.GetFileName(item) == imagename)
                {
                    pictureBox_Item.Image = new Bitmap(item);
                }
            }
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update dbo.shoppingcart set Amount=@amount WHERE product = @name and username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
            command.Parameters.AddWithValue("@username", LoginedCustomer.Instance().CustomerUser.Username);
            int amount = Int32.Parse(lblTotalAmount.Text) + 1;
            lblTotalAmount.Text = amount.ToString();
            command.Parameters.AddWithValue("@amount", amount.ToString());

            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

            int TempAmount = 0;
            double TempPrice = 0;
            TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
            TempAmount++;
            userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

            TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
            TempPrice += Double.Parse(this.lblUnitPrice.Text);
            userControlShoppingCart.SetLabelPrice(TempPrice.ToString());
            lblTotalPrice.Text = Math.Round((Double.Parse(lblTotalAmount.Text) * Double.Parse(lblUnitPrice.Text)), 2).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int TempAmount = 0;
            double TempPrice = 0;
            TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
            TempAmount -= Int32.Parse(this.lblTotalAmount.Text);
            userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

            TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
            TempPrice -= Double.Parse(this.lblUnitPrice.Text) * Int32.Parse(lblTotalAmount.Text);
            userControlShoppingCart.SetLabelPrice(TempPrice.ToString());

            this.Visible = false;
            userControlShoppingCart.flowLayoutPanelShoppingCart.Controls.Remove(this);

            SqlCommand command = new SqlCommand("delete from dbo.shoppingcart WHERE product = @name and username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
            command.Parameters.AddWithValue("@username", LoginedCustomer.Instance().CustomerUser.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text == "1")
            {
                btnCancel_Click(sender, e);
            }
            else
            {
                SqlCommand command = new SqlCommand("update dbo.shoppingcart set Amount=@amount WHERE Product = @name and username=@username", Database.CreateSingle().Sqlconnection);
                command.Parameters.AddWithValue("@name", lblName.Text);
                command.Parameters.AddWithValue("@username", LoginedCustomer.Instance().CustomerUser.Username);

                int TempAmount = 0;
                double TempPrice = 0;
                int amount = Int32.Parse(lblTotalAmount.Text) - 1;
                lblTotalAmount.Text = amount.ToString();
                TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
                TempAmount--;
                userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

                TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
                TempPrice -= Double.Parse(this.lblUnitPrice.Text);//
                userControlShoppingCart.SetLabelPrice(TempPrice.ToString());
                command.Parameters.AddWithValue("@amount", amount.ToString());

                lblTotalPrice.Text = Math.Round((Double.Parse(lblTotalAmount.Text) * Double.Parse(lblUnitPrice.Text)), 2).ToString();


                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
        }
    }
}