using System;

class Program
{
    static void Main(string[] args)
 
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int gnumber = -1;
        while (gnumber != number)

        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            gnumber = int.Parse(guess);

            if (gnumber > number)
            {
                Console.WriteLine("Lower");
        
            }
            else if (gnumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }    
    }
}