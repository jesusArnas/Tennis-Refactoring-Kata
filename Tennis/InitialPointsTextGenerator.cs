namespace Tennis
{
    internal class InitialPointsTextGenerator : PointsTextGenerator, IScoreTextGenerator
    {
        private const string Forty = "Forty";

        private Player player1;
        private Player player2;

        public InitialPointsTextGenerator(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public string GetScore()
        {
            return GetScoreAsText(player1) + Separator + GetScoreAsText(player2);
        }

        private string GetScoreAsText(Player player)
        {
            int score = player.GetScore();
            if (score < 3)
                return GetDefaultTextForScore(score);

            return Forty;
        }
    }
}