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

namespace hostelRegistrationApp
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "select * from AdminLogin where UserName=@_username AND Pass=@_pass";
                SqlParameter username = new SqlParameter("_username", TxtUserName.Text.Trim());
                SqlParameter pass = new SqlParameter("_pass", TxtPass.Text.Trim());
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(username);
                command.Parameters.Add(pass);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmMainForm fr = new frmMainForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username or password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frgtPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword fr = new frmChangePassword();
            fr.Show();
            this.Hide();
        }
    }
}
