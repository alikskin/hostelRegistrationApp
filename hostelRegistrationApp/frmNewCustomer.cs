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
        }

        private void BtnNo102_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "102";
        }

        private void BtnNo103_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "103";
        }

        private void BtnNo104_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "104";
        }

        private void BtnNo105_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "105";
        }

        private void BtnNo106_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "106";
        }

        private void BtnNo107_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "107";
        }

        private void BtnNo108_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "108";
        }

        private void BtnNo109_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "109";
        }

        private void BtnFullRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red buttons indicate occupied rooms!", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEmptyRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green buttons indicate occupied rooms!", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            connection.Close();
            MessageBox.Show("New customer registered!");
        }
    }
}


//Data Source=LENOVO\SQLEXPRESS05;Initial Catalog=hostelRegistrationAppDB;Integrated Security=True