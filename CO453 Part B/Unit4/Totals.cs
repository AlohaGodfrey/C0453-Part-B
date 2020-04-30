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
    public partial class Totals : Form
    {
        public Totals()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this constructor is used to create an updated Total.cs
        /// form whenever it is initialized.
        /// </summary>
        /// <param name="Total"></param>
        /// <param name="LondonD"></param>
        /// <param name="LewishamD"></param>
        /// <param name="BroadwaterD"></param>
        /// <param name="TotalBill"></param>
        /// <param name="LdnBill"></param>
        /// <param name="LewdBill"></param>
        /// <param name="broadbill"></param>
        public Totals(int Total, int LondonD, int LewishamD, int BroadwaterD, decimal TotalBill, decimal LdnBill, decimal LewdBill, decimal broadbill)
        {
            InitializeComponent();
            txtTotalD.Text = Total.ToString();
            txtLondonD.Text = LondonD.ToString();
            txtLewishamD.Text = LewishamD.ToString();
            txtBroadwaterD.Text = BroadwaterD.ToString();
            txttotalbill.Text = TotalBill.ToString();
            txtldbill.Text = LdnBill.ToString();
            txtlewdbill.Text = LewdBill.ToString();
            txtbroadbill.Text = broadbill.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
