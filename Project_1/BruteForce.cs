using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    static internal class BruteForce
    {
        private const int INF = Int32.MaxValue;

        public static string RunAlgorithm(Cities cities)
        {
            int[,] adjacencyMatrix = cities.AdjacencyMatrix;
            int numberOfCities = cities.AdjacencyMatrix.GetLength(0);
            int tempDistance = 0;
            int shortestDistance = INF;
            List<int> indexes = new List<int>(numberOfCities - 1);
            List<int> bestPath = new List<int>(numberOfCities - 1);

            //inicjalizacja wektora indeksow, ktory b�dzie u�ywany do permutowania kolejno�ci odwiedzania miast	
            for (int i = 0; i < numberOfCities - 1; i++)
                indexes.Add(i + 1);
            int[] perm = indexes.ToArray();
            do
            {
                indexes = perm.ToList();
                //wyznaczanie drogi dla okre�lonej kolejno�ci odwiedzania miast

                tempDistance += adjacencyMatrix[0, indexes[0]];

                for (int i = 0; i < numberOfCities - 1; i++)
                {
                    if (i == numberOfCities - 2)
                        tempDistance += adjacencyMatrix[indexes[i], 0];
                    else
                        tempDistance += adjacencyMatrix[indexes[i], indexes[i + 1]];
                }

                //sprawdzenie czy dane rozwi�zanie jest jak dot�d najlepsze
                if (tempDistance < shortestDistance)
                {
                    bestPath = indexes;
                    bestPath.Add(0);
                    shortestDistance = tempDistance;
                }

                tempDistance = 0;
                
            } while (next_permutation(perm));

            return GetResults(bestPath, shortestDistance);

        }

        public static string GetResults(List<int> shortestPath, int distance)
        {
            string solution = "";
            
            for(int i = 0; i < shortestPath.Count; i++)
            {
                solution += shortestPath[i] + "  ";
            }
            solution += Environment.NewLine;
            solution += "Dystans: " + distance;
            return solution;
        }

        static public bool next_permutation(int[] perm)

        {

            int n = perm.Length;

            int k = -1;

            for (int i = 1; i < n; i++)

                if (perm[i - 1] < perm[i])

                    k = i - 1;

            if (k == -1)

            {

                for (int i = 0; i < n; i++)

                    perm[i] = i;

                return false;

            }



            int l = k + 1;

            for (int i = l; i < n; i++)

                if (perm[k] < perm[i])

                    l = i;



            int t = perm[k];

            perm[k] = perm[l];

            perm[l] = t;



            Array.Reverse(perm, k + 1, perm.Length - (k + 1));


            return true;

        }
    }
}
