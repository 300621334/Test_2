using System;
/*
 * =========================      Test #2 Winter 2016      =========================
 * 
 * Name:SHAFIQ-UR-REHMAN
 * Student ID:300621334
 *
 * Question 4b.
 * 12 Marks.
 *
 * Write a program that displays the table show in the sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = y = 2x^2 + x - 6
 *    
 * Type of loop-> your favorite (your MUST use a loop)
 * Hints:
 *  1) Generate the first column using a place holder (increment = 0.25)
 *  2) Generate the successive one at a time
 *  3) Format using column specifier (do not use tabs)
 *     
 * [Solution: Question4B]
-------------------------------------------------------------------------------- */

namespace Question4B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    X   2x^2      +x    -6      y");
            Console.WriteLine(" ----   ----    ----  ----   ----");

            double start = -2.50, end = 2.00, increment = 0.25, variableY = 0, constant = -6, square = 0;

            for (; start <= end; start += increment)
            {
                square = 2 * (start * start);
                variableY = square + start + constant;
                Console.WriteLine("{0,5:f}{1,7:f}{2,8:f}{3,6:f}{4,7:f}", start, square, start, constant, variableY);
            }
        }
    }
}
