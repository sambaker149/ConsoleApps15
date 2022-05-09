namespace ConsoleAppProject.App06
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; set; }
        public GamePlayer PlayerType { get; }
        public GameChoice Choice { get; set; }
        
        public Player(string name, GamePlayer playerType)
        {
            this.Name = name;
            this.PlayerType = playerType;
            Score = 0;
            Choice = GameChoice.None;
        }
    }
}
