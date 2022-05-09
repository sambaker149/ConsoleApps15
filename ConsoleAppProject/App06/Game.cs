using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App06
{
    public class Game
    {
        public const int MAX_ROUND = 10;

        public int Round { get; set; }
        public int LastRound { get; set; }
        public Player Human { get; }
        public Player Computer { get; }
        public Player CurrentPlayer { get; set;  }
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
        }

        public void MakeComputerChoice()
        {
            int choice = generator.Next(1,4);

            switch(choice)
            {
                case 1: Computer.Choice = GameChoice.Rock; 
                    break;
                case 2: Computer.Choice = GameChoice.Paper;
                    break;
                case 3: Computer.Choice = GameChoice.Scissors;
                    break;
            }
        }

        public void End()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bad Luck! You Have Lost The Game To The Computer.");
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You Have Won The Game.");
            }
            else Winner = null;
        }
    }
}
