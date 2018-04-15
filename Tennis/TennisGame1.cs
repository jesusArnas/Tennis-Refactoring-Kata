namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private Score m_score1 = new Score();
        private Score m_score2 = new Score();
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (IsPlayer1Turn(playerName))
                m_score1.IncreaseScore();
            else
                m_score2.IncreaseScore();
        }

        public string GetScore()
        {
            return new ScoreTextGeneratorFactory(m_score1, m_score2).GetScoreTextGenerator().GetScore();
        }
       
        private bool IsPlayer1Turn(string playerName)
        {
            return playerName == this.player1Name;
        }
    }
}

