using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App06
{
    public class Game
    {
        // Player Properties
        public Player Human { get; }
        public Player Computer { get; }
        public Player CurrentPlayer { get; set;  }
        public Player Winner { get; set; }

        
        // Game Properties
        public int LastRound { get; set; }
        public int Round { get; set; }
        public GamePlayer CurrentPlayer { get; set; }
        public string WinnerName { get; set; }

        // Computer Properties
        public int ComputerScore { get; set; }
        public GameChoice ComputerChoice { get; set; }

        // Constants
        public const int MAX_ROUND = 10;


    }
}
