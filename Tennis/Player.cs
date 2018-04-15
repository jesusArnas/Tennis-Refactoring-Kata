using System;

namespace Tennis
{
    public class Player
    {
        private readonly string playerName;
        private readonly Score score;

        public Player(string playerName)
        {
            this.playerName = playerName;
            this.score = new Score();
        }

        public void IncreaseScore()
        {
            this.score.IncreaseScore();
        }

        public string GetPlayerName()
        {
            return playerName;
        }

        internal int GetScore()
        {
            return score.GetValue();
        }

        internal bool IsEqualScore(Player player2)
        {
            return score.GetValue() == player2.GetScore();
        }

        internal bool IsWinOrAdvantageScore()
        {
            return score.GetValue() >= 4;
        }
    }
}
