namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        enum prueba {a, b, c }

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (IsPlayer1Turn(playerName))
                m_score1 += 1;
            else 
                m_score2 += 1;
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
            int tempScore;
            string score = "";

            for (var i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = m_score1;
                else { score += "-"; tempScore = m_score2; }

                score += GetTextForScore(tempScore);
            }

            return score;
        }

        private static string GetTextForScore(int score)
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
            var minusResult = m_score1 - m_score2;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        private string GetEqualsScore()
        {
            string score;
            switch (m_score1)
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
            return playerName == "player1";
        }

        private bool IsEqualScore()
        {
            return m_score1 == m_score2;
        }

        private bool IsWinOrAdvantageScore()
        {
            return m_score1 >= 4 || m_score2 >= 4;
        }
    }
}

