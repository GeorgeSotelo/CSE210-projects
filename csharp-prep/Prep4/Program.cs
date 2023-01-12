using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int enterNumber = -1;
        while (enterNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            string userNum = Console.ReadLine();
            enterNumber = int.Parse(userNum);

            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);

            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");
        
        float avg = ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg} ");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max} ");
        
       



    }
}