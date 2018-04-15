namespace Tennis
{
    class ScoreTextGeneratorFactory
    {
        private readonly Score score1;
        private readonly Score score2;

        public ScoreTextGeneratorFactory(Score score1, Score score2)
        {
            this.score1 = score1;
            this.score2 = score2;
        }

        public IScoreTextGenerator GetScoreTextGenerator()
        {
            if (IsEqualScore())
            {
                return new EqualScoreTextGenerator(score1);
            }

            if (IsWinOrAdvantageScore())
            {
                return new FinalPointsTextGenerator(score1, score2);
            }

            return new InitialPointsTextGenerator(score1, score2);
        }

        private bool IsEqualScore()
        {
            return score1.GetValue() == score2.GetValue();
        }

        private bool IsWinOrAdvantageScore()
        {
            return score1.GetValue() >= 4 || score2.GetValue() >= 4;
        }

    }
}
