using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App06
{
    public class GameView
    {
        private Game game;

        /// <summary>
        /// Controls the sequence of events of each round of the game
        /// Repeats until the game is ended by the player
        /// </summary>
        public void Play()
        {
            bool wantToQuit = true;

            do
            {
                StartGame();

                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);

                game.MakeComputerChoice();
                DisplayChoice(game.Computer.Choice);

                game.ScoreRound();

                if (game.Round == game.LastRound)
                {
                    Console.WriteLine();
                    DisplayWinImage();
                }

            } while (!wantToQuit);
        }

        public void StartGame()
        {
            SetupConsole();

            ConsoleHelper.OutputHeading("  Rock-Paper-Scissors ");

            if (game == null)
            {
                Console.Write(" Please enter your name > ");
                string name = Console.ReadLine();

                game = new Game(name);
            }

            game.Start();
        }

        private void DisplayChoice(GameChoice choice)
        {
            if(choice == GameChoice.Rock)
            {
                GameImages.DrawRock(10, 10);
            }
            else if(choice == GameChoice.Paper)
            {
                GameImages.DrawPaper(10, 10);
            }
            else if (choice == GameChoice.Scissors)
            {
                GameImages.DrawScissors(10, 10);
            }
        }

        private void GetPlayerChoice()
        {
            game.MakeHumanChoice();
        }

        private void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
        }

        private void DisplayWinImage()
        {
            if(game.Winner == game.Human)
            {
                GameImages.DrawThumbsUp();
            }
            else if(game.Winner == game.Computer)
            {
                GameImages.DrawThumbsDown();
            }
        }
    }
}