using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TSP;
using TSP.Algorithms;

namespace TSP.Tests
{
    static internal class GeneticTest
    {
        #region Public Methods
        static public void RunParameterTest(Cities cities, int time, int populationSize, int matingPoolSize,
                                           int tournamentSize, int mutationProbability, int mutationType,
                                           string path)
        {
            float bestDistance = (float)cities.BestDistance;
            float distance = (float)Genetic.AnalyzeWeight(cities, time, populationSize, matingPoolSize, tournamentSize, mutationProbability, mutationType);            
            string relativeError = (((distance - bestDistance) / bestDistance) * 100.0f).ToString();

            path += cities.AdjacencyMatrix.GetLength(0) + "_Genetic_" + time + "s_" + populationSize + "os_" + matingPoolSize + "mat_" + tournamentSize +
                    "trnm_" + mutationProbability + "%_" + (mutationType == 0 ? "invert" : "swap") + ".txt";

            WriteOutputToFile(path, relativeError);
        }

        public static void RunPerformanceOverTimeTest(Cities cities, int time, int populationSize, int matingPoolSize, 
                                                 int tournamentSize, int mutationProbability, int mutationType,
                                                 string path)
        {
            path += cities.AdjacencyMatrix.GetLength(0) + "_Genetic_" + time + "s_" + populationSize + "os_" + matingPoolSize + "mat_" + tournamentSize +
                    "trnm_" + mutationProbability + "%_" + (mutationType == 0 ? "invert" : "swap") + ".txt";
            StringBuilder algorithmResultsSB = new StringBuilder();
            algorithmResultsSB.Append("|BADANIE PRZEBIEGU ALGORYTMU W ZALEŻNOŚCI OD CZASU|" + Environment.NewLine);
            LinkedList<Pair<int, int>> algorithmResults = Genetic.AnalyzePerformance(cities, time, populationSize,
                                                                                     matingPoolSize, tournamentSize,
                                                                                     mutationProbability, mutationType);
            float bestDistance = (float)cities.BestDistance;

            foreach (var result in algorithmResults)
            {
                
                string relativeError = ((((float)result.Second - bestDistance) / bestDistance) * 100.0f).ToString();
                algorithmResultsSB.Append(result.First + ";" + relativeError + Environment.NewLine);
            }
            WriteOutputToFile(path, algorithmResultsSB.ToString());
        }

        #endregion



        #region Private Methods

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

        #endregion

    }
}
