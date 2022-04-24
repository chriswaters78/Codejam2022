using System;
using System.Collections.Generic;
using System.Linq;

namespace _1B_A
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int t = 1; t <= T; t++)
            {
                var N = Console.ReadLine();
                var Ds = new LinkedList<int>(Console.ReadLine().Split(' ').Select( str => 
                    int.Parse(str)));

                int payedFor = 0;
                int maxDelicious = 0;
                while (Ds.Any())
                {
                    int removed;
                    if (Ds.First.Value < Ds.Last.Value)
                    {
                        removed = Ds.First.Value;
                        Ds.RemoveFirst();
                    }
                    else
                    {
                        removed = Ds.Last.Value;
                        Ds.RemoveLast();
                    }
                    if (removed >= maxDelicious)
                    {
                        payedFor++;
                    }
                    maxDelicious = Math.Max(maxDelicious, removed);
                }

                Console.WriteLine($"Case #{t}: {payedFor}");
            }
        }
    }
}
