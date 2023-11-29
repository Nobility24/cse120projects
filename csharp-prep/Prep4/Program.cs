using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        //using a do-while loop
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter  a list of numbers, type 0 you you finished ");

            string userResponse = Console.ReadLine();
            userNumber =int.Parse(userResponse);

            //adding numbers to the list and quiting when 0 is typed
            if (userNumber != 0) 
            {
                numbers.Add(userNumber);
            }
        }

        // Computing the  sum 
        int sum = 0;
        foreach (int number in numbers)
        {
           sum += number; 
        }

        Console.WriteLine($"The sum is: {sum}");

        //Computing the average
        //Make one of the variables a float first so that the computer knows it has to do the floating
        //point division , to give us the decimal value expected
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is {average}");

        //Finding the max
        int max = numbers[0];

        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}");
    }
}