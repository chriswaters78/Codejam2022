using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_D
{
    class Solution
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());
            int[] roots;
            int[] leaves;
            int[] maxChild;
            for (int t = 1; t <= T; t++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] ffs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] ps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var children = Enumerable.Range(1, N).ToDictionary(i => i, _ => new List<int>());
                roots = ps.Where(p => p == 0).ToArray();
                leaves = children.Where(kvp => kvp.Value.Count == 0).Select(kvp => kvp.Key).ToArray();

                maxChild = new int[N];
                foreach (var leaf in leaves)
                {
                    var node = leaf;
                    do
                    {
                        maxChild[node] = Math.Max(ffs[node], children[node].Max(child => maxChild[child]));
                        node = ps[node];
                    }
                    while(node != 0);                    
                }

                //start processing our roots
                //
            }
        }
}
