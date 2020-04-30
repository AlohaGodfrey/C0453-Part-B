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
    /// This class displays pictures depending from what is 
    /// selected in the listbox
    /// Author: Godfrey
    /// </summary>
    public partial class Build_a_Picture : Form
    {
        private string[] monsters = new string[]
         {
            "Godzilla",
            "Alien",
            "Monsters",
            "Nessie",
            "Pirate Spider",
            "King Kong",
         };

        public Build_a_Picture()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method checks what has been clicked and then displays correct image.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.pictureBox1.BackgroundImage = global::CO453_Part_B.Properties.Resources.Godzilla;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 1:
                    this.pictureBox1.BackgroundImage = global::CO453_Part_B.Properties.Resources.alien;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 2:
                    this.pictureBox1.BackgroundImage = global::CO453_Part_B.Properties.Resources.munsters;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 3:
                    this.pictureBox1.BackgroundImage = global::CO453_Part_B.Properties.Resources.Nessie;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 4:
                    this.pictureBox1.BackgroundImage = global::CO453_Part_B.Properties.Resources.Shadow;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 5:
                    this.pictureBox1.BackgroundImage = global::CO453_Part_B.Properties.Resources.king_kong;
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                default:
                    break;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}