using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Number
    {
        public bool Guessed { get; private set; }
        public int Attempts { get; set; }
        public double DifficultyMultiplier { get; private set; }
        public string Difficulty { get; private set; }
        private decimal[] solution;
        private Random rand;
        public Number(string difficulty)
        {
            if (string.IsNullOrEmpty(difficulty))
            {
                throw new ArgumentNullException();
            }
            Difficulty = difficulty;
            Guessed = false;
            solution = new decimal[4];
            rand = new Random();
            SetDifficultyMultiplierAndAttempts();
            GenerateSolution();
        }

        private void GenerateSolution()
        {
            int i = 0;
            while (i < 4)
            {
                decimal nr = rand.Next(1,10);
                if (!solution.Contains(nr))
                {
                    solution[i] = nr;
                    i++;
                }
            }
        }

        public string check(decimal[] guess)
        {
            if (guess == null)
            {
                throw new ArgumentNullException();
            }

            string result = "";
            int Xs = 0;
            int Os = 0;
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == solution[i])
                {
                    Xs++;
                }

                else if (solution.Contains(guess[i]))
                {
                    Os++;
                }
            }

            for (int x = 0; x < Xs; x++)
            {
                result += "X";
            }

            for (int y = 0; y < Os; y++)
            {
                result += "O";
            }

            if (Xs == 4)
            {
                Guessed = true;
            }
            return result;
        }

        private void SetDifficultyMultiplierAndAttempts()
        {
            var dif = Difficulty.Remove(Difficulty.IndexOf(','));
            switch (dif)
            {
                case "Easy":
                    Attempts = 8;
                    DifficultyMultiplier = 1;
                break;

                case "Normal":
                    Attempts = 7;
                    DifficultyMultiplier = 1.5;
                break;

                case "Hard":
                    Attempts = 5;
                    DifficultyMultiplier = 2;
                break;

                case "Impossible":
                    Attempts = 4;
                    DifficultyMultiplier = 3;
                break;
            }
        }
    }
}
