using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace hostelRegistrationApp
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void btnChange_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update AdminLogin set UserName='" + TxtUserName.Text + "',Pass='" + TxtPass.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("your password has been updated");
            Application.Restart();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AdminLogin", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                TxtUserName.Text = read["UserName"].ToString() ;
            }
            connection.Close();
        }
    }
}
