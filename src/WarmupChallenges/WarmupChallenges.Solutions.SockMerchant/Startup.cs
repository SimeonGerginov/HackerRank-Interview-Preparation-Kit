using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmupChallenges.Solutions.SockMerchant
{
    public class Startup
    {
        public static int NumberOfSockPairs(int[] colorsOfSocks, int numberOfSocks)
        {
            var sockPairs = new Dictionary<int, int>();
            var numberOfSockPairs = 0;

            for (int i = 0; i < numberOfSocks; i++)
            {
                if (sockPairs.ContainsKey(colorsOfSocks[i]))
                {
                    numberOfSockPairs++;
                    sockPairs.Remove(colorsOfSocks[i]);
                }
                else
                {
                    sockPairs.Add(colorsOfSocks[i], 1);
                }
            }

            return numberOfSockPairs;
        }

        public static void Main()
        {
            var numberOfSocks = int.Parse(Console.ReadLine());
            var colorsOfSocks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numberOfSockPairs = NumberOfSockPairs(colorsOfSocks, numberOfSocks);
            Console.WriteLine(numberOfSockPairs);
        }
    }
}
