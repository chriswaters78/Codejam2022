using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_C
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int t = 1; t <= T; t++)
            {
                var N = int.Parse(Console.ReadLine());
                var Sis = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray();

                var ordered = Sis.OrderBy(si => si);

                var straightLength = 0;
                foreach (var si in ordered)
                {
                    if (si > straightLength)
                    {
                        straightLength++;
                    }
                }                

                Console.WriteLine($"Case #{t}: {straightLength}");
            }
        }
    }
}
