using System;
using System.Linq;

namespace _1B_C
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int bits = 0;
            for (int t = 1; t <= T; t++)
            {
                while (true)
                {
                    for (var i = 0; i < bits; i++)
                    {
                    }
                    var binary = Convert.ToString(rand.Next(0, 255), 2);
                    var pad = binary.PadLeft(8, '0');
                    Console.WriteLine(pad);
                    bits = int.Parse(Console.ReadLine());

                    if (bits == 0)
                    {
                        break;
                    }

                    if (bits == -1)
                    {
                        goto invalid;
                    }

                }
            }
        invalid:;
        }
    }
}
