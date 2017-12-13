using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    static internal class TabuSearch
    {
        private const int INF = Int32.MaxValue;
        private static Random rand = new Random();

        private static void SwapCities(int firstCity, int secondCity, int[] solution)
        {
            int temp = solution[firstCity];
            solution[firstCity] = solution[secondCity];
            solution[secondCity] = temp;
        }

        private static int GetSolutionWeight(int[] solution, int[,] matrix)
        {
            int weight = 0;

            for (int currentCity = 0; currentCity < solution.Length - 1; currentCity++)
            {
                weight += matrix[solution[currentCity], solution[currentCity + 1]];
            }
            weight += matrix[solution[solution.GetLength(0) - 1], solution[0]];

            return weight;
        }

        private static int[] GetRandomSolution(int numberOfCities)
        {
            Random rnd = new Random();
            int[] solution = new int[numberOfCities];
            for (int i = 0; i < numberOfCities; i++)
                solution[i] = i;

            solution = solution.OrderBy(x => rnd.Next()).ToArray();

            return solution;
        }

        private static int[] GetGreedySolution(int[,] matrix, int startCity)
        {
            int[] solution = new int[matrix.GetLength(0)];
            bool[] visitedCities = new bool[matrix.GetLength(0)];
            int currentStartCity = startCity;
            solution[0] = startCity;
            visitedCities[startCity] = true;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int tempWeight = INF;
                for (int currentDestinationCity = 0; currentDestinationCity < matrix.GetLength(0); currentDestinationCity++)
                {
                    if (!visitedCities[currentDestinationCity])
                    {
                        if (matrix[currentStartCity, currentDestinationCity] < tempWeight)
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

        private static void ReduceTabu(int[,] tabu)
        {
            for (int currentRow = 0; currentRow < tabu.GetLength(0); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < tabu.GetLength(0); currentColumn++)
                {
                    if (tabu[currentRow, currentColumn] > 0)
                        tabu[currentRow, currentColumn]--;
                }
            }
        }

        private static void AddToTabu(int[,] tabu, Pair<int, int> swappedCities, int timestamp)
        {
            tabu[swappedCities.First, swappedCities.Second] += timestamp;
            tabu[swappedCities.Second, swappedCities.First] += timestamp;
            if(tabu[swappedCities.First, swappedCities.Second]>timestamp || tabu[swappedCities.Second, swappedCities.First]>timestamp)
                new System.ArgumentException("Wybrano element będący już w tabu");
        }

        private static Pair<Pair<int, int>, int[]> GetBestNeighbor(int[,] matrix, int[] solution, int[,] tabu, int numberOfIterations)
        {
            int currentSolutionWeight = GetSolutionWeight(solution, matrix);
            int bestSolutionWeight = currentSolutionWeight;
            int[] bestSolution = solution;
            int currentNumberOfIterations = 0;
            Pair<int, int> swappedCities = new Pair<int, int>();
           
            int[] currentSolution = new int[solution.GetLength(0)];
            Array.Copy(solution, currentSolution, solution.GetLength(0));

            for (int i = 0; i < solution.GetLength(0); i++)
            {
                for (int j = i + 1; j < solution.GetLength(0) - 1; j++)
                {
                   
                    if (i == j)
                        continue;
                    if (tabu[i, j] != 0)
                    {
                        SwapCities(i, j, currentSolution);
                        currentSolutionWeight = GetSolutionWeight(currentSolution, matrix);
                        if(currentSolutionWeight < bestSolutionWeight)
                        {
                            bestSolution = currentSolution;
                            bestSolutionWeight = currentSolutionWeight;
                            swappedCities.First = i;
                            swappedCities.Second = j;
                        }

                        Array.Copy(solution, currentSolution, solution.GetLength(0));
                    }

                    numberOfIterations++;
                    if (currentNumberOfIterations == numberOfIterations)
                    {
                        i = INF;
                        break;
                    }

                }
            }

            return new Pair<Pair<int, int>, int[]>(swappedCities,bestSolution);
        }

        private static void ResetTabu(int[,] tabu)
        {
            for(int i = 0; i < tabu.GetLength(0); i++)
            {
                for (int j = 0; i < tabu.GetLength(0); i++)
                    tabu[i, j] = 0;
            }
        }

        public static Pair<Pair<int, int>, int[]> GetBestNeighborRandomly(int[,] matrix, int[] solution, int[,] tabu, int numberOfIterations, int timestamp)
        {
            int solutionLength = solution.GetLength(0);
            Pair<int, int> swappedCities = new Pair<int, int>();
            Pair<int, int> tempSwappedCities = new Pair<int, int>();
            int solutionWeight = GetSolutionWeight(solution, matrix);
            int currentSolutionWeight = GetSolutionWeight(solution, matrix);
            int bestSolutionWeight = currentSolutionWeight;
            int[] bestSolution = solution;
            int[] currentSolution = new int[solutionLength];
            Array.Copy(solution, currentSolution, solutionLength);
            int city1, city2;
           
            for (int currentNumberOfIterations = 0; currentNumberOfIterations < numberOfIterations; currentNumberOfIterations++)
            {
                
                do
                {
                    city1 = rand.Next(0, solutionLength);
                    city2 = rand.Next(0, solutionLength);
                }
                while (city1 == city2);
                //Debug.WriteLine("city1 {0}, city2 {1}, currentNumberOfIterations {2}", city1, city2, currentNumberOfIterations);
                
                SwapCities(city1, city2, currentSolution);
                currentSolutionWeight = GetSolutionWeight(currentSolution, matrix);
                tempSwappedCities.First = city1;
                tempSwappedCities.Second = city2;
                //AddToTabu(tabu, tempSwappedCities, timestamp);

                if (currentSolutionWeight < bestSolutionWeight && tabu[city1, city2] == 0)
                {
                    Array.Copy(currentSolution, bestSolution, solutionLength);
                    bestSolutionWeight = currentSolutionWeight;
                    swappedCities.First = city1;
                    swappedCities.Second = city2;

                }
               

                    Array.Copy(solution, currentSolution, solutionLength);
                
            }
            return new Pair<Pair<int, int>, int[]>(swappedCities, bestSolution);
        }

        private static string ShowSolution(int[] solution, int solutionWeight)
        {
            string solutionString = "Rozwiązanie:" + Environment.NewLine;
            foreach (var item in solution)
                solutionString += item + " -> ";
            solutionString += solution[0] + Environment.NewLine + "Koszt: " + solutionWeight;

            return solutionString;
        }

        public static string RunAlgorithm(int[,] matrix, int timestamp, int maxNumberOfIterations)
        {   
          
            int[,] tabu = new int[matrix.GetLength(0), matrix.GetLength(0)];
            int numberOfIterations = 0;
            int criticalEventCounter = 0;
            int[] solution = GetGreedySolution(matrix, rand.Next(0, matrix.GetLength(0)));
            int[] bestSolution = solution;
            int bestSolutionWeight = GetSolutionWeight(solution, matrix);
            int newWeight;
            Pair<Pair<int, int>, int[]> bestNeighbor;

            while(numberOfIterations<maxNumberOfIterations)
            {

                bestNeighbor = GetBestNeighborRandomly(matrix, solution, tabu, 10 * solution.GetLength(0), timestamp);
                solution = bestNeighbor.Second;
                ReduceTabu(tabu);
                AddToTabu(tabu, bestNeighbor.First, timestamp);

                if (criticalEventCounter == 20)
                {
                    solution = GetGreedySolution(matrix, rand.Next(0,matrix.GetLength(0)));
                    ResetTabu(tabu);
                    criticalEventCounter = 0;
                }

                newWeight = GetSolutionWeight(solution, matrix);
                if ( newWeight < bestSolutionWeight)
                {
                    Array.Copy(solution, bestSolution, solution.GetLength(0));
                    bestSolutionWeight = GetSolutionWeight(bestSolution, matrix);
                    criticalEventCounter = 0;
                   // Debug.WriteLine(ShowSolution(solution, GetSolutionWeight(solution, matrix)));
                    Debug.WriteLine("Główny - lepiej");
                } 
                else
                    criticalEventCounter++;

                numberOfIterations++; 
            }

            return ShowSolution(solution, GetSolutionWeight(solution, matrix));
        }


    }
}
