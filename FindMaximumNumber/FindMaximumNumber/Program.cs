﻿namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program to Find Maximum Number");

            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int integerOutput = maximumNumberCheck.MaximumIntegerNumber(99, 110, 150);
            Console.WriteLine(integerOutput);

            double doubleOutput = maximumNumberCheck.MaximumFloatNumber(111.1567, 234.5466, 668.9890);
            Console.WriteLine(doubleOutput);

            string stringOutput = maximumNumberCheck.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(stringOutput);
        }
    }
}