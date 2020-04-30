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
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// This class is responsible for the different splash screens
        /// at the start and the end of the game
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();

        }

        /// <summary>
        /// shows a winning splash screen and a custom message
        /// </summary>
        public void Winner()
        {
            this.BackgroundImage = global::CO453_Part_B.Properties.Resources.win;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            label1.Text = "You have Won";

        }
        /// <summary>
        /// shows a losing splash screen and a custom message
        /// </summary>
        public void Loser()
        {
            this.BackgroundImage = global::CO453_Part_B.Properties.Resources.lose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            label1.Text = "You have Lost";

        }
        /// <summary>
        /// shows a draw splash screen and a custom message
        /// </summary>
        public void Draw()
        {
            this.BackgroundImage = global::CO453_Part_B.Properties.Resources.draw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            label1.Text = "You have Drawn";

        }


    }
}
