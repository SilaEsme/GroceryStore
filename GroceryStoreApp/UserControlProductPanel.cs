using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroceryStoreApp
{
    public partial class UserControlProductPanel : UserControl
    {
        private string desc = "";

        public UserControlProductPanel(string name, string price)
        {
            InitializeComponent();

            lblName.Text = name;
            lblPrice.Text = price;
            //pictureBoxItem.Image = new Bitmap(groceryItems.Picture);
            //desc = groceryItems.Description;
            pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        }

       

        private void btnReadMore_Click(object sender, EventArgs e)
        {

            Database database = Database.CreateSingle();
            database.GetConnection();
            // , Description = @Description, Price = @Price
            SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE Name = @Name", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@Name", lblName.Text);

            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            foreach (var item in FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls.OfType<UserControlProductPanel>())
            {
                item.Visible = false;
            }
            if (!FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls.ContainsKey("UserControlProductInformations"))
            {
                while (dr.Read())
                {
                    UserControlProductInformations productInformations = new();
                    FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls.Add(productInformations);
                    productInformations.WriteDown(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                    //productInformations.Dock = DockStyle.Fill;
                }
                
            }
            else
            {
                var productInformations = FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls.OfType<UserControlProductInformations>().First();
                while(dr.Read())
                    productInformations.WriteDown(dr.GetString(0), dr.GetString(1), dr.GetString(2));
            }

            FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls["UserControlProductInformations"].BringToFront();
            FormGroceryStoreCustomerPanel.Instance.flowPanelMain.Controls["UserControlProductInformations"].Visible = true;
            Database.CreateSingle().Sqlconnection.Close();
           
        }
    }
}