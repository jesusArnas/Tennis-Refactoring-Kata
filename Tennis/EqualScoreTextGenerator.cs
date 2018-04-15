namespace Tennis
{
    internal class EqualScoreTextGenerator : IScoreTextGenerator
    {
        private Player player;

        public EqualScoreTextGenerator(Player player)
        {
            this.player = player;
        }

        public string GetScore()
        {
            int score = player.GetScore();
            if (score == 0)
            {
                return "Love-All";
            }

            if (score == 1)
            {
                return "Fifteen-All";
            }

            if (score == 2)
            {
                return "Thirty-All";
            }

            return "Deuce";
        }
    }
}