using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmBuble
{
    public class Testing
    {
        private int[] anArray;

        public Testing(int[] anArray)
        {
            this.anArray = anArray;
        }

        [Benchmark]
        public void Bubble_Sort()
        {
            PrintArray(anArray);

            for (int i = 0; i < anArray.Length; i++)
            {

                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {

                        Swap(ref anArray[j], ref anArray[j + 1]);
                    }
                }

                PrintArray(anArray);
            }
        }


        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            int tmpParam = aFirstArg;

            aFirstArg = aSecondArg;

            aSecondArg = tmpParam;
        }


        public static void PrintArray(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {

                Console.Write(anArray[i] + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
