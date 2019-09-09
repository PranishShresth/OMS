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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\db\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
                conn.Open();
                SqlCommand sql = new SqlCommand("ResetPassword", conn);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Password", txtNewPassword.Text);
                sql.Parameters.AddWithValue("@Username", textBox1.Text);
                sql.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password changed.");
                new Login().Show();
            }
            else
                MessageBox.Show("The password donot match. Please try again.");
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
