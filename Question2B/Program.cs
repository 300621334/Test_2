using System;
/*
 * =========================      Test #2 Winter 2016      =========================
 * 
 * Name:SHAFIQ-UR-REHMAN
 * Student ID:300621334
 *
 * Question 2b.
 * 10 Marks.
 *
 * Write a program that displays a conversion table of gram to ounces. The program
 * prompts the user for the end g and the start g value. The table must be in 
 * 10g decrements. You must match the format exactly.
 * 
 * Type of loop-> for
 * 1 g = 0.035 ounce
 * [Solution: Question2B]
 -------------------------------------------------------------------------------- */

namespace Question2B
{
    class Program
    {
        static void Main(string[] args)
        {
            double start, end, ounce;
            Console.Write("Enter end value: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter start value: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("gram      ounce");
            for (; start < end; end = end - 10)
            {
                ounce = end * 0.035;
                Console.WriteLine("{0, 3}       {1, 5:f3}", end, ounce);
            }
        }
    }
}
