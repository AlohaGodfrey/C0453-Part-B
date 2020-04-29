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
    /// This class forms a user interface for the 
    /// Rock-Paper-Scissors Game
    /// Author: Godfrey
    /// </summary>
    public partial class GameUI : Form
    {
        public GameUI()
        {

            InitializeComponent();
            //RPS_Game game = new RPS_Game();
            RPS_Game.Start();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void loadRockImage(object sender, EventArgs e)
        {
            userPictureBox.Image = global::CO453_Part_B.Properties.Resources.Rock;
        }

        private void loadPaperImage(object sender, EventArgs e)
        {
            userPictureBox.Image = global::CO453_Part_B.Properties.Resources.Paper;
        }

        private void loadScissorsImage(object sender, EventArgs e)
        {
            userPictureBox.Image = global::CO453_Part_B.Properties.Resources.Scissors;
        }

        private void getPlayerChoice(object sender, EventArgs e)
        {

            if (rockRadioButton.Checked)
            {
                RPS_Game.PlayerChoice = RPS_Game.STONE;
            }
            else if (paperRadioButton.Checked)
            {
                RPS_Game.PlayerChoice = RPS_Game.PAPER;
            }
            else if (scissorsRadioButton.Checked)
            {
                RPS_Game.PlayerChoice = RPS_Game.SCISSORS;
            }

            if (!choiceMade())
            {
                MessageBox.Show("Please make a selection!");
            }
            else
            {
                getComputerChoice();
            }

        }

        private void clear()
        {
            paperRadioButton.Checked = false;
            scissorsRadioButton.Checked = false;
            rockRadioButton.Checked = false;
        }

        private bool choiceMade()
        {
            return (paperRadioButton.Checked ||
                    scissorsRadioButton.Checked ||
                    rockRadioButton.Checked);
        }

        private void getComputerChoice()
        {
            RPS_Game.GetComputerChoice();

            if (RPS_Game.ComputerChoice == RPS_Game.PAPER)
                computerPictureBox.Image = global::CO453_Part_B.Properties.Resources.Paper;

            else if (RPS_Game.ComputerChoice == RPS_Game.STONE)
                computerPictureBox.Image = global::CO453_Part_B.Properties.Resources.Rock;

            else if (RPS_Game.ComputerChoice == RPS_Game.SCISSORS)
                computerPictureBox.Image = global::CO453_Part_B.Properties.Resources.Scissors;

            RPS_Game.WorkoutWinner();
            showWinner();
        }

        private void showWinner()
        {
            string message = "You chose " + RPS_Game.PlayerChoice;
            message = message + "\nComputer Chose " + RPS_Game.ComputerChoice;

            message = message + "\n\n The Winner is " + RPS_Game.Winner;

            messageLabel.Text = message;

            //updates the score visually
            lblComputerScore.Text = RPS_Game.ComputerScore.ToString();
            lblUserScore.Text = RPS_Game.PlayerScore.ToString();


            if (RPS_Game.ComputerScore > 19 || RPS_Game.PlayerScore > 19) { showExitSplashForm(); }


            clear();
        }


        private void showSplashForm(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            splash.Close();
        }

        private void showExitSplashForm()
        {
            SplashScreen exitsplash = new SplashScreen();

            if (RPS_Game.ComputerScore > RPS_Game.PlayerScore)
            {
                exitsplash.Loser();
            }
            else if (RPS_Game.ComputerScore < RPS_Game.PlayerScore)
            {
                exitsplash.Winner();
            }
            else
            {
                exitsplash.Draw();
            }

            exitsplash.ShowDialog();
            this.Close();

        }

    }
}
