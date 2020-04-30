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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this button updates the database, once the user clicks 
        /// accept on the bill.cs form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcceptBill_Click(object sender, EventArgs e)
        {

            if (txtSchool.Text == "London")
            {
                DataEntry.ldnum++;
                DataEntry.ldnumbill = DataEntry.ldnumbill + Convert.ToDecimal(txtBillAmount.Text);
            }
            else if (txtSchool.Text == "Lewisham")
            {
                DataEntry.lewdnum++;
                DataEntry.lewdnumbill = DataEntry.lewdnumbill + Convert.ToDecimal(txtBillAmount.Text);
            }
            else
            {
                DataEntry.broadnum++;
                DataEntry.broadnumbill = DataEntry.broadnumbill + Convert.ToDecimal(txtBillAmount.Text);
            }

        }
    }
}
