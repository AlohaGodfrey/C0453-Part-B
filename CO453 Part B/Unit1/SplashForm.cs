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
    public partial class SplashForm : Form
    {
        /// <summary>
        /// This application shows a splashform upon starting the application.
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
