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

        private void data()
        {
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
            
        }

        private void frmReceivedItems_Load(object sender, EventArgs e)
        {
            data();
        }
    }
}
