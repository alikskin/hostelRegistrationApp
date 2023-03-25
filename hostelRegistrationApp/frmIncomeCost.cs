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
    public partial class frmIncomeCost : Form
    {
        public frmIncomeCost()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(Price) as _price from AddCustomer", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lblInCase.Text = read["_price"].ToString();
            }
            connection.Close();

            int personelPrice;
            personelPrice = Convert.ToInt16(txtPersonelPrice.Text);

            int personelNum;
            personelNum = Convert.ToInt16(txtStaffSalary.Text);
            
            lblStaffSalaries.Text = (personelPrice * personelNum).ToString();
        }
    }
}
