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
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hi " + textFname.Text + " " + txtSname.Text + ",\nfrom " + textTown.Text + ",\nHappy Programming.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            lblMessage.Text = lblMessage.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            lblMessage.Text = lblMessage.Text.ToLower();
        }

        private void btnChangeMessage_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            textFname.BackColor = Color.LightBlue;
            txtSname.BackColor = Color.LightBlue;
            lblMessage.Text = lblMessage.Text + "\nGet on with it " + textFname.Text;
        }


    }
}
