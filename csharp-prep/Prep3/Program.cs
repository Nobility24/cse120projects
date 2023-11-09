using System;

class Program
{
    static void Main(string[] args)
    { 
        Random random = new Random();
        //Generating a random number
        int magicNumber = random.Next(1, 101); 
        int guess;
        guess = -1;

        //Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 101);

        //int guess = -1;
        
        Console.WriteLine("Welcome to The Guess My Number Game!");
        Console.WriteLine("Pick any number between 1 and 100 and see if you guessed right.");

        //Using a do-while loop
        
        {
            Console.WriteLine("Enter your guess ");
            

            if (magicNumber < guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Right guess, Congratulations!");
            }


        }

    
    }
}
