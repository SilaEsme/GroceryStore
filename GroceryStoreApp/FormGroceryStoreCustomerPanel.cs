using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class FormGroceryStoreCustomerPanel : Form
    {
        private static FormGroceryStoreCustomerPanel _form;

        public static FormGroceryStoreCustomerPanel Instance
        {
            get
            {
                if (_form == null)
                {
                    _form = new();
                }
                return _form;
            }
        }

        public FormGroceryStoreCustomerPanel()
        {
            InitializeComponent();
        }

        private void FormGroceryStoreCustomerPanel_Load(object sender, EventArgs e)
        {
            _form = this;
            btn_Home_Click(sender,e);
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            FormSelection selection = new();
            selection.Show();
            this.Hide();
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            FormLoginCustomer logincus = new();
            logincus.Show();
            this.Hide();
        }

        private void btn_sepet_Click(object sender, EventArgs e)
        {
            Instance.flowPanelMain.Controls.Clear();
            UserControlShoppingCart.Instance().CreateShoppingItems();
            flowPanelMain.Controls.Add(UserControlShoppingCart.Instance());
            UserControlShoppingCart.Instance().Visible = true;

        }

        private void pictureBox_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            flowPanelMain.Controls.Clear();
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand command = new SqlCommand("SELECT Name, Price FROM Products", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                UserControlProductPanel userControlProductPanel = new UserControlProductPanel(dr.GetString(0), dr.GetString(1));
                flowPanelMain.Controls.Add(userControlProductPanel);
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Instance.flowPanelMain.Controls.Clear();
            UserControlMyProfile myProfile = UserControlMyProfile.Instance();
            myProfile.LoadInformations();
            flowPanelMain.Controls.Add(myProfile);
            myProfile.Visible = true;
        }
    }
}