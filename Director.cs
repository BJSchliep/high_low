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
        int totalScore = 0;

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
            Random random = new Random();
            Console.WriteLine($"The card is: {random}");
            Console.WriteLine("Higher or Lower? [h/l] ");
            string guess = Console.ReadLine();
        }

        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }

            int score = 300;
            // Call Method
            totalScore += score;

        }

        public void DoOutputs()
        {

        }

    }
}