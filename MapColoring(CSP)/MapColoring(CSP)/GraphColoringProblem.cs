using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapColoring_CSP_
{
    public class GraphColoringProblem
    {
        int _v = 4;
        int[] color;

        public bool isSafe(int v, int[][] graph, int[] color, int c)
        {
            for (int i = 0; i < _v; i++)
            {
                if (graph[v][i] == 1 && c == color[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool graphColoringUtil(int[][] graph, int m,
                              int[] color, int v)
        {
            if (v == _v)
                return true;
            for (int c = 1; c <= m; c++)
            {
                if (isSafe(v, graph, color, c))
                {
                    color[v] = c;
                    if (graphColoringUtil(graph, m,
                                          color, v + 1))
                        return true;
                    color[v] = 0;
                }
            }
            return false;
        }
        public bool graphColoring(int[][] graph, int m)
        {
            
            color = new int[_v];
            for (int i = 0; i < _v; i++)
                color[i] = 0;

            
            if (!graphColoringUtil(graph, m, color, 0))
            {
                Console.WriteLine("Solution does not exist");
                return false;
            }

           
            printSolution(color);
            return true;
        }
        
        void printSolution(int[] color)
        {
            Console.WriteLine("Solution Exists: Following" +
                               " are the assigned colors");
            for (int i = 0; i < _v; i++)
                Console.Write(" " + color[i] + " ");
            Console.WriteLine();
        }
    }
}
