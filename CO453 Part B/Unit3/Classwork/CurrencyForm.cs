﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_Part_B.Unit3.Classwork
{
    /// <summary>
    /// Task 3.1
    /// This class can convert UK pounds into the equivalent amount
    /// in euros, dollars or rupees
    /// Author: Godfrey
    /// </summary>
    public partial class CurrencyForm : Form
    {
        private const decimal POUNDS_TO_DOLLARS = 1.19M;
        private const decimal POUNDS_TO_EUROS = 1.08M;
        private const decimal POUNDS_TO_RUPEES = 88.27M;

        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are your sure?", "Close Form", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void calculateDollars(object sender, EventArgs e)
        {
            decimal pounds = getPounds();
            amountTextBox.Text = (pounds * POUNDS_TO_DOLLARS).ToString("0.00");
        }


        private void calculateEuros(object sender, EventArgs e)
        {
            decimal pounds = getPounds();
            amountTextBox.Text = (pounds * POUNDS_TO_EUROS).ToString("0.00");
        }

        private void calculateRupees(object sender, EventArgs e)
        {
            decimal pounds = getPounds();
            amountTextBox.Text = (pounds * POUNDS_TO_RUPEES).ToString("0.00");
        }

        private decimal getPounds()
        {
            string value = poundsTextBox.Text;
            return Convert.ToDecimal(value);
        }
    }
}
