using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App06;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestRPSGame
    {
        private Game game = new Game("Sam");

        [TestMethod]
        public void TestGameStart()
        {
            game.Start();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(1, game.Round);

            Assert.AreEqual(GamePlayers.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual("Sam", game.Human.Name);
            Assert.AreEqual("Computer", game.Computer.Name);
        }

        [TestMethod]
        public void TestComputerChoiceIsRandom()
        {
            int[] choices = new int[4];

            game.Start();

            for(int i = 0; i < 10000; i++)
            {
                game.MakeComputerChoice();
                int choiceNo = (int)game.Computer.Choice;
                choices[choiceNo]++;
            }

            Assert.IsTrue(choices[0] == 0);
            Assert.IsTrue(choices[1] > 3000);
            Assert.IsTrue(choices[2] > 3000);
            Assert.IsTrue(choices[3] > 3000);
        }

        [TestMethod]
        public void TestScoreRoundRockPaper()
        {
            game.Start();

            game.Human.Choice = GameChoices.Rock;
            game.Computer.Choice = GameChoices.Paper;

            game.ScoreRound();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual("Computer", game.Winner.Name);
        }

        [TestMethod]
        public void TestScoreRoundRockScissors()
        {
            game.Start();

            game.Human.Choice = GameChoices.Rock;
            game.Computer.Choice = GameChoices.Scissors;

            game.ScoreRound();

            Assert.AreEqual(2, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual("Sam", game.Winner.Name);
        }

        [TestMethod]
        public void TestScoreRoundPaperRock()
        {
            game.Start();

            game.Human.Choice = GameChoices.Paper;
            game.Computer.Choice = GameChoices.Rock;

            game.ScoreRound();

            Assert.AreEqual(2, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual("Sam", game.Winner.Name);
        }

        [TestMethod]
        public void TestScoreRoundPaperScissors()
        {
            game.Start();

            game.Human.Choice = GameChoices.Paper;
            game.Computer.Choice = GameChoices.Scissors;

            game.ScoreRound();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual("Computer", game.Winner.Name);
        }

        [TestMethod]
        public void TestScoreRoundScissorsRock()
        {
            game.Start();

            game.Human.Choice = GameChoices.Scissors;
            game.Computer.Choice = GameChoices.Rock;

            game.ScoreRound();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(2, game.Computer.Score);
            Assert.AreEqual("Computer", game.Winner.Name);
        }

        [TestMethod]
        public void TestScoreRoundScissorsPaper()
        {
            game.Start();

            game.Human.Choice = GameChoices.Scissors;
            game.Computer.Choice = GameChoices.Paper;

            game.ScoreRound();

            Assert.AreEqual(2, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual("Sam", game.Winner.Name);
        }
    }
}
