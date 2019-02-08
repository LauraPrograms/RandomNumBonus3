using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3RandomNumGen
{
    class RandomGuesser
    {
        public int randomNum;
        private Random random;
        public List<int> GameResults;
        public RandomGuesser (Random random)
        {
            randomNum = 0;
            this.random = random;
            this.GameResults = new List<int>();
        }

        public void Game()
        {
            int attempts = 0;
            GuessValidator gv = new GuessValidator(randomNum);
            bool run = true;
            while (run)
            {
                int guess = random.Next(1, 101);

               int result = gv.Guesses(guess, false);
                if (result ==0)
                {
                    run = false;
                }
                attempts++;
            }
            GameResults.Add(attempts);
           
        }
        
    }
}
