﻿using System;
using System.Linq;
using System.Numerics;

namespace IntegerCalculations
{
    class Program
    {
        static void Main()
        {
         
            // input
            int[] Numbers = Console.ReadLine().Trim(' ').Split(' ').Select(number => int.Parse(number)).ToArray();

            GetMin(Numbers);
            GetMax(Numbers);
            GetAverage(Numbers);
            GetSum(Numbers);
            GetProduct(Numbers);
        }

        // Get Minimum
        public static void GetMin(params int[] Numbers)
        {
            int MinNumber = int.MaxValue;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                if (Numbers[curNumber] < MinNumber)
                {
                    MinNumber = Numbers[curNumber];
                }
            }

            Console.WriteLine(MinNumber);
        }

        // Get Maximum
        public static void GetMax(params int[] Numbers)
        {
            int MaxNumber = int.MinValue;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                if (Numbers[curNumber] > MaxNumber)
                {
                    MaxNumber = Numbers[curNumber];
                }
            }

            Console.WriteLine(MaxNumber);
        }

        // Get Average
        public static void GetAverage(params int[] Numbers)
        {
            int NumbersSum = 0;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersSum += Numbers[curNumber];
            }

            Console.WriteLine(((double)NumbersSum / (double)Numbers.Length).ToString("F2"));
        }

        // Get Sum
        public static void GetSum(params int[] Numbers)
        {
            int NumbersSum = 0;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersSum += Numbers[curNumber];
            }

            Console.WriteLine(NumbersSum);
        }

        // Get Product
        public static void GetProduct(params int[] Numbers)
        {
            BigInteger NumbersProduct = 1;

            for (int curNumber = 0; curNumber < Numbers.Length; curNumber++)
            {
                NumbersProduct *= Numbers[curNumber];
            }

            Console.WriteLine(NumbersProduct);
        }
    }
}
