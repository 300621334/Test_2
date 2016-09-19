using System;


/*
 * =========================      Test #2 Winter 2016      =========================
 * 
 * Name:SHAFIQ-UR-REHMAN
 * Student ID:300621334
 *
 * Question 5b.
 * 14 Marks.
 *
 * Write a program that displays the pattern show in the sample executable.
 * 
 * Type of loop-> your favorite (your must use a pair of nested loops)
 * Hints:
 *  1) Use counters that increments
 *  2) For columns use values between 61 and 76
 *  3) For row use values between 16 and 21
 *  4) Start with a vertical line of "*" then repeat it as necessary (use the % operator)
 *  5) Again start with a horizontal line of "*" then repeat it as necessary 
 *     (use the % operator)
 *  6) Now combine the two above conditions
 *  
 * [Solution: Question5B]
-------------------------------------------------------------------------------- */

namespace Question5B
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols, rows;
            Console.Write("Number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row % 5 == 0)
                    {
                        Console.Write("+");
                    }
                    if (col % 5 == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    //Console.Write("{0}{1} ", row, col);


                }
                Console.WriteLine();
            }
        }
    }
}