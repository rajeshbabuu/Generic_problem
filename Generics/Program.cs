﻿using static Generics.Maxnum;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Based Problems");

            int output = Maxnum.MaxIntegerNumber(1111, 111, 11);
            Console.WriteLine("\nMax integer number is: " + output);
        }
    }
}