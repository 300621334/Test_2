using System;

/*
 * =========================      Test #2 Winter 2016      =========================
 * 
 * Name:SHAFIQ-UR-REHMAN
 * Student ID:300621334
 *
 * Question 3b.
 * 8 Marks.
 *
 * Write a program that prints multiples of 7 in ascending order on a single line.
 * The program prompts the user for the end value. 
 * 
 * Type of loop-> while
 * [Solution: Question3B]
 -------------------------------------------------------------------------------- */

namespace Question3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int end, start = 1;
            Console.Write("Enter end value: ");
            end = Convert.ToInt32(Console.ReadLine());

            while (start <= end)
            {
                if (start % 7 == 0)
                {
                    Console.Write("{0} ", start);
                }
                start++;
            }
        }
    }
}
