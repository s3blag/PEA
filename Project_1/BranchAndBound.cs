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

    }
}
