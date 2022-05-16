using System;


namespace Unit02.Game
{
    public class Card
    {
        public int value = 0;
        public int points = 0;
        public bool iscorrect = false;
        public bool isincorrect = false;
        public Card()
        {
        }
        public void Draw()
        {
        Random randomGenerator = new Random();
        value = randomGenerator.Next(1,14);
        }
        public void Points()
        {
        if (iscorrect == true)
        {
            points = 100;
        }
        else if (isincorrect == true)
        {
            points = -150;
        }
        else
        {
            points = 0;
            Console.WriteLine("FIX IT!");
        }
        }
    }
}