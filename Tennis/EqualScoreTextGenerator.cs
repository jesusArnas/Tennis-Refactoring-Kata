namespace Tennis
{
    internal class EqualScoreTextGenerator : PointsTextGenerator, IScoreTextGenerator
    {
        private const string All = "All";
        private const string Deuce = "Deuce";

        private Player player;

        public EqualScoreTextGenerator(Player player)
        {
            this.player = player;
        }

        public string GetScore()
        {
            int score = player.GetScore();
            if (score < 3)
                return GetDefaultTextForScore(score) + Separator + All;

            return Deuce;
        }
    }
}