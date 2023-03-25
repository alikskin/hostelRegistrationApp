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
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void frmRooms_Load(object sender, EventArgs e)
        {

            //room-1
            connection.Open();
            SqlCommand command_1 = new SqlCommand("select * from room101", connection);
            SqlDataReader read_1 = command_1.ExecuteReader();

            while (read_1.Read())
            {
                BtnNo101.Text = read_1["Name"].ToString() + " " + read_1["LastName"].ToString() + " " + read_1["RoomNo"].ToString();
            }
            if (BtnNo101.Text != "101")
            {
                BtnNo101.BackColor = Color.Red;
            }
            connection.Close();

            //room-2
            connection.Open();
            SqlCommand command_2 = new SqlCommand("select * from room102", connection);
            SqlDataReader read_2 = command_2.ExecuteReader();

            while (read_2.Read())
            {
                BtnNo102.Text = read_2["Name"].ToString() + " " + read_2["LastName"].ToString() + " " + read_2["RoomNo"];
            }
            if (BtnNo102.Text != "102")
            {
                BtnNo102.BackColor = Color.Red;
            }
            connection.Close();

            //room-3
            connection.Open();
            SqlCommand command_3 = new SqlCommand("select * from room103", connection);
            SqlDataReader read_3 = command_3.ExecuteReader();

            while (read_3.Read())
            {
                BtnNo103.Text = read_3["Name"].ToString() + " " + read_3["LastName"].ToString() + " " + read_3["RoomNo"];
            }
            if (BtnNo103.Text != "103")
            {
                BtnNo103.BackColor = Color.Red;
            }
            connection.Close();

            //room-4
            connection.Open();
            SqlCommand command_4 = new SqlCommand("select * from room104", connection);
            SqlDataReader read_4 = command_4.ExecuteReader();

            while (read_4.Read())
            {
                BtnNo104.Text = read_4["Name"].ToString() + " " + read_4["LastName"].ToString() + " " + read_4["RoomNo"];
            }
            if (BtnNo104.Text != "104")
            {
                BtnNo104.BackColor = Color.Red;
            }
            connection.Close();

            //room-5
            connection.Open();
            SqlCommand command_5 = new SqlCommand("select * from room105", connection);
            SqlDataReader read_5 = command_5.ExecuteReader();

            while (read_5.Read())
            {
                BtnNo105.Text = read_5["Name"].ToString() + " " + read_5["LastName"].ToString() + " " + read_5["RoomNo"];
            }
            if (BtnNo105.Text != "105")
            {
                BtnNo105.BackColor = Color.Red;
            }
            connection.Close();

            //room-6
            connection.Open();
            SqlCommand command_6 = new SqlCommand("select * from room106", connection);
            SqlDataReader read_6 = command_6.ExecuteReader();

            while (read_6.Read())
            {
                BtnNo106.Text = read_6["Name"].ToString() + " " + read_6["LastName"].ToString() + " " + read_6["RoomNo"];
            }
            if (BtnNo106.Text != "106")
            {
                BtnNo106.BackColor = Color.Red;
            }
            connection.Close();

            //room-7
            connection.Open();
            SqlCommand command_7 = new SqlCommand("select * from room107", connection);
            SqlDataReader read_7 = command_7.ExecuteReader();

            while (read_7.Read())
            {
                BtnNo107.Text = read_7["Name"].ToString() + " " + read_7["LastName"].ToString() + " " + read_7["RoomNo"];
            }
            if (BtnNo107.Text != "107")
            {
                BtnNo107.BackColor = Color.Red;
            }
            connection.Close();

            //room-8
            connection.Open();
            SqlCommand command_8 = new SqlCommand("select * from room108", connection);
            SqlDataReader read_8 = command_8.ExecuteReader();

            while (read_8.Read())
            {
                BtnNo108.Text = read_8["Name"].ToString() + " " + read_8["LastName"].ToString() + " " + read_8["RoomNo"];
            }
            if (BtnNo108.Text != "108")
            {
                BtnNo108.BackColor = Color.Red;
            }
            connection.Close();

            //room-9
            connection.Open();
            SqlCommand command_9 = new SqlCommand("select * from room109", connection);
            SqlDataReader read_9 = command_9.ExecuteReader();

            while (read_9.Read())
            {
                BtnNo109.Text = read_9["Name"].ToString() + " " + read_9["LastName"].ToString() + " " + read_9["RoomNo"];
            }
            if (BtnNo109.Text != "109")
            {
                BtnNo109.BackColor = Color.Red;
            }
            connection.Close();
        }
    }
}
