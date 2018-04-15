namespace Tennis
{
    internal class InitialPointsTextGenerator : IScoreTextGenerator
    {
        private Player player1;
        private Player player2;

        public InitialPointsTextGenerator(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public string GetScore()
        {
            return GetScoreAsText(player1.GetScore()) + "-" + GetScoreAsText(player2.GetScore());
        }

        private string GetScoreAsText(int score)
        {
            if (score == 0)
            {
                return "Love";
            }

            if (score == 1)
            {
                return "Fifteen";
            }

            if (score == 2)
            {
                return "Thirty";
            }

            return "Forty";
        }
    }
}