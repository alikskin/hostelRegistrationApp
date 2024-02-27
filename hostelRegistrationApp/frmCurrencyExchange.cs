using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace hostelRegistrationApp
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            String today = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string usdAlis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'USD']/BanknoteBuying").InnerXml;
            txtUsdAlis.Text = usdAlis;

            string usdSatis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'USD']/BanknoteSelling").InnerXml;
            txtUsdSatis.Text = usdSatis;

            string eurAlis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'EUR']/BanknoteBuying").InnerXml;
            txtEurAlis.Text = eurAlis;

            string eurSatis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'EUR']/BanknoteSelling").InnerXml;
            txtEurSatis.Text = eurSatis;

            string gbpAlis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'GBP']/BanknoteBuying").InnerXml;
            txtGbpAlis.Text = gbpAlis;

            string gbpSatis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'GBP']/BanknoteSelling").InnerXml;
            txtGbpSatis.Text = gbpSatis;


        }


        
        private void cBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            String today = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string eurAlis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'EUR']/BanknoteBuying").InnerXml;
            string usdAlis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'USD']/BanknoteBuying").InnerXml;
            string gbpAlis = xmlDoc.SelectSingleNode("Tarih_Date /Currency[@Kod = 'GBP']/BanknoteBuying").InnerXml;

            

            if (cBoxCurrency.Text == "EUR")
            {

                lblCurrency.Text = eurAlis;
            }
            else if (cBoxCurrency.Text == "USD")
            {
                lblCurrency.Text = usdAlis;
            }
            else if (cBoxCurrency.Text == "GBP")
            {
                lblCurrency.Text = gbpAlis;
            }
            else 
            {
                lblCurrency.Text = "Currency not found!";
            }

        }

        double currency, takenAmount, sum;

        //sadece sayı girisi
        private void lblAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lblAmount_TextChanged(object sender, EventArgs e)
        {
            currency = Convert.ToDouble(lblCurrency.Text);
            takenAmount = Convert.ToDouble(lblAmount.Text);
            sum = currency * takenAmount;

            lblCurExchange.Text = sum.ToString();


        }

        private void lblCurrency_TextChanged(object sender, EventArgs e)
        {
            lblCurrency.Text = lblCurrency.Text.Replace(".",",");
        }
    }
}
