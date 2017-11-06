using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    abstract class BranchAndBound
    {
        private const int INF = Int32.MaxValue;

        public static int[,] ReduceMatrix(int[,] matrix)
        {
            int reductionLevel = 0;
            reductionLevel += ReduceRow(matrix);
            reductionLevel += ReduceColumn(matrix);
            Console.WriteLine(reductionLevel);
            return matrix;
        }

        private static int ReduceRow(int[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                min = INF;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }

                if (min != 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != INF)
                            matrix[i, j] -= min;
                    }

                    reductionLevel += min;
                }
                    
            }
            return reductionLevel;
        }

        private static int ReduceColumn(int[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                min = INF;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {

                    if (matrix[j, i] < min)
                    {
                        min = matrix[j, i];
                    }
                }

                if (min != 0)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[j, i] != INF)
                            matrix[j, i] -= min;
                    }

                    reductionLevel += min;
                }
            }
            return reductionLevel;
        }

        private static int[] ExcludeNode(Tuple<int, int[]>[,] matrix)
        {
            int currentMaxCost = 0;
            int[] currentSolution = new int[2];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j].Item1 == 0)
                    {
                        if (FindMaxExlusionCost(matrix, i, j) > currentMaxCost)
                        {
                            currentSolution[0] = i;
                            currentSolution[1] = j;
                        }
                    }
                }                 
            }

            return currentSolution;
        }

        private static int FindMaxExlusionCost(Tuple<int, int[]>[,] matrix, int row, int column)
        {
            int currentMinCost = INF;
            int totalCost = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[row, i].Item1 < currentMinCost)
                    currentMinCost = matrix[row, i].Item1;
            }

            totalCost += currentMinCost;
            currentMinCost = INF;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, column].Item1 < currentMinCost)
                    currentMinCost = matrix[i, column].Item1;
            }

            totalCost += currentMinCost;

            return totalCost;
        }
    }
}
