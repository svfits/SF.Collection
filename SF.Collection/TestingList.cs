using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF.Collection
{
    public class TestingList
    {
        readonly Random Random = new Random();

        public List<User> ListUser { get; }

        public TestingList(List<User> listUser)
        {
            this.ListUser = listUser;
        }

        [Benchmark]
        public void TestFilter()
        {
            for (int i = 0; i < 27; i++)
            {
                var rnd = Random.Next(99);

                var user = ListUser.Where(d => d.Age == rnd);

                Console.WriteLine(user.First().Age);

                Console.WriteLine(user.First().id);
            }
        }
    }
}
