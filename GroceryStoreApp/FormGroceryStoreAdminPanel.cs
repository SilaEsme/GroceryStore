using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace GroceryStoreApp
{
    public partial class FormGroceryStoreAdminPanel : Form
    {

        SqlCommand Command;
        SqlDataAdapter DataAdapter;

        public FormGroceryStoreAdminPanel()
        {
            InitializeComponent();
        }

        // Create an array to hold all your objects
        private void CallProduct()
        {
            Database database = Database.CreateSingle();
            database.GetConnection();
            Database.CreateSingle().Sqlconnection.Open();
            DataAdapter = new SqlDataAdapter("SELECT * FROM PRODUCTS", Database.CreateSingle().Sqlconnection);
            DataTable table = new DataTable();
            DataAdapter.Fill(table);
            dataGridViewProducts.DataSource = table;
            Database.CreateSingle().Sqlconnection.Close();
        }
        private void GroceryStoreAdminPanel_Load(object sender, EventArgs e)
        {
            CallProduct();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Application.Exit();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtPrice.Text) && !String.IsNullOrEmpty(txtDescription.Text))
            {

                string command = "INSERT INTO PRODUCTS(Name,Description,Price) VALUES(@Name,@Description,@Price)";
                Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);
                Command.Parameters.AddWithValue("@Name", txtName.Text);
                Command.Parameters.AddWithValue("@Description", txtDescription.Text);
                Command.Parameters.AddWithValue("@Price", txtPrice.Text);

                Database.CreateSingle().Sqlconnection.Open();
                Command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();

                txtName.Text = "";
                txtPrice.Text = "";
                txtDescription.Text = "";

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpeg; *.jpg; *.png;)|*.jpeg; *.jpg; *.png;";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImage.Image = new Bitmap(open.FileName);
                }               
            } 
            CallProduct();
        }

        

        private void Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[3].Value);

            
            string command = "UPDATE PRODUCTS SET Name = @Name, Description = @Description, Price = @Price Where ID='" + id.ToString() + "'";

            Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);
            Command.Parameters.AddWithValue("@Name", txtName.Text);
            Command.Parameters.AddWithValue("@Description", txtDescription.Text);
            Command.Parameters.AddWithValue("@Price", txtPrice.Text);

            Database.CreateSingle().Sqlconnection.Open();
            Command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            CallProduct();
            
        }

        private void btnUpdateImg_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Image Files(*.jpeg; *.jpg; *.png;)|*.jpeg; *.jpg; *.png;";

            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBoxImage.Image = new Bitmap(open.FileName);

            //    Products.Instance().GetList()[ListView1.FocusedItem.Index].Picture = pictureBoxImage.Image;
            //}
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[3].Value);

            string command = "DELETE FROM PRODUCTS WHERE  ID='" + id.ToString() + "'";
            Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);

            Database.CreateSingle().Sqlconnection.Open();
            Command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            CallProduct();
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            //FormSelection selection = new();
            //selection.Show();
            //this.Hide();
        }

        private void dataGridViewProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
            txtDescription.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            //string path = Path.Combine(Environment.CurrentDirectory, @"Images\", fileName);
            //image = Image.FromFile(path);
        }

        private void dataGridViewProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}