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
            int personelPrice;
            personelPrice = Convert.ToInt16(txtPersonelPrice.Text);

            int personelNum;
            personelNum = Convert.ToInt16(txtStaffSalary.Text);

            lblStaffSalaries.Text = (personelPrice * personelNum).ToString();
        }

        private void frmIncomeCost_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(Price) as _price from AddCustomer", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lblInCase.Text = read["_price"].ToString();
            }
            connection.Close();

            //Food
            connection.Open();
            SqlCommand food = new SqlCommand("select sum(Food) as total from Stocks", connection);
            SqlDataReader readFood = food.ExecuteReader();
            while (readFood.Read())
            {
                lblFood.Text = readFood["total"].ToString();
            }
            connection.Close();

            //Drinks
            connection.Open();
            SqlCommand drinks = new SqlCommand("select sum(Drinks) as total from Stocks", connection);
            SqlDataReader readDrinks = drinks.ExecuteReader();
            while (readDrinks.Read())
            {
                lblDrinks.Text = readDrinks["total"].ToString();
            }
            connection.Close();

            //Nuts
            connection.Open();
            SqlCommand nuts = new SqlCommand("select sum(Nuts) as total from Stocks", connection);
            SqlDataReader readNuts = nuts.ExecuteReader();
            while (readNuts.Read())
            {
                lblNuts.Text = readNuts["total"].ToString();
            }
            connection.Close();

            //Electric
            connection.Open();
            SqlCommand comElectric = new SqlCommand("select sum(Electric) as total from Payments", connection);
            SqlDataReader readElectric = comElectric.ExecuteReader();
            while (readElectric.Read())
            {
                lblElectric.Text = readElectric["total"].ToString();
            }
            connection.Close();

            //Water
            connection.Open();
            SqlCommand comWater = new SqlCommand("select sum(Water) as total from Payments", connection);
            SqlDataReader readWater = comWater.ExecuteReader();
            while (readWater.Read())
            {
                lblWater.Text = readWater["total"].ToString();
            }
            connection.Close();

            //Internet
            connection.Open();
            SqlCommand comInt = new SqlCommand("select sum(Internet) as total from Payments", connection);
            SqlDataReader readInt = comInt.ExecuteReader();
            while (readInt.Read())
            {
                lblInt.Text = readInt["total"].ToString();
            }
            connection.Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int totalStaffSalaries, totalPurchased, totalPayments, result;

            totalStaffSalaries = Convert.ToInt32(lblStaffSalaries.Text);
            totalPurchased = Convert.ToInt32(lblFood.Text) + Convert.ToInt32(lblDrinks.Text) + Convert.ToInt32(lblNuts.Text);
            totalPayments = Convert.ToInt32(lblElectric.Text) + Convert.ToInt32(lblWater.Text) + Convert.ToInt32(lblInt.Text);

            result = Convert.ToInt32(lblInCase.Text) - (Convert.ToInt32(totalStaffSalaries) + Convert.ToInt32(totalPurchased) + Convert.ToInt32(totalPayments));

            lblResult.Text = result.ToString();
        }
    }
}
