namespace Tennis
{
    internal class FinalPointsTextGenerator : IScoreTextGenerator
    {
        private Score score1;
        private Score score2;

        public FinalPointsTextGenerator(Score score1, Score score2)
        {
            this.score1 = score1;
            this.score2 = score2;
        }

        public string GetScore()
        {
            string score;
            var minusResult = score1.GetValue() - score2.GetValue();
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }
    }
}