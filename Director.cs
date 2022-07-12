using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cards
{
    public class Director
    {
        bool isPlaying = true;
        int score = 300;
        Card card  = new Card();

        Card nextCard = new Card();
        string guess = "";
        public Director()
        {
            
        }

        public void StartGame()
        {
            while(isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            Console.WriteLine($"The card is: {card.value}");
            Console.WriteLine("Higher or Lower? [h/l] ");
            guess = Console.ReadLine();
        }

        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }

            nextCard = new Card();
            int points = nextCard.CompareTo(card, guess);
            score += points;

        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            Console.WriteLine($"Next card was: {nextCard.value}");
            Console.WriteLine($"Your score is {score} \n");
            

            // if ()
            // {

            // }
            card = nextCard;

        }

    }
}