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

       //na private
        public struct Node
        {
            public Pair<int, int[]>[,] matrix;
            int lowerBound;
            List<Pair<int, int[]>> excludedCities;

            public Node(Pair<int, int[]>[,] newMatrix, int newLowerBound, List<Pair<int, int[]>> newExcludedCities)
            {
                matrix = newMatrix;
                lowerBound = newLowerBound;
                excludedCities = newExcludedCities;
            }
        }

        //na private
        public class Pair<T, U>
        {
            public Pair()
            {
            }

            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }
        };


        //zmienic na private
        public static int ReduceMatrix(Pair<int, int[]>[,] matrix)
        {
            int reductionLevel = 0;
            reductionLevel += ReduceRow(matrix);
            reductionLevel += ReduceColumn(matrix);

            return reductionLevel;
        }

        private static int ReduceRow(Pair<int, int[]>[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                min = INF;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j].First < min)
                    {
                        min = matrix[i, j].First;
                    }
                }

                if (min != 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j].First != INF)
                            matrix[i, j].First -= min;
                    }

                    reductionLevel += min;
                }
                    
            }
            return reductionLevel;
        }

        private static int ReduceColumn(Pair<int, int[]>[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                min = INF;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {

                    if (matrix[j, i].First < min)
                    {
                        min = matrix[j, i].First;
                    }
                }

                if (min != 0)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[j, i].First != INF)
                            matrix[j, i].First -= min;
                    }

                    reductionLevel += min;
                }
            }
            return reductionLevel;
        }

        //zmienic na private
        public static int[] DivideMatrix(Pair<int, int[]>[,] matrix)
        {
            int currentMaxCost = 0;
            int[] currentSolution = new int[2];
            int currentCost;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].First == 0)
                    {
                        currentCost = FindMaxExclusionCost(matrix, i, j);
                        if (FindMaxExclusionCost(matrix, i, j) > currentMaxCost)
                        {
                            currentSolution[0] = i;
                            currentSolution[1] = j;
                            currentMaxCost = currentCost;
                        }
                    }
                }                 
            }

            //obcieta macierz
            Node newNode1 = DeleteRoad(matrix, currentSolution);

            return currentSolution;
        }


        private static Node DeleteRoad(Pair<int, int[]>[,] matrix, int[] coordinatesToDelete)
        {
            Pair<int, int[]>[,] newMatrix = new Pair<int, int[]>[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            Console.Write(coordinatesToDelete[0]);
            Console.Write(coordinatesToDelete[1] + " ");
            Console.Write(Environment.NewLine);


            int newi = 0, newj = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == coordinatesToDelete[0])
                        break;
                    if (j == coordinatesToDelete[1])
                        continue;

                    newi = i;
                    newj = j;

                    if (i > coordinatesToDelete[0])
                        newi = i - 1;
                    if (j > coordinatesToDelete[1])
                        newj = j - 1;

                    newMatrix[newi, newj] = matrix[i, j];
                }
            }

            //trzeba zawrzeć w tym lowerBound, liste usunietych miast -> wejsc o poziom wyzej = przejsc z funkcjami by obrabialy node, a nie matrix
            return new Node(newMatrix,0,null);
        }

        public static void BlockCity(Pair<int, int[]>[,] matrix)
        {

        }

        private static int FindMaxExclusionCost(Pair<int, int[]>[,] matrix, int row, int column)
        {
            int currentMinCost = INF;
            int totalCost = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i == column)
                    continue;
                if (matrix[row, i].First < currentMinCost)
                    currentMinCost = matrix[row, i].First;
            }

            totalCost += currentMinCost;
            currentMinCost = INF;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == row)
                    continue;
                if (matrix[i, column].First < currentMinCost)
                    currentMinCost = matrix[i, column].First;
            }

            totalCost += currentMinCost;

            return totalCost;
        }

        public static List<Pair<int, int[]>> RunAlgorithm(int[,] matrix)
        {
            List<Pair<int, int[]>> tree = new List<Pair<int, int[]>>();
            Pair<int, int[]>[,] preparedMatrix;
            Node firstNode = new Node(preparedMatrix = PrepareMatrix(matrix), ReduceMatrix(preparedMatrix), new List<Pair<int, int[]>>());

            return tree;
        }

        public static Pair<int, int[]>[,] PrepareMatrix(int[,] matrix)
        {
            int matrixLength = matrix.GetLength(0);
            Pair<int, int[]>[,] preparedMatrix = new Pair<int, int[]>[matrixLength, matrixLength];

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    preparedMatrix[i, j] = new Pair<int, int[]>(matrix[i, j], new int[2]);
                    preparedMatrix[i, j].Second[0] = i;
                    preparedMatrix[i, j].Second[0] = j;
                }
            }
           
            return preparedMatrix;
        }

    }
}
