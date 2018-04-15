namespace Tennis
{
    class ScoreTextGeneratorFactory
    {
        private readonly Player player1;
        private readonly Player player2;

        public ScoreTextGeneratorFactory(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public IScoreTextGenerator GetScoreTextGenerator()
        {
            if (IsEqualScore())
            {
                return new EqualScoreTextGenerator(player1);
            }

            if (IsWinOrAdvantageScore())
            {
                return new FinalPointsTextGenerator(player1, player2);
            }

            return new InitialPointsTextGenerator(player1, player2);
        }

        private bool IsEqualScore()
        {
            return player1.IsEqualScore(player2);
        }

        private bool IsWinOrAdvantageScore()
        {
            return player1.IsWinOrAdvantageScore() || player2.IsWinOrAdvantageScore();
        }

    }
}
