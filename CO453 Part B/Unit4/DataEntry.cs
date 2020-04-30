using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_Part_B.Unit4
{
    public partial class DataEntry : Form
    {

        /// <summary>
        /// This class is the main application that assks the user
        /// to enter their details for the event
        /// 
        /// Author: Godfrey
        /// </summary>
        private double billAmount = 50;
        public static int ldnum = 0;
        public static int lewdnum = 0;
        public static int broadnum = 0;
        public static decimal ldnumbill = 0;
        public static decimal lewdnumbill = 0;
        public static decimal broadnumbill = 0;


        public DataEntry()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This button opens up the Totals.cs using a specific 
        /// constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int totalnum = ldnum + lewdnum + broadnum;
            decimal totalbill = ldnumbill + lewdnumbill + broadnumbill;
            Totals TotalData = new Totals(totalnum, ldnum, lewdnum, broadnum, totalbill, ldnumbill, lewdnumbill, broadnumbill);
            TotalData.Show();
        }

        /// <summary>
        /// This button notifies the user if they forget to add their name,
        /// it also calculates the bill amounts and sets up the Bills.cs form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeeBill_Click(object sender, EventArgs e)
        {
            Bills NewBill = new Bills();
            string[] schools = new string[] { "Lewisham", "London", "Broadwater" };

            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter a Name!", "Data Entry Error");
            }

            billAmount = 50;
            if (ckbxDinner.Checked && ckbxLunch.Checked)
            {
                billAmount = billAmount + 25;
            }
            else if (ckbxDinner.Checked)
            {
                billAmount = billAmount + 15;
            }
            else if (ckbxLunch.Checked)
            {
                billAmount = billAmount + 10;
            }

            NewBill.txtName.Text = txtName.Text;
            NewBill.txtSchool.Text = schools[cbxSchool.SelectedIndex];
            NewBill.txtBillAmount.Text = billAmount.ToString();

            NewBill.Show();



        }
    }
}
