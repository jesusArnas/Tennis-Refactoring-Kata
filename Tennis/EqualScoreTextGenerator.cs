namespace Tennis
{
    internal class EqualScoreTextGenerator : IScoreTextGenerator
    {
        private Score score;

        public EqualScoreTextGenerator(Score score)
        {
            this.score = score;
        }

        public string GetScore()
        {
            if (score.GetValue() == 0)
            {
                return "Love-All";
            }

            if (score.GetValue() == 1)
            {
                return "Fifteen-All";
            }

            if (score.GetValue() == 2)
            {
                return "Thirty-All";
            }

            return "Deuce";
        }
    }
}