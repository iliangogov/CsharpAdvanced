﻿using System;
using System.Linq;
namespace AddingPolynomials
{
    class Program
    {
        static void Main()
        {
            // input
            Console.ReadLine(); // additional number N ? 

            // polynomials as an array of their coefficients
            int[] PolynomialOne = Console.ReadLine()
                                  .Trim(' ')
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToArray();

            int[] PolynomialTwo = Console.ReadLine()
                                  .Split(' ')
                                  .Select(coefficient => int.Parse(coefficient))
                                  .ToArray();

            // Sum the two arrays
            int[] PolynomialSum = SumTheArrays(PolynomialOne, PolynomialTwo);

            // Output
            string toPrint = string.Join(" ", PolynomialSum);

            Console.WriteLine(toPrint);
        }

        public static int[] SumTheArrays(int[] ArrayA, int[] ArrayB)
        {
            // helpers
            int[] Result = new int[Math.Max(
                                ArrayA.Length,
                                ArrayB.Length)];
            var digitA = 0;
            var digitB = 0;

            for (int curDigit = 0;
                     curDigit < Math.Max(
                                ArrayA.Length,
                                ArrayB.Length);
                     curDigit++)
            {
                try { digitA = ArrayA[curDigit]; }    // if index
                catch (IndexOutOfRangeException)     // out of range
                { digitA = 0; }                       // return 0

                try { digitB = ArrayB[curDigit]; }
                catch (IndexOutOfRangeException)
                { digitB = 0; }

                Result[curDigit] = digitA + digitB;  // sum
            }

            return Result;
        }
    }
}
