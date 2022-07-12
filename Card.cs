using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cards
{
    public class Card
    {
        public int value = 0;
        public int points = 300;

        // Creates a new instance of the Card
        public Card()
        {
            Random random = new Random();
            // Returns a value between 1-14
            value = random.Next(1, 14);
        }

        public int CompareTo(Card other, string guess)
        {

            int score = 0;

            if (value > other.value && guess == "h") 
            {
                score = 100;
            } 
            else if (value < other.value && guess == "l") 
            {
                score = 100;
            } 
            else 
            {
                score = -75;
            }
            return score;

        }
    }
}