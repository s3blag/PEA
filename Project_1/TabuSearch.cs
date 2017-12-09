using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    static internal class TabuSearch
    {
        private const int INF = Int32.MaxValue;

        public static void SwapCities(int firstCity, int secondCity, int[] solution)
        {
            int temp = solution[firstCity];
            solution[firstCity] = solution[secondCity];
            solution[secondCity] = temp;
        }

        public static int GetSolutionWeight(int[] solution, int[,] matrix)
        {
            int weight = 0;
            for(int currentCity = 0; currentCity < solution.Length - 1; currentCity++)
            {
                weight += matrix[solution[currentCity], solution[currentCity + 1]];
            }

            return weight;
        }

        public static int[] GetGreedySolution(int [,] matrix, int startCity)
        {
            int[] solution = new int[matrix.GetLength(0) + 1];
            bool[] visitedCities = new bool[matrix.GetLength(0)];
            int currentStartCity = startCity;
            solution[0] = startCity;
            solution[matrix.GetLength(0)] = startCity;
            visitedCities[startCity] = true;

            for(int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int tempWeight = INF;
                for(int currentDestinationCity = 0; currentDestinationCity < matrix.GetLength(0); currentDestinationCity++)
                {
                    if(!visitedCities[currentDestinationCity])
                    {
                        if(matrix[currentStartCity, currentDestinationCity] < tempWeight)
                        {
                            tempWeight = matrix[currentStartCity, currentDestinationCity];
                            solution[i + 1] = currentDestinationCity;
                        }
                    }
                }
                currentStartCity = solution[i + 1];
                visitedCities[solution[i + 1]] = true;
            }

            return solution;
        }
    }
}
