using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace TSP.Algorithms
{
    static public class Genetic
    {
        #region Fields

        // Wartość reprezentująca nieskończoność
        private const int INF = Int32.MaxValue;
        private static Random rand = new Random();
        
        #endregion

        #region Public Methods
        public static string RunAlgorithm(Cities cities, int populationSize)
        {
            
            throw new NotImplementedException();
        }

        public static void RunTest(Cities cities, int populationSize)
        {
            var population = GenerateRandomPopulation(populationSize, cities.AdjacencyMatrix.GetLength(0));
            Debug.WriteLine("Populacja: ");
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < cities.AdjacencyMatrix.GetLength(0); j++)
                    Debug.Write(population[i][j] + " ");
                Debug.Write("  Waga: " + GetSolutionWeight(population[i], cities.AdjacencyMatrix));
                Debug.Write(Environment.NewLine);
            }
            Debug.WriteLine("Populacja rodzicielska: ");
            var tournamentPopulation = Tournament(population, 2, cities.AdjacencyMatrix, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < cities.AdjacencyMatrix.GetLength(0); j++)
                    Debug.Write(tournamentPopulation[i][j] + " ");
                Debug.Write("  Waga: " + GetSolutionWeight(tournamentPopulation[i], cities.AdjacencyMatrix));
                Debug.Write(Environment.NewLine);
            }

        }
        #endregion

        #region Private Methods

        private static List<int[]> Tournament(List<int[]> population, int tournamentSize, int[,] matrix, int parentPopulationSize)
        {
            var tournamentList = new List<int[]>();
            var parents = new List<int[]>();

            int[] solutionOrder = GenerateRandomSolution(population.Count - 1);

            

            for (int i = 0; i < parentPopulationSize; i++)
            {
                tournamentList = new List<int[]>();
                for (int k = 0; k < tournamentSize; k++)
                {
                    tournamentList.Add(population[solutionOrder[i]]);
                }

                int currentBestSolutionWeight = INF;
                int currentBestSolutionIndex = INF;
                for (int j = 0; j < tournamentSize; j++)
                {
                    int currentWeight = GetSolutionWeight(tournamentList[j], matrix);
                    if (currentWeight < currentBestSolutionWeight)
                    {
                        currentBestSolutionIndex = j;
                        currentBestSolutionWeight = currentWeight;
                    }
                }
                parents.Add(tournamentList[currentBestSolutionIndex]);
            }
            return parents;
        }

        /// <summary>
        /// Metoda generuje losową populację
        /// </summary>
        /// <param name="populationSize"> Rozmiar generowanej populacji</param>
        /// <param name="numberOfCities"> Liczba miast</param>
        /// <returns></returns>
        private static List<int[]> GenerateRandomPopulation(int populationSize, int numberOfCities)
        {
            var population = new List<int[]>();

            for(int i = 0; i < populationSize; i++)
            {
                population.Add(GenerateRandomSolution(numberOfCities));
            }

            return population;
        }

        /// <summary>
        /// Funkcja generuje losowe rozwiązanie
        /// </summary>
        /// <param name="numberOfCities"> Liczba miast instancji problemu</param>
        /// <returns></returns>
        private static int[] GenerateRandomSolution(int numberOfCities)
        {
            // Definicja oraz inicjalizacja listy dostępnych miast
            int[] cities = new int[numberOfCities];
            for(int i = 0; i < numberOfCities; i++)
            {
                cities[i] = i;
            }

            // Losowe przemieszanie miast
            int[] solution = cities.OrderBy(x => rand.Next()).ToArray();

            return solution;
        }

        /// <summary>
        /// Funkcja ta oblicza wagę danego rozwiązania dla danej macierzy reprezentującej graf
        /// </summary>
        /// <param name="solution"> Rozwiązanie</param> 
        /// <param name="matrix"> Macierz reprezentująca graf</param> 
        /// <returns></returns>
        private static int GetSolutionWeight(int[] solution, int[,] matrix)
        {
            int weight = 0;
            // Pętla dodająca wagi kolejnych krawędzi
            for (int currentCity = 0; currentCity < solution.Length - 1; currentCity++)
            {
                weight += matrix[solution[currentCity], solution[currentCity + 1]];
            }
            // Powrót z ostaniego miasta do pierwszego
            weight += matrix[solution[solution.GetLength(0) - 1], solution[0]];

            return weight;
        }

        public static Pair<int[], int[]> Crossover(Pair<int, int> indexes, Pair<int[], int[]> parents)
        {
            var solutionSize = parents.First.Length;
            var matchingSectionLength = indexes.Second - indexes.First + 1;
            var children = new Pair<int[], int[]>(new int[solutionSize], new int[solutionSize]);

            //Kopiuje elementy, które nie wystepują w już skopiowanej sekcji dopasowania
            void FillChild(int[] child, int[] parent)
            {
                for (int counter = 0, childCurrentIndex = indexes.Second + 1, parentCurrentIndex = indexes.Second + 1;
                counter < solutionSize - matchingSectionLength;
                counter++, childCurrentIndex++)
                {
                    if (childCurrentIndex >= solutionSize)
                        childCurrentIndex = 0;

                    do
                    {
                        if (parentCurrentIndex >= solutionSize)
                            parentCurrentIndex = 0;

                        if (!Array.Exists(child, c => c == parent[parentCurrentIndex]))
                        {
                            child[childCurrentIndex] = parent[parentCurrentIndex];
                            parentCurrentIndex++;
                            break;
                        }
                        else
                            parentCurrentIndex++;
                    }
                    while (true);

                }
            }

            //kopiowanie sekcji dopasowania
            for (int i = indexes.First; i <= indexes.Second; i++)
            {
                children.First[i] = parents.Second[i];
                children.Second[i] = parents.First[i];
            }

            FillChild(children.First, parents.First);
            FillChild(children.Second, parents.Second);

            return children;
        }

        public static void Mutate(int[] child)
        {
            //var i = indexes.First;
            //var j = indexes.Second;

            var probability = rand.Next(1001);
            if(probability<10)
            {
                var i = rand.Next(child.Length - 1);
                var j = rand.Next(i + 1, child.Length);
                Array.Reverse(child, i, j - i + 1);
            }  
        }

        #endregion
    }
}
