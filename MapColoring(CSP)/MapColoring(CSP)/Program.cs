using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapColoring_CSP_
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphColoringProblem Coloring = new GraphColoringProblem();
            // Create following graph and test whether it is colorable
            //  (3)---(2)
            //   |   / |
            //   |  /  |
            //   | /   |
            //  (0)---(1)

            int[][] graph =
                {
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 0, 1, 1 },
                new int[] { 1, 1, 0, 1 },
                new int[] { 1, 0, 1, 0 },
                };
            int m = 3; // Number of colors
            Coloring.graphColoring(graph, m);

        }
    }
}
