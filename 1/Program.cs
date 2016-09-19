using System;
/*
 * =========================      Test #2 Winter 2016      =========================
 * 
 * Name:SHAFIQ-UR-REHMAN
 * Student ID: 300621334
 *
 * Question 1b.
 * 10 Marks.
 *
 * Write a program that adds the user input to reach a target. When the sum reaches 
 * just exceeds the target, the program prints the final sum and the  number of user
 * inputs required
 * 
 * Type of loop-> do-while
 * [Solution: Question1B]
 -------------------------------------------------------------------------------- */

namespace _Question1B
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1, num = 0, target, sum = 0;
            Console.Write("Enter target value: ");
            target = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Enter#{0}: ", counter);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                counter++;
            }
            while (sum < target);
            Console.WriteLine("It took {0} inputs to take the sum to {1}.", counter-1, sum);
        }
    }
}
