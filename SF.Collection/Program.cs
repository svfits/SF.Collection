﻿using BenchmarkDotNet.Running;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SF.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List

            var summary = BenchmarkRunner.Run<TestingDic>();
            var summary1 = BenchmarkRunner.Run<TestingList>();

            var listUser = new List<User>();

            var sdfsdf = new List<Dictionary<int, User>>();

            for (int i = 0; i < 100; i++)
            {
                listUser.Add(new User() { Age = i, Salary = i, UrlPhoto = "url" });
            }

            Console.WriteLine(listUser[78].Age);
            Console.WriteLine(listUser[78].Salary);
            Console.WriteLine(listUser[78].UrlPhoto);

            var listAll = new List<User>();

            listAll.AddRange(listUser);

            #endregion

            #region Словарик

            var keyValuePairs = new Dictionary<int, User>();

            for (int i = 0; i < 100; i++)
            {
                keyValuePairs.Add(i, new User() { Age = i, Salary = i, UrlPhoto = "Url Photo", id = i });
            }

            TestingDic testingDic = new TestingDic(keyValuePairs);
            testingDic.TestFilter();

            Console.WriteLine();

            listUser.Clear();
            for (int i = 0; i < 100; i++)
            {
                listUser.Add(new User() { Age = i, Salary = i, UrlPhoto = "url" });
            }

            TestingList testingList = new TestingList(listUser);
            testingList.TestFilter();



            #endregion


            #region sorted

            var comp = new Comparer();
            listAll.Sort(comp);

            #endregion

            Console.ReadLine();
        }
    }
}
