﻿namespace Tennis
{
    internal class FinalPointsTextGenerator : IScoreTextGenerator
    {
        private const string Advantage = "Advantage";
        private const string WinFor = "Win for";

        private Player player1;
        private Player player2;

        public FinalPointsTextGenerator(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public string GetScore()
        {
            var minusResult = this.player1.GetScore() - this.player2.GetScore();

            if (minusResult == 1)
            {
                return Advantage + " " + player1.GetPlayerName();
            }

            if (minusResult == -1)
            {
                return Advantage + " " + player2.GetPlayerName();
            }

            if (minusResult >= 2)
            {
                return WinFor + " " + player1.GetPlayerName();
            }

            return WinFor + " " + player2.GetPlayerName();
        }
    }
}