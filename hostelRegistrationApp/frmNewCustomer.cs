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
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True");

        private void BtnNo101_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "101";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room101 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo102_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "102";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room102 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo103_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "103";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room103 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo104_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "104";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room104 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo105_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "105";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room105 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo106_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "106";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room106 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo107_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "107";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room107 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo108_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "108";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room108 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnNo109_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "109";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into room109 (Name,LastName,RoomNo) values ('" + TxtName.Text + "', '" + TxtLastName.Text + "','" + TxtRoomNo.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnFullRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red buttons indicate occupied rooms!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEmptyRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green buttons indicate occupied rooms!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpLeaving_ValueChanged(object sender, EventArgs e)
        {
            int price;
            DateTime kucukTarih = Convert.ToDateTime(dtpEntry.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpLeaving.Text);

            TimeSpan sonuc;
            sonuc = buyukTarih - kucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            price = Convert.ToInt32(label11.Text) * 50;
            TxtPrice.Text = price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("insert into AddCustomer (Name, LastName, Gender, PhoneNumber, Mail, IdentificationNumber, RoomNo, Price, DateOfEntry, LeavingDate) values('" + TxtName.Text + "', '" + TxtLastName.Text + "', '" + comboBox1.Text + "', '" + MskTxtPhone.Text + "', '" + TxtMail.Text + "', '" + TxtIdNo.Text + "', '" + TxtRoomNo.Text + "','" + TxtPrice.Text + "', '" + dtpEntry.Value.ToString("yyyy-MM-dd") + "', '" + dtpLeaving.Value.ToString("yyyy-MM-dd") + "')", connection);
            command.ExecuteNonQuery();
            //connection.Close();
            
            //connection.Open();
            SqlCommand command_chck = new SqlCommand("insert into ChechkOut (Name, LastName, Gender, PhoneNumber, Mail, IdentificationNumber, RoomNo, Price, DateOfEntry, LeavingDate) values('" + TxtName.Text + "', '" + TxtLastName.Text + "', '" + comboBox1.Text + "', '" + MskTxtPhone.Text + "', '" + TxtMail.Text + "', '" + TxtIdNo.Text + "', '" + TxtRoomNo.Text + "','" + TxtPrice.Text + "', '" + dtpEntry.Value.ToString("yyyy-MM-dd") + "', '" + dtpLeaving.Value.ToString("yyyy-MM-dd") + "')", connection);
            command_chck.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New customer registered!");
            Application.Restart();

        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            //room-1
            connection.Open();
            SqlCommand command_1 = new SqlCommand("select * from room101", connection);
            SqlDataReader read_1 = command_1.ExecuteReader();

            while (read_1.Read())
            {
                BtnNo101.Text = read_1["Name"].ToString() + " " + read_1["LastName"].ToString() + " " + read_1["RoomNo"].ToString();
            }
            connection.Close();
            if (BtnNo101.Text != "101")
            {
                BtnNo101.BackColor = Color.Red;
                BtnNo101.Enabled = false;
            }

            //room-2
            connection.Open();
            SqlCommand command_2 = new SqlCommand("select * from room102", connection);
            SqlDataReader read_2 = command_2.ExecuteReader();

            while (read_2.Read())
            {
                BtnNo102.Text = read_2["Name"].ToString() + " " + read_2["LastName"].ToString() + " " + read_2["RoomNo"];
            }
            connection.Close();
            if (BtnNo102.Text != "102")
            {
                BtnNo102.BackColor = Color.Red;
                BtnNo102.Enabled = false;
            }

            //room-3
            connection.Open();
            SqlCommand command_3 = new SqlCommand("select * from room103", connection);
            SqlDataReader read_3 = command_3.ExecuteReader();

            while (read_3.Read())
            {
                BtnNo103.Text = read_3["Name"].ToString() + " " + read_3["LastName"].ToString() + " " + read_3["RoomNo"];
            }
            connection.Close();
            if (BtnNo103.Text != "103")
            {
                BtnNo103.BackColor = Color.Red;
                BtnNo103.Enabled = false;
            }

            //room-4
            connection.Open();
            SqlCommand command_4 = new SqlCommand("select * from room104", connection);
            SqlDataReader read_4 = command_4.ExecuteReader();

            while (read_4.Read())
            {
                BtnNo104.Text = read_4["Name"].ToString() + " " + read_4["LastName"].ToString() + " " + read_4["RoomNo"];
            }
            connection.Close();
            if (BtnNo104.Text != "104")
            {
                BtnNo104.BackColor = Color.Red;
                BtnNo104.Enabled = false;
            }

            //room-5
            connection.Open();
            SqlCommand command_5 = new SqlCommand("select * from room105", connection);
            SqlDataReader read_5 = command_5.ExecuteReader();

            while (read_5.Read())
            {
                BtnNo105.Text = read_5["Name"].ToString() + " " + read_5["LastName"].ToString() + " " + read_5["RoomNo"];
            }
            connection.Close();
            if (BtnNo105.Text != "105")
            {
                BtnNo105.BackColor = Color.Red;
                BtnNo105.Enabled = false;
            }

            //room-6
            connection.Open();
            SqlCommand command_6 = new SqlCommand("select * from room106", connection);
            SqlDataReader read_6 = command_6.ExecuteReader();

            while (read_6.Read())
            {
                BtnNo106.Text = read_6["Name"].ToString() + " " + read_6["LastName"].ToString() + " " + read_6["RoomNo"];
            }
            connection.Close();
            if (BtnNo106.Text != "106")
            {
                BtnNo106.BackColor = Color.Red;
                BtnNo106.Enabled = false;
            }

            //room-7
            connection.Open();
            SqlCommand command_7 = new SqlCommand("select * from room107", connection);
            SqlDataReader read_7 = command_7.ExecuteReader();

            while (read_7.Read())
            {
                BtnNo107.Text = read_7["Name"].ToString() + " " + read_7["LastName"].ToString() + " " + read_7["RoomNo"];
            }
            connection.Close();
            if (BtnNo107.Text != "107")
            {
                BtnNo107.BackColor = Color.Red;
                BtnNo107.Enabled = false;
            }

            //room-8
            connection.Open();
            SqlCommand command_8 = new SqlCommand("select * from room108", connection);
            SqlDataReader read_8 = command_8.ExecuteReader();

            while (read_8.Read())
            {
                BtnNo108.Text = read_8["Name"].ToString() + " " + read_8["LastName"].ToString() + " " + read_8["RoomNo"].ToString();
            }
            connection.Close();
            if (BtnNo108.Text != "108")
            {
                BtnNo108.BackColor = Color.Red;
                BtnNo108.Enabled = false;
            }

            //room-9
            connection.Open();
            SqlCommand command_9 = new SqlCommand("select * from room109", connection);
            SqlDataReader read_9 = command_9.ExecuteReader();

            while (read_9.Read())
            {
                BtnNo109.Text = read_9["Name"].ToString() + " " + read_9["LastName"].ToString() + " " + read_9["RoomNo"];
            }
            connection.Close();
            if (BtnNo109.Text != "109")
            {
                BtnNo109.BackColor = Color.Red;
                BtnNo109.Enabled = false;
            }
        }
    }
}


//Data Source=LENOVO\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True