using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_A
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int t = 1; t <= T; t++)
            {
                var split = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                var R = split[0];
                var C = split[1];

                StringBuilder builder = new StringBuilder();
                builder.Append(new [] { '.', '.' }.Concat(Enumerable.Repeat("+-", C - 1).SelectMany(str => str).ToArray()).Concat(new [] { '+' }).ToArray());
                builder.AppendLine();
                for (int r = 0; r < R; r++)
                {
                    if (r == 0)
                    {
                        builder.Append( new [] { '.', '.' }.Concat(Enumerable.Repeat("|.", C - 1).SelectMany(str => str)).Concat(new [] { '|' }).ToArray());
                    }
                    else
                    {
                        builder.Append(Enumerable.Repeat("|.", C).SelectMany(str => str).Concat(new char[] { '|' }).ToArray());
                    }
                    builder.AppendLine();
                    builder.Append(Enumerable.Repeat("+-", C).SelectMany(str => str).Concat(new char[] { '+' }).ToArray());
                    builder.AppendLine();
                }

                Console.WriteLine($"Case #{t}:");
                Console.WriteLine(builder.ToString());
            }
        }
    }
}
