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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Btn_Signup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("UserName and Password is mandatory ");
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;");
                {
                    con.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", con);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration is Succesful. User Added to Database");
                    this.Close();
                    new Login().Show();
                    Clear();

                }
                void Clear()
                {
                    txtUsername.Text = txtPassword.Text = txtEmailAddress.Text = "";
                }
            }
        }
    }
}
