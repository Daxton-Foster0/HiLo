using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    public class Director
    {
        Card card = new Card();
        bool isPlaying = true;
        int totalScore = 300;
        bool isStarting = true;
        string inputhilo = "REALLY?";
        public Director()
        {
            Card card = new Card();
        }
        public void StartGame()
        {
            StartingStuff();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInputs()
        {
            card.iscorrect = false;
            card.isincorrect = false;
            if (!isStarting)
            {
                Console.Write("Play again? [y/n] ");
                string rollDice = Console.ReadLine();
                isPlaying = (rollDice == "y");
            }
            else
            {
                isStarting = false;
            }
            Console.Write($"The card is {card.value} ");
            if (isPlaying == true)
            {
                Console.Write("Higher of Lower? [h/l] ");
                inputhilo = Console.ReadLine();
            }
        }
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            int oldcard = card.value;
            card.Draw();
            if (inputhilo == "h" && (card.value > oldcard))
            {
                card.iscorrect = true;
            }
            else if (inputhilo == "l" && (card.value < oldcard))
            {
                card.iscorrect = true;
            }
            else
            {
                card.isincorrect = true;
            }
            card.Points();
            totalScore += card.points;
        }
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            string values = "";
            values += $"{card.value} ";
            Console.WriteLine($"Next card was {values}");
            Console.WriteLine($"Your score is: {totalScore}\n");
            isPlaying = (totalScore > 0);
        }
        public void StartingStuff()
        {
            card.Draw();
            isStarting = true;
        }
    }
}