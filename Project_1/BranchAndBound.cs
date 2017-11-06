﻿using System;
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
            ReduceRow(matrix);
            ReduceColumn(matrix);

            return matrix;
        }

        private static void ReduceRow(int[,] matrix)
        {
            int min;

            for (int i = 0; i < 4; i++)
            {
                min = INF;

                for (int j = 0; j < 4; j++)
                {

                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }

                if (min != 0)
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix[i, j] != INF)
                            matrix[i, j] -= min;
                    }
            }
        }

        private static void ReduceColumn(int[,] matrix)
        {
            int min;

            for (int i = 0; i < 4; i++)
            {
                min = INF;

                for (int j = 0; j < 4; j++)
                {

                    if (matrix[j, i] < min)
                    {
                        min = matrix[j, i];
                    }
                }

                if (min != 0)
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix[j, i] != INF)
                            matrix[j, i] -= min;
                    }
            }
        }

    }
}
