using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class TabuTest
    {
        /// <summary>
        /// Metoda odpowiedzialna za uruchomienie testów z zadanymi parametrami
        /// </summary>
        /// <param name="size"> Rozmiar instancji(ilość miast) </param>
        /// <param name="minWeight"> Dolny zakres losowania wag </param>
        /// <param name="maxWeight"> Górny zakres losowania wag </param>
        /// <param name="numberOfTrials"> Ilość powtórzeń </param>
        /// <param name="path"> Ścieżka pliku wyjściowego </param>
        public static void RunTimestampTest(Cities cities, int timestamp, int maxNumberOfIterations, int numberOfTrials, string path)
        {
            string output = "|ZALEŻNOŚĆ OD TIMESTAMP|" + Environment.NewLine;
            string relativeError = "";
            int bestDistance = cities.BestDistance;
            int tempDistance;
            
            for (int i = 0; i <= numberOfTrials; i++)
            {
                Console.WriteLine("Próba: " + i.ToString());
                //Ilosc iteracji do dobrania
                tempDistance = Int32.Parse(TabuSearch.RunAlgorithm(cities.AdjacencyMatrix,timestamp, maxNumberOfIterations));

                if (i != 0)
                {
                    relativeError = ( (tempDistance - bestDistance)/bestDistance).ToString();
                    output += relativeError + Environment.NewLine;
                }

            }
            WriteOutputToFile(path, output);
        }

        public static void RunTimeTest(Cities cities, int timestamp, int maxNumberOfIterations, int numberOfTrials, string path)
        {
            string output = "|ZALEŻNOŚĆ CZASOWA|" + Environment.NewLine;
            string elapsedTime = "";
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i <= numberOfTrials; i++)
            {
                Console.WriteLine("Próba: " + i.ToString());

                stopWatch.Start();
                /////          DO DOBRANIA + wyłącz wyświetlanie wyniku
                TabuSearch.RunAlgorithm(cities.AdjacencyMatrix, timestamp, maxNumberOfIterations);
                stopWatch.Stop();

                if (i != 0)
                {
                    elapsedTime = stopWatch.Elapsed.TotalMilliseconds.ToString();
                    output += elapsedTime + Environment.NewLine;
                }

                stopWatch.Reset();
            }
            WriteOutputToFile(path, output);
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
