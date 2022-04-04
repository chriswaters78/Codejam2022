using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_B
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int t = 1; t <= T; t++)
            {
                var split = Enumerable.Repeat(0, 3).Select(str => Console.ReadLine().Split(new[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray()).ToArray();

                var colourmins = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    colourmins[i] = Math.Min(split[0][i], Math.Min(split[1][i], split[2][i]));
                }

                Console.Write($"Case #{t}:");
                if (colourmins.Sum() < 1000000)
                {
                    Console.WriteLine(" IMPOSSIBLE");
                }
                else
                {
                    int inkUsed = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (inkUsed + colourmins[i] <= 1000000)
                        {
                            Console.Write($" {colourmins[i]}");
                            inkUsed += colourmins[i];
                        }
                        else
                        {
                            Console.Write($" {1000000 - inkUsed}");
                            inkUsed = 1000000;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
