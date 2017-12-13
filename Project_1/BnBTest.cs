using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    static internal class BnBTest
    {   
        /// <summary>
        /// Metoda odpowiedzialna za uruchomienie testów z zadanymi parametrami
        /// </summary>
        /// <param name="size"> Rozmiar instancji(ilość miast) </param>
        /// <param name="minWeight"> Dolny zakres losowania wag </param>
        /// <param name="maxWeight"> Górny zakres losowania wag </param>
        /// <param name="numberOfTrials"> Ilość powtórzeń </param>
        /// <param name="path"> Ścieżka pliku wyjściowego </param>
        public static void RunTest(int size, int minWeight, int maxWeight, int numberOfTrials, string path)
        {
            string output = "";
            string elapsedTime="";
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i <= numberOfTrials; i++)
            {                
                Cities cities = new Cities(size, minWeight, maxWeight, true);
                Console.WriteLine("Próba: " + i.ToString());

                stopWatch.Start();
                BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);
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
