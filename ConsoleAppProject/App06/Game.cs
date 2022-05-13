﻿using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App06
{
    /// <summary>
    /// 
    /// </summary>
    public class Game
    {
        public const int MAXIMUM_ROUND = 10;
        public int Round { get; set; }
        public int LastRound { get; set; }
        public Player Human { get; }
        public Player Computer { get; }
        public Player CurrentPlayer { get; set; }
        public Player Winner { get; set; }
        private Random generator = new Random(55);

        public Game(string name)
        {
            Human = new Player(name, GamePlayer.Player);
            Computer = new Player("Computer", GamePlayer.Computer);

            Round = 0;
        }
         
        public void Start()
        {
            Round = 1;
            LastRound = 5;

            CurrentPlayer = Human;

            Human.Score = 0;
            Computer.Score = 0;

            SetLastRound();
        }

        public void SetLastRound()
        {
            Console.Write(" Please enter the Number of Rounds > ");
            LastRound = Console.ReadLine().Length;
        }
      
        /// <summary>
        /// 
        /// </summary>
        public void MakeComputerChoice()
        {
            int choice = generator.Next(1, 4);

            switch (choice)
            {
                case 1: 
                    Computer.Choice = GameChoice.Rock; 
                    break;
                case 2: 
                    Computer.Choice = GameChoice.Paper; 
                    break;
                case 3: 
                    Computer.Choice = GameChoice.Scissors; 
                    break;

                default:
                    break;
            }
        }

        public void MakeHumanChoice()
        {
            string[] choices =
            {
                " Rock",
                " Paper",
                " Scissors"
            };

            Console.WriteLine(" Rock, Paper or Scissors? > ");
            Console.WriteLine();

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1:
                    Human.Choice = GameChoice.Rock;
                    break;
                case 2:
                    Human.Choice = GameChoice.Paper;
                    break;
                case 3:
                    Human.Choice = GameChoice.Scissors;
                    break;

                default:
                    break;
            }
        }

        public void ScoreRound()
        {
            if (Human.Choice == GameChoice.Rock &&
               Computer.Choice == GameChoice.Paper)
            {
                Computer.Score += 2;
                Winner = Computer;
            }

            else if (Human.Choice == GameChoice.Rock &&
               Computer.Choice == GameChoice.Scissors)
            {
                Human.Score += 2;
                Winner = Human;
            }

            else if (Human.Choice == GameChoice.Paper &&
               Computer.Choice == GameChoice.Rock)
            {
                Human.Score += 2;
                Winner = Human;
            }

            else if (Human.Choice == GameChoice.Paper &&
               Computer.Choice == GameChoice.Scissors)
            {
                Computer.Score += 2;
                Winner = Computer;
            }

            else if (Human.Choice == GameChoice.Scissors &&
               Computer.Choice == GameChoice.Rock)
            {
                Computer.Score += 2;
                Winner = Computer;
            }

            else if (Human.Choice == GameChoice.Scissors &&
               Computer.Choice == GameChoice.Paper)
            {
                Human.Score += 2;
                Winner = Human;
            }

            else if (Human.Choice == Computer.Choice)
            {
                Human.Score += 1;
                Computer.Score += 1;
            }

            if (Round < LastRound)
            {
                Console.WriteLine(" Your score is " +
                    Human.Score);
                Console.WriteLine(" The Computer's Score is " +
                    Computer.Score);
                Round++;
            }
            else End();
        }

        public void End()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
            }
            else Winner = null;
        }
    }
}