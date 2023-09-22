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

namespace hostelRegistrationApp
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        


        private void frmMainForm_Load(object sender, EventArgs e)
        {
            

            timer1.Start();

            connection.Open();
            SqlCommand command = new SqlCommand("select * from AdminLogin", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                lblUser.Text = read["UserName"].ToString();
            }
            connection.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHour.Text = DateTime.Now.ToLongTimeString();
        }


        //AdminLogin
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.ShowDialog();
            this.Hide();
        }

        //AddNewCustomer
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer fr = new frmNewCustomer();
            fr.ShowDialog();
        }

        //Rooms
        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRooms fr = new frmRooms();
            fr.Show();
        }

        //Customers
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers fr = new frmCustomers();
            fr.ShowDialog();
        }

        //AboutMe
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("github.com/alikskin  -  www.linkedin.com/in/alikskin");
        }

        //Exit
        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //IncomeCost
        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmIncomeCost fr = new frmIncomeCost();
            fr.ShowDialog();
        }

        //Stock
        private void ıconbtnStock_Click(object sender, EventArgs e)
        {
            frmReceivedItems fr = new frmReceivedItems();
            fr.ShowDialog();
        }

        //ListenToRadio
        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmListenToRadio fr = new frmListenToRadio();
            fr.Show();
        }

        //News
        private void btnNews_Click(object sender, EventArgs e)
        {
            frmNews fr = new frmNews();
            fr.Show();
        }


        private void frmMainForm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //Change Pass
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword fr = new frmChangePassword();
            fr.ShowDialog();
        }

        //CheckOutCustomers
        private void btnCoutList_Click(object sender, EventArgs e)
        {
            frmCheckOutCustomers fr = new frmCheckOutCustomers();
            fr.Show();
        }

        //POS
        private void btnPos_Click(object sender, EventArgs e)
        {
            frmPos fr = new frmPos();
            fr.ShowDialog();
        }

        
    }
}
