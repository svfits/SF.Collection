using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF.Collection
{
    public class TestingDic
    {
        readonly Random Random = new Random();
        private Dictionary<int, User> dicUser;

        public TestingDic(Dictionary<int, User> keyValuePairs)
        {
            this.dicUser = keyValuePairs;
        }

        [Benchmark]
        public void TestFilter()
        {
            for (int i = 0; i < 27; i++)
            {
                var rnd = Random.Next(100);

                var user = dicUser.Where(gdfg => gdfg.Key == rnd);

                Console.WriteLine(user.First().Value.Age);
                
                Console.WriteLine(user.First().Value.id);
            }
        }
    }
}
