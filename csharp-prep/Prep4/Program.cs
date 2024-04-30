using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            if (number !=0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int sumNumbers in numbers)
        {
            sum += sumNumbers;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is:{average}");
        
        int max = numbers[0];

        foreach (int numberList in numbers)
        {
            if (numberList > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = numberList;
            }
        }

        Console.WriteLine($"The max is: {max}");

        // numbers.Sort();
        // foreach (int numberSort in numbers);
        // Console.WriteLine($"{numbers}");
    }
    
}