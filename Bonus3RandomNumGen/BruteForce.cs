using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3RandomNumGen
{
    class BruteForce
    {
        public int randomNum;
        public List<int> GameResults;
        public BruteForce()
        {
            randomNum = 0;
            this.GameResults = new List<int>();
        }

        public void Game()
        {
            int attempts = 0;
            int guess = 100;
            GuessValidator gv = new GuessValidator(randomNum);
            bool run = true;
            while (run)
            {
                int result = gv.Guesses(guess, false);
                if (result == 0)
                {
                    run = false;
                }
                guess--;
                attempts++;
            }
                GameResults.Add(attempts);

        }
    }
}
