using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class UserControlShoppingCart : UserControl
    {
        private static UserControlShoppingCart _shoppingcart;
        private double totalPrice;
        private double totalAmount;

        public void SetLabelAmount(string amount)
        {
            lblTotalAmount.Text = amount;
        }

        public void SetLabelPrice(string price)
        {
            double Price = Double.Parse(price);
            lblTotalPrice.Text = Math.Round(Price, 2).ToString();
        }

        public string GetLabelAmount()
        {
            return lblTotalAmount.Text;
        }

        public string GetLabelPrice()
        {
            return lblTotalPrice.Text;
        }
        protected UserControlShoppingCart()
        {
            InitializeComponent();
            _shoppingcart = this;
        }

        public static UserControlShoppingCart Instance()
        {
            if (_shoppingcart == null)
            {
                _shoppingcart = new UserControlShoppingCart();
            }
            return _shoppingcart;
        }

        public void CreateShoppingItems()
        {
            totalPrice = 0;
            totalAmount = 0;
            flowLayoutPanelShoppingCart.Controls.Clear();
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand Command = new SqlCommand("SELECT * FROM shoppingcart where username='" + LoginedCustomer.Instance().CustomerUser.Username + "'", Database.CreateSingle().Sqlconnection);

            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = Command.ExecuteReader();
            while (dr.Read())
            {
                UserControlShoppingItems userShopItems = new UserControlShoppingItems();
                userShopItems.SetInformations(dr.GetString(0), dr.GetString(2), dr.GetString(1));
                totalPrice += Double.Parse(dr.GetString(2)) * Double.Parse(dr.GetString(1));
                totalAmount += Double.Parse(dr.GetString(1));
                flowLayoutPanelShoppingCart.Controls.Add(userShopItems);
                userShopItems.Visible = true;
            }
            
            lblTotalAmount.Text = totalAmount.ToString();
            lblTotalPrice.Text = Math.Round(totalPrice, 2).ToString();
        }
        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            foreach (var item in FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls.OfType<UserControlProductPanel>())
            {
                item.Visible = true;
            }
            FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls["UserControlShoppingCart"].Visible = false;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShoppingCart.Controls.Clear();
            SetLabelAmount("0");
            SetLabelPrice("0");

            SqlCommand command = new SqlCommand("delete FROM dbo.ShoppingCart where Username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", LoginedCustomer.Instance().CustomerUser.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been created. Your delivery will be arrived as soon as possible.","New Order",MessageBoxButtons.OK);
            btnCancelOrder_Click(sender, e);
        }
    }
}