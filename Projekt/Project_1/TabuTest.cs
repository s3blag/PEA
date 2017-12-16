using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class TabuTest
    {
        /// <summary>
        /// Metoda odpowiedzialna za uruchomienie testów z zadanymi parametrami
        /// </summary>
        /// <param name="cities"></param> Obiekt reprezentujący dany przypadek TSP
        /// <param name="timestamp"></param> Pojemność tabu
        /// <param name="maxNumberOfIterations"></param> Maksymalna liczba iteracji
        /// <param name="numberOfTrials"></param> Liczba prób
        /// <param name="path"></param> Ścieżka dla danych wyjściowych
        public static void RunTimestampTest(Cities cities, int timestamp, int maxNumberOfIterations, int numberOfTrials, string path)
        {
            string output = "|ZALEŻNOŚĆ OD TIMESTAMP|" + Environment.NewLine,
                   relativeError = "";
            float bestDistance = (float)cities.BestDistance,
                  tempDistance;
            
            for (int i = 0; i <= numberOfTrials; i++)
            {
                Console.WriteLine("Próba: " + i.ToString());
                //Ilosc iteracji do dobrania
                tempDistance = float.Parse(TabuSearch.RunAlgorithm(cities.AdjacencyMatrix,timestamp, maxNumberOfIterations));

                if (i != 0)
                {
                    relativeError = ( ((tempDistance - bestDistance)/bestDistance)*100.0f).ToString();
                    output += relativeError + Environment.NewLine;
                }

            }
            WriteOutputToFile(path, output);
        }

        /// <summary>
        /// Metoda wykonuje testy zależności czasowej
        /// </summary>
        /// <param name="cities"></param>
        /// <param name="timestamp"></param>
        /// <param name="maxNumberOfIterations"></param>
        /// <param name="numberOfTrials"></param>
        /// <param name="path"></param>
        public static void RunTimeTest(Cities cities, int timestamp, int maxNumberOfIterations, int numberOfTrials, string path)
        {
            string output = "|ZALEŻNOŚĆ CZASOWA|" + Environment.NewLine,
                   elapsedTime = "",
                   relativeError = "";

            int tempDistance,
                bestDistance = cities.BestDistance;
            
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i <= numberOfTrials; i++)
            {
                Console.WriteLine("Próba: " + i.ToString());

                stopWatch.Start();
                /////          DO DOBRANIA + wyłącz wyświetlanie wyniku
                tempDistance = Int32.Parse(TabuSearch.RunAlgorithm(cities.AdjacencyMatrix, timestamp, maxNumberOfIterations));
                stopWatch.Stop();

                if (i != 0)
                {
                    relativeError = ((tempDistance - bestDistance) / bestDistance).ToString();
                    elapsedTime = stopWatch.Elapsed.TotalMilliseconds.ToString();
                    output += cities.AdjacencyMatrix.GetLength(0).ToString() + ";" + elapsedTime + ";" +relativeError + Environment.NewLine;
                }
                
                stopWatch.Reset();
            }
            WriteOutputToFile(path, output);
        }

        /// <summary>
        /// Funkcja wykonująca test - badanie przebiegu algorytmu w zależności od czasu
        /// </summary>
        /// <param name="cities"></param>
        /// <param name="path"></param>
        public static void RunImprovementByTimeTest(Cities cities,  string path)
        {
            StringBuilder algorithmResultsSB = new StringBuilder();
            algorithmResultsSB.Append("|BADANIE PRZEBIEGU ALGORYTMU W ZALEŻNOŚCI OD CZASU|" + Environment.NewLine);
            LinkedList<Pair<int, int>> algorithmResults = TabuSearch.AnalyzeAlgorithm(cities.AdjacencyMatrix, 120000);

            foreach (var result in algorithmResults)
            {
                algorithmResultsSB.Append(result.First + ";" + result.Second + Environment.NewLine);
            }
            WriteOutputToFile(path, algorithmResultsSB.ToString());
        }

        /// <summary>
        /// Zapis do pliku
        /// </summary>
        /// <param name="path"> Ścieżka pliku wyjściowego </param>
        /// <param name="output"> Dane do zapisania </param>
        private static void WriteOutputToFile(string path, string output)
        {
            FileStream fs = new FileStream(path,
                FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(output);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
