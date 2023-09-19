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
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.ShowDialog();
            this.Hide();
        }

        //AddNewCustomer
        private void button2_Click(object sender, EventArgs e)
        {
            frmNewCustomer fr = new frmNewCustomer();
            fr.ShowDialog();
        }

        //Rooms
        private void button3_Click(object sender, EventArgs e)
        {
            frmRooms fr = new frmRooms();
            fr.Show();
        }

        //Customers
        private void button4_Click(object sender, EventArgs e)
        {
            frmCustomers fr = new frmCustomers();
            fr.Show();
        }

        //AboutMe
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("github.com/alikskin  -  www.linkedin.com/in/alikskin");
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //IncomeCost
        private void btnIncomeCost_Click(object sender, EventArgs e)
        {
            frmIncomeCost fr = new frmIncomeCost();
            fr.ShowDialog();
        }

        //Stock
        private void btnStock_Click(object sender, EventArgs e)
        {
            frmReceivedItems fr = new frmReceivedItems();
            fr.ShowDialog();
        }

        //ListenToRadio
        private void button8_Click(object sender, EventArgs e)
        {
            frmListenToRadio fr = new frmListenToRadio();
            fr.Show();
        }

        //News
        private void button11_Click(object sender, EventArgs e)
        {
            frmNews fr = new frmNews();
            fr.Show();
        }


        private void frmMainForm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //Change Pass
        private void btnChngdPass_Click(object sender, EventArgs e)
        {
            frmChangePassword fr = new frmChangePassword();
            fr.ShowDialog();
        }

        //CheckOutCustomers
        private void button5_Click(object sender, EventArgs e)
        {
            frmCheckOutCustomers fr = new frmCheckOutCustomers();
            fr.ShowDialog();
        }

        //POS
        private void button6_Click(object sender, EventArgs e)
        {
            frmPos fr = new frmPos();
            fr.ShowDialog();
        }
    }
}
