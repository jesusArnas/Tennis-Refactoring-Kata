namespace Tennis
{
    class PointsTextGenerator
    {
        protected const string Separator = "-";

        protected string GetDefaultTextForScore(int score)
        {
            if (score == 1)
            {
                return "Fifteen";
            }

            if (score == 2)
            {
                return "Thirty";
            }

            return "Love";
        }
    }
}
