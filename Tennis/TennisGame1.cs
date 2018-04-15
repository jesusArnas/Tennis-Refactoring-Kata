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
            if (IsEqualScore())
            {
                return GetEqualsScore();
            }

            if (IsWinOrAdvantageScore())
            {
                return GetWinOrAdvantageScore();
            }

            return GetRegularScore();
        }

        private string GetRegularScore()
        {
            return GetScoreAsText(m_score1.GetValue()) + "-" + GetScoreAsText(m_score2.GetValue());
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

        private string GetWinOrAdvantageScore()
        {
            string score;
            var minusResult = m_score1.GetValue() - m_score2.GetValue();
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        private string GetEqualsScore()
        {
            string score;
            switch (m_score1.GetValue())
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;
                case 2:
                    score = "Thirty-All";
                    break;
                default:
                    score = "Deuce";
                    break;

            }

            return score;
        }

        private bool IsPlayer1Turn(string playerName)
        {
            return playerName == this.player1Name;
        }

        private bool IsEqualScore()
        {
            return m_score1.GetValue() == m_score2.GetValue();
        }

        private bool IsWinOrAdvantageScore()
        {
            return m_score1.GetValue() >= 4 || m_score2.GetValue() >= 4;
        }
    }
}

