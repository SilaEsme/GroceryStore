using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GroceryStoreApp
{
    public partial class FormSelection : Form
    {

        public FormSelection()
        {
            InitializeComponent();
        }

        private void pictureBoxAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin fla = new FormLoginAdmin();
            fla.Show();
            this.Hide();
        }

        private void pictureBoxCustomer_Click(object sender, EventArgs e)
        {
            FormLoginCustomer flc = new FormLoginCustomer();
            flc.Show();
            this.Hide();
        }

        private void exit_picturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSelection_Load(object sender, EventArgs e)
        {
        }
    }
}