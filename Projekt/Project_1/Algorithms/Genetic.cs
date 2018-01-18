using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

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
        /// <summary>
        /// Metoda uruchamiająca algorytm
        /// </summary>
        /// <param name="cities"> Mapa miast, na której zostanie wykonany algorytm</param>
        /// <param name="populationSize"> Rozmiar populacji</param>
        /// <returns> Rozwiązanie w postaci łańcucha znaków</returns>
        public static string RunAlgorithm(Cities cities, int populationSize)
        {
            //prawdopodobnie do wywalenia
            //int probabilityUpperBound = 100;

            var population = GenerateRandomPopulation(populationSize, cities.AdjacencyMatrix.GetLength(0));
            Pair<int[], int> currentBestSolution = GetPopulationBestWeight(population, cities.AdjacencyMatrix);
            for (int i = 0; i < 500; i++)
            {
                Debug.WriteLine(i);
                var matingPool = Tournament(population, 20, cities.AdjacencyMatrix, populationSize / 2);
                var newPopulation = Crossover(matingPool, populationSize, 100);
                Mutate(newPopulation, 0, 1);
                currentBestSolution = GetPopulationBestWeight(newPopulation, cities.AdjacencyMatrix);
                Debug.WriteLine(GetSolutionString(currentBestSolution));
                population = newPopulation;
            }
            
            return GetSolutionString(currentBestSolution);
        }



        public static void RunTest(Cities cities, int populationSize)
        {
            var population = GenerateRandomPopulation(populationSize, cities.AdjacencyMatrix.GetLength(0));
            Debug.WriteLine("Populacja: ");
            for (int i = 0; i < populationSize; i++)
            {
                for (int j = 0; j < cities.AdjacencyMatrix.GetLength(0); j++)
                    Debug.Write(population[i][j] + " ");
                Debug.Write("  Waga: " + GetIndividualWeight(population[i], cities.AdjacencyMatrix));
                Debug.Write(Environment.NewLine);
            }
            Debug.WriteLine("Populacja rodzicielska: ");
            var tournamentPopulation = Tournament(population, 2, cities.AdjacencyMatrix, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < cities.AdjacencyMatrix.GetLength(0); j++)
                    Debug.Write(tournamentPopulation[i][j] + " ");
                Debug.Write("  Waga: " + GetIndividualWeight(tournamentPopulation[i], cities.AdjacencyMatrix));
                Debug.Write(Environment.NewLine);
            }

        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Funkcja przeprowadzająca selekcję turniejową - generująca nową populację
        /// </summary>
        /// <param name="population"> Populacja, która zostanie poddana krzyżowaniu</param>
        /// <param name="tournamentSize"> Rozmiar turnieju</param>
        /// <param name="cities"> Macierz miast</param>
        /// <param name="matingPoolSize"> Rozmiar populacji macierzystej</param>
        /// <returns> Nowa populacja</returns>
        private static List<int[]> Tournament(List<int[]> population, int tournamentSize, int[,] cities, int matingPoolSize)
        {
            var matingPool = new List<int[]>(matingPoolSize);    

            for (int i = 0; i < matingPoolSize; i++)
            {
                var solutionOrder = GenerateRandomSolution(population.Count - 1);

                int currentBestSolutionWeight = INF;
                int currentBestSolutionIndex = INF;
                for (int j = 0; j < tournamentSize; j++)
                {
                    int currentWeight = GetIndividualWeight(population[solutionOrder[j]], cities);
                    if (currentWeight < currentBestSolutionWeight)
                    {
                        currentBestSolutionIndex = solutionOrder[j];
                        currentBestSolutionWeight = currentWeight;
                    }
                }
                matingPool.Add(population[currentBestSolutionIndex]);
            }
            return matingPool;
        }

        /// <summary>
        /// Metoda generuje losową populację
        /// </summary>
        /// <param name="populationSize"> Rozmiar generowanej populacji</param>
        /// <param name="numberOfCities"> Liczba miast</param>
        /// <returns> Wygenerowana populacja losowa</returns>
        private static List<int[]> GenerateRandomPopulation(int populationSize, int numberOfCities)
        {
            var population = new List<int[]>(populationSize);

            for(int i = 0; i < populationSize; i++)
            {
                population.Add(GenerateRandomSolution(numberOfCities));
            }

            return population;
        }

        /// <summary>
        /// Funkcja generuje losowe rozwiązanie - osobnik
        /// </summary>
        /// <param name="numberOfCities"> Liczba miast</param>
        /// <returns> Wygenerowany osobnik</returns>
        private static int[] GenerateRandomSolution(int numberOfCities)
        {
            // Definicja oraz inicjalizacja listy dostępnych miast
            var cities = new int[numberOfCities];
            for(int i = 0; i < numberOfCities; i++)
            {
                cities[i] = i;
            }

            // Losowe przemieszanie miast
            var solution = cities.OrderBy(x => rand.Next()).ToArray();

            return solution;
        }

        /// <summary>
        /// Funkcja ta oblicza wagę danego rozwiązania dla danej macierzy reprezentującej miasta
        /// </summary>
        /// <param name="solution"> Rozwiązanie</param> 
        /// <param name="cities"> Macierz reprezentująca graf</param> 
        /// <returns> Długość trasy osobnika</returns>
        private static int GetIndividualWeight(int[] solution, int[,] cities)
        {
            int weight = 0;
            // Pętla dodająca wagi kolejnych krawędzi
            for (int currentCity = 0; currentCity < solution.Length - 1; currentCity++)
            {
                weight += cities[solution[currentCity], solution[currentCity + 1]];
            }
            // Powrót z ostaniego miasta do pierwszego
            weight += cities[solution[solution.GetLength(0) - 1], solution[0]];

            return weight;
        }

        /// <summary>
        /// Metoda znajdująca najlepsze rozwiązanie w populacji
        /// </summary>
        /// <param name="population"> Badana populacja</param>
        /// <param name="cities"> Reprezentacja miast</param>
        /// <returns>Para najlepszy osobnik, długość trasy</najlepszy></returns>
        private static Pair<int[], int> GetPopulationBestWeight(List<int[]> population, int[,] cities)
        {
            int bestWeight = INF;
            int weight;
            int index = 0;

            for (int i = 0; i < population.Count; i++)
            {
                weight = GetIndividualWeight(population[i], cities);
                if (weight < bestWeight)
                {
                    bestWeight = weight;
                    index = i;
                }
            }
            return new Pair<int[], int>(population[index], bestWeight);
        }

        /// <summary>
        /// Metoda wykonująca krzyżowanie OX na całej populacji macierzystej
        /// </summary>
        /// <param name="matingPool"> Zadana populacja macierzysta</param>
        /// <param name="populationSize"> Rozmiar populacji docelowej</param>
        /// <param name="probabilityUpperBound"> Górna granica prawdopodobieństwa z jakim krzyżowanie zostanie wykonane</param>
        /// <returns> Nowa populacja</returns>
        private static List<int[]> Crossover(List<int[]> matingPool, int populationSize, int probabilityUpperBound)
        {
            var newPopulation = new List<int[]>(populationSize);
            int probability;

            for (int i = 0; i < populationSize/2; i++)
            {
                int firstParent, secondParent;
                do
                {
                    firstParent = rand.Next(matingPool.Count);
                    secondParent = rand.Next(matingPool.Count);
                    probability = rand.Next(101);
                }
                while (probability > probabilityUpperBound);

                int firstIndex = rand.Next(matingPool[0].Length - 1),
                    secondIndex = rand.Next(firstIndex + 1, matingPool[0].Length);

                var pairOfChildren = CrossoverPair(new Pair<int, int>(firstIndex, secondIndex),
                                                   new Pair<int[], int[]>(matingPool[firstParent], matingPool[secondParent]));
                newPopulation.Add(pairOfChildren.First);
                newPopulation.Add(pairOfChildren.Second);
            }

            return newPopulation;
        }


        /// <summary>
        /// Funkcja ta odpowiada za krzyzowanie dwóch osobników
        /// </summary>
        /// <param name="indexes"> Zakres sekcji dopasowania</param>
        /// <param name="parents"> Rodzice, na których zostanie wykonane krzyżowanie</param>
        /// <returns> Para nowo utworzonych osobników - dzieci</returns>
        public static Pair<int[], int[]> CrossoverPair(Pair<int, int> indexes, Pair<int[], int[]> parents)
        {
            int solutionSize = parents.First.Length;
            int matchingSectionLength = indexes.Second - indexes.First + 1;
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
            for (int i = 0; i < solutionSize; i++)
            {   
                if(i >= indexes.First && i <= indexes.Second)
                {
                    children.First[i] = parents.Second[i];
                    children.Second[i] = parents.First[i];
                }
                else
                {
                    children.First[i] = INF;
                    children.Second[i] = INF;
                }
            }

            FillChild(children.First, parents.First);
            FillChild(children.Second, parents.Second);

            return children;
        }

        /// <summary>
        /// Funkcja odpowiadająca za mutację osobnika
        /// </summary>
        /// <param name="child"> Nowy osobnik, na którym zostanie przeprowadzone mutowanie</param>
        public static void Mutate(List<int[]> population, int probabilityUpperBound, int mutationType)
        {
           switch(mutationType)
            {
                case 0:
                    InvertMutation(population, probabilityUpperBound);
                    break;
                case 1:
                    SwapMutation(population, probabilityUpperBound);
                    break;
                default:
                    Console.WriteLine("Brak mutacji!");
                    break;
            }
            
        }

        public static void InvertMutation(List<int[]> population, int probabilityUpperBound)
        {
            foreach (var individual in population)
            {
                int probability = rand.Next(1001);
                if (probability < 10)
                {
                    int i = rand.Next(individual.Length - 1);
                    int j = rand.Next(i + 1, individual.Length);
                    Array.Reverse(individual, i, j - i + 1);
                }
            }

        }
        public static void SwapMutation(List<int[]> population, int probabilityUpperBound)
        {
            foreach (var individual in population)
            {
                int probability = rand.Next(1001);
                if (probability < 10)
                {
                    int i = rand.Next(individual.Length - 1);
                    int j = rand.Next(i + 1, individual.Length);
                    int temp = individual[i];
                    individual[i] = individual[j];
                    individual[j] = temp;
                }
            }

        }


        /// <summary>
        /// Generuje rozwiązanie w postaci łańcucha znaków
        /// </summary>
        /// <param name="solution"> Rozwiązanie</param>
        /// <returns> Rozwiązabue w postaci łańcucha znaków</returns>
        private static string GetSolutionString(Pair<int[], int> solution)
        {
            var solutionSB = new StringBuilder();

            foreach (var element in solution.First)
                solutionSB.Append(element + " -> ");

            solutionSB.Append(solution.First[0]
                            + Environment.NewLine + "Rozwiązanie: " + solution.Second);

            return solutionSB.ToString();
        }

        #endregion
    }
}
