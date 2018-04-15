namespace Tennis
{
    internal class InitialPointsTextGenerator : IScoreTextGenerator
    {
        private Score score1;
        private Score score2;

        public InitialPointsTextGenerator(Score score1, Score score2)
        {
            this.score1 = score1;
            this.score2 = score2;
        }

        public string GetScore()
        {
            return GetScoreAsText(score1.GetValue()) + "-" + GetScoreAsText(score2.GetValue());
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