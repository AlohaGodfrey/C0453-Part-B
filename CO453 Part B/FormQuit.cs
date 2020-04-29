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
    public partial class FormQuit : Form
    {
        public FormQuit()
        {
            InitializeComponent();
        }

        private void FormQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
