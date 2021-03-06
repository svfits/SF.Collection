﻿using AlgoritmBuble;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Testing>();

            int[] someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };

            Random random = new Random();

            var lsArr = new List<int>();
            for (int i = 1; i < 500; i++)
            {

                lsArr.Add(random.Next(100));

            }

            //Testing testing = new Testing(someArray);
            Testing testing = new Testing(lsArr.ToArray());

            testing.Bubble_Sort();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
