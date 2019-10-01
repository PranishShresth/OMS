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
    public partial class Customer : Form
    {


        public Customer()
        {
            InitializeComponent();
        }
       
        private void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            SqlDataAdapter CustomerData = new SqlDataAdapter("SELECT * FROM [Customer]", con);
            DataTable dt = new DataTable();
            CustomerData.Fill(dt);
            CustomerGridView.DataSource = dt;

        }



        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;"); // making connection   
            con.Open();
            SqlCommand CustAdd = new SqlCommand("INSERT INTO Customer(CustName,CustPhone,CustAddress) VALUES (@CustName,@CustPhone,@CustAddress)", con);
            CustAdd.CommandType = CommandType.Text;
            CustAdd.Parameters.AddWithValue("@CustName", txtCustName.Text);
            CustAdd.Parameters.AddWithValue("@CustPhone", txtCustPhn.Text);
            CustAdd.Parameters.AddWithValue("@CustAddress", txtCustAdd.Text);
            CustAdd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Customer Added");
            ShowData();

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void Txt_Search_Cust_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
            SqlDataAdapter CustomerData = new SqlDataAdapter("select * from [Customer] where CustName like '" + txt_Search_Cust.Text + "%'", con);
            DataTable dt = new DataTable();
            CustomerData.Fill(dt);
            CustomerGridView.DataSource = dt;
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

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Profile().Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {
         
        }
    }
}
