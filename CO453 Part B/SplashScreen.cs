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
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();

        }

        public void Winner()
        {
            this.BackgroundImage = global::CO453_Part_B.Properties.Resources.win;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            label1.Text = "You have Won";

        }

        public void Loser()
        {
            this.BackgroundImage = global::CO453_Part_B.Properties.Resources.lose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            label1.Text = "You have Lost";

        }

        public void Draw()
        {
            this.BackgroundImage = global::CO453_Part_B.Properties.Resources.draw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            label1.Text = "You have Drawn";

        }


    }
}
