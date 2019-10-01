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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ResetPassword().Show();
            this.Hide();
        }

     
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\My Projects\\OMS\\OMS\\Data.mdf;Integrated Security=True;Connect Timeout = 30;"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Login] WHERE UserName='" + txtUser.Text + "' AND Password='" + txtPass.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                /*Will take to dashboard page*/
                this.Hide();
                Dashboard frm = new Dashboard(txtUser.Text);
                frm.Show();
                MessageBox.Show("Login success");
            }
            else
                MessageBox.Show("Invalid username or password");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
