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
    public partial class Form1 : Form
    {
        public static Boolean Passport, IDCard;
        public static String To, From, Starttripdate, Endtripdate, firstname, lastname, Documentnum, Issuedate, Expirydate, Weightbaggage;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            To = txtTo.Text;
            From = txtFrom.Text;

            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;

            Documentnum = txtDocNumber.Text;

            Starttripdate = monthCalendar1.SelectionStart.ToString("dd mm yyyy");
            Endtripdate = monthCalendar1.SelectionEnd.ToString("dd mm yyyy");

            Issuedate = dateTimePicker1.Value.ToString("dd mm yyyy");
            Expirydate = dateTimePicker1.Value.ToString("dd mm yyyy");

            Weightbaggage = numericUpDown1.Value.ToString();

            this.Hide();

            Form2 ff2 = new Form2();
            ff2.Show();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void rdbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPassport.Checked == true)
            {
                lblDocNumber.Text = "Passport Number";
                lblDocIssue.Text = "Passport Issue Date";
                lblDocExpiry.Text = "Passport Expiry Date";

                Passport = true;
            }
            else
            {
                Passport = false;
            }
        }
        private void rdbIDCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIDCard.Checked == true)
            {
                lblDocNumber.Text = "ID Card Number";
                lblDocIssue.Text = "ID Card Issue Date";
                lblDocExpiry.Text = "ID Card Expiry Date";

                IDCard = true;
            }
            else
            {
                IDCard = false;
            }
        }
    }
}
