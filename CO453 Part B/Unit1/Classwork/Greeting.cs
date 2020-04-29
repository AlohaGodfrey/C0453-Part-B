using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_Part_B.Unit1.Classwork
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            lblBrag.Text = "Supa Dupa Computer\n Selling for £399";
            lblBrag.BackColor = Color.OrangeRed;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            lblBrag.Text = "C# .NET for Dumbos\n A real bargain at £29.99";
            lblBrag.BackColor = Color.Green;
        }
    }
}
