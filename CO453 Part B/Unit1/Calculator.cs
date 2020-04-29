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
    public partial class Calculator : Form
    {
        private double number1;
        private double number2;
        private double result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        private void Calculate(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            getNumbers();

            switch (button.Tag)
            {
                case "+":
                    result = number1 + number2;
                    this.BackColor = Color.Red;

                    break;

                //task 1.8
                case "power":
                    result = Math.Pow(number1, number2);
                    this.BackColor = Color.PaleGreen;
                    break;

                case "average":
                    result = (number1 + number2) / 2;
                    this.BackColor = Color.PaleVioletRed;
                    break;

                case "-":
                    result = number1 - number2;
                    this.BackColor = Color.YellowGreen;
                    break;

                case "*":
                    result = number1 * number2;
                    this.BackColor = Color.LightGray;
                    break;

                case "/":

                    if (number2 == 0)
                        MessageBox.Show("You cannot divide by 0!!!");
                    else
                        result = number1 / number2;
                    this.BackColor = Color.LightPink;

                    break;

                default:
                    break;
            }

            showResult();
        }

        private void getNumbers()
        {
            number1 = Convert.ToDouble(firstNumberTextBox.Text);
            number2 = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void showResult()
        {
            resultTextBox.Text = result.ToString();
        }

        /// <summary>
        /// task 1.6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showSplashForm(object sender, EventArgs e)
        {
            SplashForm splash = new SplashForm();
            splash.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            splash.Close();
        }

        /// <summary>
        /// task 1.7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showExitSplashForm(object sender, EventArgs e)
        {
            FormQuit splash = new FormQuit();
            splash.ShowDialog();

            splash.Close();
        }

        //task 1.7
        private void clearbtn_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = "";
            secondNumberTextBox.Text = "";
            resultTextBox.Text = "";
        }
    }
}
