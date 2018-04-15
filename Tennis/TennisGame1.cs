namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private Player player1;
        private Player player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name);
            this.player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            Player player = GetPlayerForName(playerName);
            player.IncreaseScore();
        }

        public string GetScore()
        {
            return new ScoreTextGeneratorFactory(player1, player2).GetScoreTextGenerator().GetScore();
        }
       
        private Player GetPlayerForName(string playerName)
        {
            if (playerName == player1.GetPlayerName())
                return player1;

            return player2;
        }
    }
}

