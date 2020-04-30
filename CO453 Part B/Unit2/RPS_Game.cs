using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_Part_B
{
    public enum Players
    {
        COMPUTER,
        PLAYER
    }

    /// <summary>
    /// This class plays the RPS game
    /// Author: Godfrey
    /// Started: 12/02/2019
    /// </summary>
    public static class RPS_Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "STONE";
        public const string PAPER = "PAPER";

        public static string PlayerName { get; set; }
        public static string ComputerName { get; set; }
        public static string ComputerChoice { get; set; }
        public static string PlayerChoice { get; set; }
        public static string Winner { get; set; }

        public static int PlayerScore { get; set; }
        public static int ComputerScore { get; set; }

        private static Random randomGenerator = new Random();

        /// <summary>
        /// *******************************************************
        /// This method gives each player a name
        /// *******************************************************
        /// </summary>
        public static void Start()
        {
            PlayerScore = 0;
            ComputerScore = 0;

            PlayerName = "Godfrey";
            ComputerName = "Computer";
        }

        /// <summary>
        /// *******************************************************
        /// This method works out a winner
        /// *******************************************************
        /// </summary>
        public static void End()
        {
            if (PlayerScore > ComputerScore)
                Winner = PlayerName;
            else if (PlayerScore < ComputerScore)
                Winner = ComputerName;
            else
                Winner = "IT IS A DRAW";

        }

        /// <summary>
        /// *******************************************************
        /// This method gives the computer a random choice between
        /// rock, paper and stone
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = SCISSORS;
            }
            else if (choice == 1)
            {
                ComputerChoice = PAPER;
            }
            else if (choice == 2)
            {
                ComputerChoice = STONE;
            }
        }


        /// <summary>
        /// *******************************************************
        /// This method is used to find out the winner of the match
        /// and increment the scores accordinggly
        /// *******************************************************
        /// </summary>
        public static void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "No Winner";
            }
            else if ((PlayerChoice == STONE && ComputerChoice == PAPER) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == STONE) ||
                    (PlayerChoice == PAPER && ComputerChoice == SCISSORS))
            {
                Winner = ComputerName;
                ComputerScore++;
            }
            else if ((PlayerChoice == STONE && ComputerChoice == SCISSORS) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == PAPER) ||
                    (PlayerChoice == PAPER && ComputerChoice == STONE))
            {
                Winner = PlayerName;
                PlayerScore++;
            }
        }
    }
}
