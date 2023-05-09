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
    public partial class frmCheckOutCustomers : Form
    {
        public frmCheckOutCustomers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void dataShow()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from ChechkOut", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["LastName"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["PhoneNumber"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["IdentificationNumber"].ToString());
                add.SubItems.Add(read["RoomNo"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["DateOfEntry"].ToString());
                add.SubItems.Add(read["LeavingDate"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataShow();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from ChechkOut where RoomNo like '%" + txtBoxSearch.Text + "%'", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["LastName"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["PhoneNumber"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["IdentificationNumber"].ToString());
                add.SubItems.Add(read["RoomNo"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["DateOfEntry"].ToString());
                add.SubItems.Add(read["LeavingDate"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from ChechkOut where Name like '%" + txtBoxNameSearch.Text + "%'", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["LastName"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["PhoneNumber"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["IdentificationNumber"].ToString());
                add.SubItems.Add(read["RoomNo"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["DateOfEntry"].ToString());
                add.SubItems.Add(read["LeavingDate"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtBoxNameSearch.Clear();
            txtBoxSearch.Clear();   
        }
    }
}
