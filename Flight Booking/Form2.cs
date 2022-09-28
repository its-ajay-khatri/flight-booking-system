using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Booking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (Form1.Passport == true)
            {
                txtDocNumber.Text = "Passport Document Number";              
                txtExpiryDate.Text = "Passport Expire Date";
            }

            if (Form1.IDCard == true)
            {
                txtDocNumber.Text = "ID Card Document Number";
                txtExpiryDate.Text = "ID Card Expire Date";
            }

            lblFullName.Text = Form1.firstname + " " + Form1.lastname;
            lblSourceCity.Text = Form1.From;
            lblDestination.Text = Form1.To;
            lblTripDates.Text = Form1.Starttripdate + "to" + Form1.Endtripdate;
            lblDocumentNum.Text = Form1.Documentnum;
            lblExpiryDate.Text = Form1.Expirydate;
            lblBaggageWeight.Text = Form1.Weightbaggage;


            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
