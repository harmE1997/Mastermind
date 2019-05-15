using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Player
    {
        public string Name { get; private set; }
        public double Score { get; private set; }
        public int NrVictories { get; set; }
        public Player(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
            Score = 0;
            Name = name;
            NrVictories = 0;
        }

        public void calculateScore(double attemptsleft, double difficultyMultiplier)
        {
            if ((attemptsleft < 0) || (difficultyMultiplier < 1))
            {
                throw new ArgumentOutOfRangeException();
            }

            Score = Score + ((100 + (attemptsleft * 50)) * difficultyMultiplier * NrVictories);
        }

        public override string ToString()
        {
            string info = Name + ", Score: " + Score.ToString() + ", WinStreak: " + NrVictories.ToString();
            return info; 
        }
    }
}
