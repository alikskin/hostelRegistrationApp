using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNewCustomer fr = new frmNewCustomer();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRooms fr = new frmRooms();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("github.com/alikskin  -  www.linkedin.com/in/alikskin");
        }

        private void frmMainForm_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHour.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncomeCost_Click(object sender, EventArgs e)
        {
            frmIncomeCost fr = new frmIncomeCost(); 
            fr.Show();  
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmReceivedItems fr = new frmReceivedItems();
            fr.Show();
        }
    }
}
