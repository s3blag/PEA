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
        // Wartość reprezentująca nieskończoność
        private const int INF = Int32.MaxValue;
        // Generator liczb losowych
        private static Random rand = new Random();

        /// <summary>
        /// Funkcja SwapCities zamienia kolejność danych miast w danym rozwiązaniu
        /// </summary>
        /// <param name="firstCity"></param> Pierwsze miasto które zamieniamy
        /// <param name="secondCity"></param> Drugie miasto które zamieniamy
        /// <param name="solution"></param> Rozwiązanie w którym zamieniamy miasta
        private static void SwapCities(int firstCity, int secondCity, int[] solution)
        {
            int temp = solution[firstCity];
            solution[firstCity] = solution[secondCity];
            solution[secondCity] = temp;
        }

        /// <summary>
        /// Funkcja ta oblicza wagę danego rozwiązania dla danej macierzy reprezentującej graf
        /// </summary>
        /// <param name="solution"></param> Rozwiązanie
        /// <param name="matrix"></param> Macierz reprezentująca graf
        /// <returns></returns>
        private static int GetSolutionWeight(int[] solution, int[,] matrix)
        {
            int weight = 0;
            // Pętla dodająca wagi kolejnych krawędzi
            for (int currentCity = 0; currentCity < solution.Length - 1; currentCity++)
            {
                weight += matrix[solution[currentCity], solution[currentCity + 1]];
            }
            weight += matrix[solution[solution.GetLength(0) - 1], solution[0]];

            return weight;
        }

        /// <summary>
        /// Funkcja generuje losowe rozwiązanie dla danej liczby miast
        /// </summary>
        /// <param name="numberOfCities"></param> Liczba miast
        /// <returns></returns>
        private static int[] GetRandomSolution(int numberOfCities)
        {
            // Utworzenie generatora liczb losowych
            Random rnd = new Random();
            // Inicjalizacja nowego rozwiązania
            int[] solution = new int[numberOfCities];
            for (int i = 0; i < numberOfCities; i++)
                solution[i] = i;

            // Losowe pomieszanie kolejności miast w rozwiązaniu
            solution = solution.OrderBy(x => rnd.Next()).ToArray();

            return solution;
        }

        /// <summary>
        /// Funkcja ta zwraca rozwiązanie, które obliczane jest metodą zachłanną
        /// </summary>
        /// <param name="matrix"></param> Macierz reprezentująca graf
        /// <param name="startCity"></param> Miasto od którego zaczynamy losowanie
        /// <returns></returns>
        private static int[] GetGreedySolution(int[,] matrix, int startCity)
        {
            // Deklaracja oraz definicja zmiennych przechowujących kolejno: rozwiązanie, 
            //informację czy dane miasto było odwiedzone oraz obecne miasto z którego wychodzi krawędź
            int[] solution = new int[matrix.GetLength(0)];
            bool[] visitedCities = new bool[matrix.GetLength(0)];
            int currentStartCity = startCity;
            // Początkowo do rozwiązania dodawane jest miasto początkowe oraz oznaczane jest jako odwiedzone
            solution[0] = startCity;
            visitedCities[startCity] = true;

            // Pętla dodająca zachłannie kolejne miasta
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                // Zmienna przechowująca chwilowo najlepsze rozwiązanie
                int tempWeight = INF;
                // Pętla zagnieżdżona która wyznacza miasto którego koszt odwiedzenia 
                //jest najniższy dla danego miasta początkowego
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

        /// <summary>
        /// Funkcja ta redukuje wartości tabu o 1, jeśli te są większe od 0
        /// </summary>
        /// <param name="tabu"></param> Macierz reprezentująca tabu
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

        /// <summary>
        /// Funkcja dodająca daną zamianę miast do tabu, na określoną liczbę iteracji
        /// </summary>
        /// <param name="tabu"></param> Macierz reprezentująca tabu
        /// <param name="swappedCities"></param> Zamiana miast która zostanie dodana do tabu
        /// <param name="timestamp"></param> Ilość iteracji na jaką dana zamiana zostaje dodana do tabu
        private static void AddToTabu(int[,] tabu, Pair<int, int> swappedCities, int timestamp)
        {
            if (tabu[swappedCities.First, swappedCities.Second] == 0 || tabu[swappedCities.Second, swappedCities.First] == 0)
            {
                tabu[swappedCities.First, swappedCities.Second] += timestamp;
                tabu[swappedCities.Second, swappedCities.First] += timestamp;
            }
                
        }
        
        /// <summary>
        /// Funkcja ta zeruje daną macierz tabu
        /// </summary>
        /// <param name="tabu"></param> Macierz reprezentująca tabu
        private static void ResetTabu(int[,] tabu)
        {
            for(int i = 0; i < tabu.GetLength(0); i++)
            {
                for (int j = 0; i < tabu.GetLength(0); i++)
                    tabu[i, j] = 0;
            }
        }

        /// <summary>
        /// Funkcja ta przeszukuje sąsiedztwo danego rozwiązania w poszukiwaniu jego poprawy.
        /// Wybór rozpatrywanej zamiany odbywa się losowo
        /// </summary>
        /// <param name="matrix"></param> Macierz reprezentująca graf
        /// <param name="solution"></param> Rozwiązanie którego sąsiedztwo jest przeszukiwane
        /// <param name="tabu"></param> Macierz reprezentująca tabu
        /// <param name="numberOfIterations"></param> Liczba iteracji poszukiwania
        /// <returns></returns>
        public static Pair<Pair<int, int>, int[]> GetBestNeighborRandomly(int[,] matrix, int[] solution, int[,] tabu, int numberOfIterations)
        {
            // Długość rozwiązania
            int solutionLength = solution.GetLength(0);
            // Zmienna która przechowuje zamiane miast, obecnie rozpatrywaną jako najkorzystniejszą
            Pair<int, int> swappedCities = new Pair<int, int>();
            // Zmienna ta przechowuje wage rozwiązania którego sąsiedztwo jest przeszukiwane
            int solutionWeight = GetSolutionWeight(solution, matrix);
            // Zmienna przechowuje wage rozwiązania po obecnie rozpatrywanej zamianie
            int currentSolutionWeight = GetSolutionWeight(solution, matrix);
            // Zmienna przechowuje wage najlepszego rozwiązania jakie do tej pory znaleziono lokalnie
            int bestSolutionWeight = currentSolutionWeight;
            // Zmienna przechowuje obecnie najlepsze lokalnie rozwiązanie
            int[] bestSolution = solution;
            // Zmienna przechowuje rozwiązanie które jest aktualnie rozpatrywane
            int[] currentSolution = new int[solutionLength];
            // Na początku aktualnie rozpatrywanym rozwiązaniem jest rozwiązanie przekazane do funkcji
            Array.Copy(solution, currentSolution, solutionLength);
            int city1, city2;
           
            for (int currentNumberOfIterations = 0; currentNumberOfIterations < numberOfIterations; currentNumberOfIterations++)
            {
                // Losowanie miast których zamiana będzie rozpatrywana
                do
                {
                    city1 = rand.Next(0, solutionLength);
                    city2 = rand.Next(0, solutionLength);
                }
                while (city1 == city2);
                
                // Zamiana wylosowanych miast w tymczasowym rozwiązaniu
                SwapCities(city1, city2, currentSolution);
                // Obliczenie wagi tymczasowego rozwiązania
                currentSolutionWeight = GetSolutionWeight(currentSolution, matrix);

                // Tymczasoweg rozwiązanie zostanie uznane jako najlepsze lokalnie, jeśli jego waga jest mniejsza od
                // rozwiązania przekazanego do funkcji i nie należy ono do tabu, lub jeśli spełnione jest kryterium aspiracji
                // currentSolutionWeight*1.05 < bestSolutionWeight
                if ((currentSolutionWeight < bestSolutionWeight && tabu[city1, city2] == 0) || currentSolutionWeight*1.05 < bestSolutionWeight)
                {
                    Array.Copy(currentSolution, bestSolution, solutionLength);
                    bestSolutionWeight = currentSolutionWeight;
                    swappedCities.First = city1;
                    swappedCities.Second = city2;
                }
                    // Na końcu każdej iteracji przekazane do funkcji rozwiązanie staje się rozwiązaniem tymczasowym
                    Array.Copy(solution, currentSolution, solutionLength);
                
            }
            return new Pair<Pair<int, int>, int[]>(swappedCities, bestSolution);
        }

        /// <summary>
        /// Funkcja wyświetlająca rozwiązanie
        /// </summary>
        /// <param name="solution"></param> Rozwiązanie które zostanie wyświetlone
        /// <param name="solutionWeight"></param> Waga rozwiązania
        /// <returns></returns>
        private static string ShowSolution(int[] solution, int solutionWeight)
        {
            string solutionString = "Rozwiązanie:" + Environment.NewLine;
            foreach (var item in solution)
                solutionString += item + " -> ";
            solutionString += solution[0] + Environment.NewLine + "Koszt: " + solutionWeight;

            return solutionString;
        }

        /// <summary>
        /// Główna funkcja wykonująca algorytm
        /// </summary>
        /// <param name="matrix"></param> Macierz reprezentująca graf
        /// <param name="timestamp"></param> Przez ile iteracji trzymane są elementy w tabu
        /// <param name="maxNumberOfIterations"></param> Maksymalna liczba iteracji
        /// <returns></returns>
        public static string RunAlgorithm(int[,] matrix, int timestamp, int maxNumberOfIterations)
        {
            // Deklaracja oraz definicja macierzy reprezentującej tabu
            int[,] tabu = new int[matrix.GetLength(0), matrix.GetLength(0)];
            // Licznik iteracji algorytmu
            int numberOfIterations = 0;
            // Licznik odliczający do zdarzenia krytycznego - wymagane dla dywersyfikacji
            int criticalEventCounter = 0;
            // Obliczenie startowego rozwiązania metodą zachłanną
            int[] solution = GetGreedySolution(matrix, rand.Next(matrix.GetLength(0)));
            // Na początku początkowe rozwiązanie jest obecnie najlepszym globalnie rozwiązaniem
            int[] bestSolution = solution;
            // Obliczenie wagi obecnie najlepszego rozwiązania
            int bestSolutionWeight = GetSolutionWeight(solution, matrix);
            // Waga nowo znalezionego rozwiązania
            int newWeight;
            // Zmienna przechowująca najlepszego sąsiada obecnie najlepszego lokalnie rozwiązania
            Pair<Pair<int, int>, int[]> bestNeighbor;

            // Pętla wykonująca algorytm
            while(numberOfIterations<maxNumberOfIterations)
            {
                // Wyznaczenie najlepszego sąsiada, obecnie najlepszego lokalnie rozwiązania
                bestNeighbor = GetBestNeighborRandomly(matrix, solution, tabu, 10*maxNumberOfIterations);
                // Przypisanie rozwiązania najlepszego sąsiada
                solution = bestNeighbor.Second;
                // Redukcja tabu
                ReduceTabu(tabu);
                // Dodanie do tabu wykonanej przed chwilą zamiany
                AddToTabu(tabu, bestNeighbor.First, timestamp);
                // Jeżeli przez 20 iteracji nie nastąpiła poprawa obecnie najlepszego globalnie rozwiązania to 
                // nastębuje wyzerowanie tabu oraz obliczenie nowego rozwiązania początkowego metodą zachłanną
                // Rozwiązanie to zaczyna się od losowo wybranego miasta
                if (criticalEventCounter == 20)
                {
                    solution = GetGreedySolution(matrix, rand.Next(solution.Length));
                    ResetTabu(tabu);
                    criticalEventCounter = 0;
                    Debug.WriteLine("Restart");
                }
                // Obliczenie wagi znalezionego rozwiązania
                 newWeight = GetSolutionWeight(solution, matrix);
                // Jeżeli waga ta jest mniejsza od rozwiązania najlepszego globalnie,
                // to znalezione rozwiązanie staje się najlepszym globalnym rozwiązaniem
                if ( newWeight < bestSolutionWeight)
                {
                    Array.Copy(solution, bestSolution, solution.GetLength(0));
                    bestSolutionWeight = GetSolutionWeight(bestSolution, matrix);
                    criticalEventCounter = 0;
                } 
                else
                    // Jeżeli nie znaleziono lepszego rozwiązania to licznik zdarzenia krytycznego zwiększa się
                    criticalEventCounter++;

                numberOfIterations++; 
            }

            return ShowSolution(solution, GetSolutionWeight(solution, matrix));
        }
  
        /// <summary>
        /// Funkcja wykorzystywana jedynie do testów. Funkcja ta bada zależność jakości rozwiązania od czasu.
        /// </summary>
        /// <param name="matrix"></param> Macierz reprezentująca graf
        /// <param name="time"></param> Czas pomiaru
        /// <returns></returns>
        public static LinkedList<Pair<int, int>> AnalyzeAlgorithm(int[,] matrix, int time)
        {
            Stopwatch stopWatch = new Stopwatch();
            int[,] tabu = new int[matrix.GetLength(0), matrix.GetLength(0)];
            int[] solution = GetGreedySolution(matrix, rand.Next(matrix.GetLength(0))),
                  bestSolution = solution;
            int bestSolutionWeight = GetSolutionWeight(solution, matrix),
                newWeight,
                numberOfIterations = 0,
                criticalEventCounter = 0,
                timestamp = solution.Length / 20,
                maxNumberOfIterations = solution.Length;
            Pair<Pair<int, int>, int[]> bestNeighbor;
            int elapsedTime = 0;
            LinkedList<Pair<int, int>> results = new LinkedList<Pair<int, int>>();

            while (stopWatch.Elapsed.TotalMilliseconds < time)
            {
                stopWatch.Start();   

                bestNeighbor = GetBestNeighborRandomly(matrix, solution, tabu, 10 * maxNumberOfIterations);
                solution = bestNeighbor.Second;
                ReduceTabu(tabu);
                AddToTabu(tabu, bestNeighbor.First, timestamp);

                if (criticalEventCounter == 25)
                {
                    solution = GetGreedySolution(matrix, rand.Next(solution.Length));
                    ResetTabu(tabu);
                    criticalEventCounter = 0;
                    Debug.WriteLine("Restart");
                }

                newWeight = GetSolutionWeight(solution, matrix);
                if (newWeight < bestSolutionWeight)
                {
                    Array.Copy(solution, bestSolution, solution.GetLength(0));
                    bestSolutionWeight = GetSolutionWeight(bestSolution, matrix);
                    criticalEventCounter = 0;
                    Debug.WriteLine("Główny - lepiej");
                }
                else
                    criticalEventCounter++;

                numberOfIterations++;

                stopWatch.Stop();
                elapsedTime = Convert.ToInt32(stopWatch.Elapsed.TotalMilliseconds);
                results.AddLast(new Pair<int, int>(elapsedTime, bestSolutionWeight));
            }
            stopWatch.Reset();
            return results;
        }


    }
}
