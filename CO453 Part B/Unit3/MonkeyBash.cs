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
    /// <summary>
    /// Task 3.5
    /// This form moves a monkey image around and displays a message when
    /// the monkey image is clicked
    /// Author: Godfrey
    /// </summary>
    public partial class MonkeyBash : Form
    {
        private int x, y;

        private int hits, misses;

        private Random generator = new Random();



        public MonkeyBash()
        {
            InitializeComponent();
        }
        /// <summary>
        /// closes the forum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// increments upon a succesful hit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            hits = hits + 1;
        }
        /// <summary>
        /// starts the timers that update each bullseye target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startTimer(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            hits = 0; misses = 0;
        }
        /// <summary>
        /// disables the timer that update each bullseye target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopTimer(object sender, EventArgs e)
        {
            animationTimer.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
           
        }

        /// <summary>
        /// debugging information that gives the coordinates of 
        /// each mouseDown location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonkeyBash_MouseDown(object sender, MouseEventArgs e)
        {
            messageLabel.Text = "(" + e.X + "," + e.Y + ")";
        }
        /// <summary>
        /// incrementes the misses counter if the user misses the
        /// bullseye target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gamePanel_Click(object sender, EventArgs e)
        {
            misses = misses + 1;
        }
        /// <summary>
        /// calculates how accurate the user is, using the mouseDown location
        /// and comparing it to the target. The score is deducted from 100 meaning
        /// the higher the score the higher the accuracy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            double a, b;


            //messageLabel.Text = "(" + e.X + "," + e.Y + ")";


            a = Math.Pow((e.X - 50), 2);
            b = Math.Pow((e.Y - 50), 2);
            lblResult.Text = "You Score: " + (100 - Math.Sqrt(a + b)).ToString("0.00");

        }

        private void MonkeyBash_Click(object sender, EventArgs e)
        {
            misses++;
        }

        /// <summary>
        /// Moves the bullseye sprite whenever the timer updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveMonkey(object sender, EventArgs e)
        {

            x = generator.Next(gamePanel.Width - imagePictureBox.Width);
            y = generator.Next(gamePanel.Height - imagePictureBox.Height);

            imagePictureBox.Left = x;
            imagePictureBox.Top = y;

            hitsLabel.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }
        /// <summary>
        /// Moves the bullseye sprite whenever the timer updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveBull1(object sender, EventArgs e)
        {

            x = generator.Next(gamePanel.Width - imagePictureBox.Width);
            y = generator.Next(gamePanel.Height - imagePictureBox.Height);

            bull1.Left = x;
            bull1.Top = y;

            hitsLabel.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void moveBull2(object sender, EventArgs e)
        {

            x = generator.Next(gamePanel.Width - imagePictureBox.Width);
            y = generator.Next(gamePanel.Height - imagePictureBox.Height);

            bull2.Left = x;
            bull2.Top = y;

            hitsLabel.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void moveBull3(object sender, EventArgs e)
        {

            x = generator.Next(gamePanel.Width - imagePictureBox.Width);
            y = generator.Next(gamePanel.Height - imagePictureBox.Height);

            bull3.Left = x;
            bull3.Top = y;

            hitsLabel.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }
    }
}
