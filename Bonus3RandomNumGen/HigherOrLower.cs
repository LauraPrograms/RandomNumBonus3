using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3RandomNumGen
{
    class HigherOrLower
    {
        public int randomNum;
        private Random random;
        public List<int> GameResults;
        public HigherOrLower(Random random)
        {
            randomNum = 0;
            this.random = random;
            this.GameResults = new List<int>();
        }

        public void Game()
        {
            int attempts = 0;
            int min = 1;
            int max = 101;
            GuessValidator gv = new GuessValidator(randomNum);
            bool run = true;
            while (run)
            {
                int guess = random.Next(min, max);

                int result = gv.Guesses(guess, false);
                if (result == 0)
                {
                    run = false;
                }
                else if (result == 1)
                {
                    max = guess;
                }
                else if (result ==-1)
                {
                    min = guess+1;//min is not exclusive like the max
                }
                attempts++;
            }
            GameResults.Add(attempts);

        }

    }
}
