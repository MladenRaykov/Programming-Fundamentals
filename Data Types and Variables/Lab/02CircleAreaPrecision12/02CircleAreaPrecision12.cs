﻿using System;

namespace _02CircleAreaPrecision12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"{area:f12}");
        }
    }
}
