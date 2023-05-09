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
    public partial class frmReceivedItems : Form
    {
        public frmReceivedItems()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");


        private void dataPayments()
        {
            listView2.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Payments", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Electric"].ToString();
                add.SubItems.Add(read["Water"].ToString());
                add.SubItems.Add(read["Internet"].ToString());
                listView2.Items.Add(add);
            }
            connection.Close();
        }

        private void dataKitchen()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Stocks", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Food"].ToString();
                add.SubItems.Add(read["Drinks"].ToString());
                add.SubItems.Add(read["Nuts"].ToString());
                listView1.Items.Add(add);
            }
            connection.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Stocks(Food,Drinks,Nuts) values('" + txtFoods.Text + "','" + txtDrinks.Text + "','" + txtNuts.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Entry Added!");
            dataKitchen();
        }


        private void btnSavePay_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Payments(Electric,Water,Internet) values('" + txtElectric.Text + "','" + txtWater.Text + "','" + txtınt.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Entry Added!");
            dataPayments();
        }

        private void frmReceivedItems_Load(object sender, EventArgs e)
        {
            dataKitchen();
            dataPayments();
        }
    }
}
