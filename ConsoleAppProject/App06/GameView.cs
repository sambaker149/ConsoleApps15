using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App06
{
    /// <summary>
    /// This class will create a user interface for the
    /// Rock-Paper-Scissors game using the windows
    /// Console
    /// </summary>
    /// <author>
    /// Samuel Baker 16/05/2022
    /// </author>
    public class GameView
    {
        private Game game;

        /// <summary>
        /// This method will control the progress of the
        /// game from start to end.
        /// </summary>
        public void PlayGame()
        {
            bool wantToQuit = true;

            do
            {
                StartGame();

                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);

                game.MakeComputerChoice();
                DisplayChoice(GameChoices.Scissors);

                game.ScoreRound();

                if(game.Round == game.LastRound)
                {

                }
            } while (!wantToQuit);
        }

        private void DisplayChoice(GameChoices choice)
        {
            if(choice == GameChoices.Scissors)
            {
                GameImages.DrawScissors(10, 10);
            }
        }

        /// <summary>
        /// Reset a game so that the scores reset to zero
        /// for both players and the number of rounds is set.
        /// </summary>
        public void StartGame()
        {
            SetupConsole();

            ConsoleHelper.OutputHeading("  Rock-Paper-Scissors Game");

            if (game == null)
            {
                Console.Write(" Please enter your Name > ");
                string name = Console.ReadLine();

                game = new Game("Sam");
            }

            game.Start();
        }


        private void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
        }

        /// <summary>
        /// Repeatedly ask the player to make a choice
        /// and then ask the computer to make a choice.
        /// The choices are then compared and scored
        /// </summary>
        public void GetPlayerChoice()
        {

        }

        public void ShowComputerChoice()
        {
            switch (game.Computer.Choice)
            {
                case GameChoices.Rock:
                    GameImages.DrawRock(5, 8); 
                    break;

                case GameChoices.Paper:
                    GameImages.DrawPaper(5, 8); 
                    break;

                case GameChoices.Scissors:
                    GameImages.DrawScissors(5, 8); 
                    break;
            }
        }

        public void ShowRoundScores()
        {
            Console.WriteLine(" ");
        }

        public void ShowWinner()
        {

        }
        /// <summary>
        /// One player or more players have reached the chosen 
        /// maximum score and the winner can be decided.
        /// </summary>
        public void EndGame()
        {

        }
    }
}