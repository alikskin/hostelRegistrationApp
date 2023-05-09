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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void dataShow()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer", connection);
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

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtIdNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoomNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpEntry.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpLeaving.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from AddCustomer where CustomerID=(" + id + ")", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            dataShow();

            if (TxtRoomNo.Text == "101")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room101", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "102")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room102", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "103")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room103", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "104")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room104", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "105")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room105", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "106")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room106", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "107")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room107", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "108")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room108", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }

            if (TxtRoomNo.Text == "109")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from room109", connection);
                command.ExecuteNonQuery();
                connection.Close();
                dataShow();
            }


            Application.Restart();
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtLastName.Clear();
            comboBox1.Text = "";
            MskTxtPhone.Clear();
            TxtMail.Text = "";
            TxtIdNo.Clear();
            TxtRoomNo.Clear();
            TxtPrice.Clear();
            dtpEntry.Text = "";
            dtpLeaving.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update AddCustomer set Name='" + TxtName.Text + "',LastName='" + TxtLastName.Text + "',Gender='" + comboBox1.Text + "',PhoneNumber='" + MskTxtPhone.Text + "',Mail='" + TxtMail.Text + "',IdentificationNumber='" + TxtIdNo.Text + "',RoomNo='" + TxtRoomNo.Text + "',Price='" + TxtPrice.Text + "',DateOfEntry='" + dtpEntry.Value.ToString("yyyy-MM-dd") + "',LeavingDate='" + dtpLeaving.Value.ToString("yyyy-MM-dd") + "'  where CustomerID=" + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            dataShow();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                listView1.Items.Clear();
                connection.Open();
                SqlCommand command = new SqlCommand("select * from AddCustomer where RoomNo like '%"+txtBoxSearch.Text+"%'", connection);
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
    }
}
