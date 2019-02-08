using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3RandomNumGen
{
    class BinarySearch
    {
        public int randomNum;
        private Random random;
        public List<int> GameResults;
        public BinarySearch ()
        {
            randomNum = 0;            
            this.GameResults = new List<int>();
        }

        public void Game()
        {
            int attempts = 0;
            int min = 1;
            int max = 101;
            int guess = 50;
            GuessValidator gv = new GuessValidator(randomNum);
            bool run = true;
            while (run)
            {
               

                int result = gv.Guesses(guess, false);
                if (result == 0)
                {
                    run = false;
                }
                else if (result == 1)
                {
                    max = guess-1;
                }
                else if (result == -1)
                {
                    min = guess + 1;
                }
                guess = (min + max) / 2;
                attempts++;
            }
            GameResults.Add(attempts);

        }
    }
}
