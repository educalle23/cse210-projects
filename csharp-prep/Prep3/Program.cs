using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int numberGuess = -1;

        while (numberGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());
                
            if (magicNumber > numberGuess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < numberGuess)
            {
                Console.WriteLine("Lower");
            }

            
            else
            {
                Console.WriteLine("Congrats, you guessed it!");
            }
        }
    }
}