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

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn= new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\db\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            conn.Open();
            SqlCommand sql = new SqlCommand("ProductCreate", conn);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@ProductName", txtProdName.Text);
            sql.Parameters.AddWithValue("@ProductDescription", txtProdDescription.Text);
            sql.Parameters.AddWithValue("@ProductType", txtProdType.Text);
            sql.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Order Added Successfully");

            this.productTableAdapter.Fill(this.dataDataSet.Product);

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataDataSet.Product);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OrderGrid.Rows.Count; i++)
            {

                DataGridViewRow dr = OrderGrid.Rows[i];
                if (dr.Selected == true)
                {
                    SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\shres\\Documents\\Data.mdf; Integrated Security = True; Connect Timeout = 30");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Product where ProductName ='" + i + "'", conn);
    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted");
                    conn.Close();
                }

            }
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
    }
}
