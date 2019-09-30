using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMS
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            SqlDataAdapter ProductData = new SqlDataAdapter("SELECT * FROM [Product]", con);
            DataTable dt = new DataTable();
            ProductData.Fill(dt);
            OrderGrid.DataSource = dt;

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            conn.Open();
            SqlCommand sql = new SqlCommand("ProductCreate", conn);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ProductName", txtProdName.Text);
            sql.Parameters.AddWithValue("@ProductDescription", txtProdDescription.Text);
            sql.Parameters.AddWithValue("@ProductType", txtProdType.Text);
            sql.ExecuteNonQuery();
        
            MessageBox.Show("Order Added Successfully");
            LoadData();


        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.Product' table. You can move, or remove it, as needed.

            LoadData();



        }
        
  
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            conn.Open();
            SqlCommand sql = new SqlCommand("Delete From Product Where ProductName = @ProductName", conn);
            sql.CommandType = CommandType.Text;
            sql.Parameters.AddWithValue("@ProductName", txtProdName.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Order Deleted Successfully");
            LoadData();


        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.OrderGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtProdName.Text = row.Cells[1].Value.ToString();
                txtProdType.Text = row.Cells[2].Value.ToString();
                txtProdDescription.Text = row.Cells[3].Value.ToString();

            }
           

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            conn.Open();
            SqlCommand updatesql = new SqlCommand("UPDATE [Product] Set ProductType=@ProductType, ProductDescription=@ProductDescription Where ProductName=@ProductName", conn);
            updatesql.CommandType = CommandType.Text;
            updatesql.Parameters.AddWithValue("@ProductName", txtProdName.Text);
            updatesql.Parameters.AddWithValue("@ProductType", txtProdType.Text);
            updatesql.Parameters.AddWithValue("@ProductDescription", txtProdDescription.Text);
            updatesql.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Order Updated Successfully");
            LoadData();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to log out", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (logout == DialogResult.OK)
            {
               
                this.Hide();
                new Login().Show();
            }
            if (logout == DialogResult.Cancel)
            {
                this.Show();
            }
            
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            SqlDataAdapter ProductData = new SqlDataAdapter("select * from Product where ProductName like '" + txt_Search.Text + "%'", con);
            DataTable dt = new DataTable();
            ProductData.Fill(dt);
            OrderGrid.DataSource = dt;
        }

        private void LogOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to log out", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (logout == DialogResult.OK)
            {

                this.Hide();
                new Login().Show();
            }
            if (logout == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
