using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacDeneme
{
    public class Scores
    {
        private static Scores instance = null;
        
        public static int scoreX { get; set; }

        public static int scoreO { get; set; }

        public static int scoreT { get; set; }

        private Scores()
        {
            ResetScores();
        }

        public static Scores Instance
        {
            get
            {
                if (instance == null) instance = new Scores();
                return instance;
            }
        }

        public void ScoreUp(string winner)
        {
            if (winner == "X")
                scoreX++;
            else if (winner == "O")
                scoreO++;
            else
                scoreT++;
        }

        public void ResetScores()
        {
            scoreX = 0;
            scoreO = 0;
            scoreT = 0;
        }

        public int ScoreX()
        { return scoreX; }

        public int ScoreO()
        { return scoreO; }

        public int ScoreT()
        { return scoreT; }

    }
}
