using System;
using System.Collections.Generic;
using System.Linq;

namespace Round1a_B
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int t = 1; t <= T; t++)
            {
                var N = int.Parse(Console.ReadLine());

                var As = Enumerable.Range(0, 29).Select(i => (long)Math.Pow(2, i))
                    .Concat(
                    Enumerable.Repeat(Math.Pow(2, 29), N - 29).Select((bn,i) => (long) bn + i));
                
                Console.WriteLine(String.Join(' ', As));
                var Bs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                //var total = As.Sum() + Bs.Sum();
                //var target = total / 2;

                //choose some set of A and B such that it equals the target
                var set1 = new List<long>();
                long sum1 = 0;
                //var set2 = new List<long>();
                long sum2 = 0;

                foreach (var b in Bs)
                {
                    if (sum1 < sum2)
                    {
                        set1.Add(b);
                        sum1 += b;
                    }
                    else
                    {
                        sum2 += b;
                    }
                }

                //now add the binary numbers from biggest to smallest and home in on equal sum

                foreach (var a in As.Reverse())
                {
                    if (sum1 < sum2)
                    {
                        set1.Add(a);
                        sum1 += a;
                    }
                    else
                    {
                        sum2 += a;
                    }
                }

                Console.WriteLine(String.Join(' ', set1));
            }
        }
    }
}
