using System;
using System.Linq;
using System.Text;

namespace _1a_A
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());

            for (int t = 1; t <= T; t++)
            {
                var S = Console.ReadLine();

                var output = new StringBuilder();
                for (int i = 0; i < S.Length; i++)
                {
                    output.Append(S[i]);
                    for (int j = i + 1; j < S.Length; j++)
                    {
                        if (S[i] < S[j])
                        {
                            output.Append(S[i]);
                            break;
                        }
                        if (S[i] > S[j])
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"Case #{t}: {output}");
            }
        }
    }
}

