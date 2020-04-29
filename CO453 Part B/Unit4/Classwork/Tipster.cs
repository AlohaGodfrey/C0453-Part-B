using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_Part_B
{
    public partial class Tipster : Form
    {
        private double bill, NumOfPPL, answer;
        private double tipFee = 0.00;


        public Tipster()
        {
            InitializeComponent();
        }

        private void Tipster_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a bill Amount", "Enter Bill");
        }

        private void ltbNumPPL_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumOfPPL = ltbNumPPL.SelectedIndex + 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipFee = 0.1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipFee = 0.15;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipFee = 0.2;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Results newResult = new Results();
            newResult.txtBill.Text = txtBoxBill.Text;
            newResult.txtPPL.Text = NumOfPPL.ToString();

            try
            {
                bill = Convert.ToDouble(txtBoxBill.Text);
                bill = bill * (1 + tipFee);

                answer = bill / NumOfPPL;
            }
            catch
            {
                MessageBox.Show("Error in Data Entry");
            }

            newResult.txtBillTip.Text = bill.ToString("0.00");
            newResult.txtEachPay.Text = answer.ToString("0.00");
            newResult.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}