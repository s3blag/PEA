using System;
using System.Collections.Generic;


namespace TSP.Algorithms
{
    static public class Genetic
    {
        #region Fields

        private static Random rand = new Random();
        
        #endregion

        #region Public Methods
        public static string RunAlgorithm(Cities cities, int populationSize)
        {
            var population = new List<int[]>(populationSize);

            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods

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
