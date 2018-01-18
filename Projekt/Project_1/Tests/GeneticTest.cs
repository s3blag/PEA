﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TSP;
using TSP.Algorithms;

namespace Project_1.Tests
{
    static internal class GeneticTest
    {
        #region Public Methods
        #endregion

        public static void RunTournamentSizeTest(Cities cities, int time, int populationSize, int matingPoolSize, 
                                                int tournamentSize, int mutationProbability, int mutationType,
                                                string path)
        {
            path += "Genetic_" + time + "s_" + populationSize + "os_" + matingPoolSize + "mat_" + tournamentSize +
                    "trnm_" + mutationProbability + "%_" + (mutationType == 0 ? "invert" : "swap");

            StringBuilder algorithmResultsSB = new StringBuilder();
            algorithmResultsSB.Append("|BADANIE PRZEBIEGU ALGORYTMU W ZALEŻNOŚCI OD CZASU|" + Environment.NewLine);
            LinkedList<Pair<int, int>> algorithmResults = Genetic.AnalyzePerformance(cities, time, populationSize, 
                                                                                     matingPoolSize, tournamentSize, 
                                                                                     mutationProbability, mutationType);

            foreach (var result in algorithmResults)
            {
                algorithmResultsSB.Append(result.First + ";" + result.Second + Environment.NewLine);
            }
            WriteOutputToFile(path, algorithmResultsSB.ToString());
        }

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