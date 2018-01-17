using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSP.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.Algorithms.Tests
{
    [TestClass()]
    public class GeneticTests
    {
        [TestMethod()]
        public void CrossoverTest()
        {
            //var indexes = new Pair<int, int>(2, 5);
            //var parents = new Pair<int[], int[]>(
            //                                     new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            //                                     new int[] { 5, 3, 6, 7, 8, 1, 2, 9, 4 });
            //var expected1 = new int[] { 4, 5, 6, 7, 8, 1, 9, 2, 3 };
            //var expected2 = new int[] { 8, 1, 3, 4, 5, 6, 2, 9, 7 };

            //var actual1 = Genetic.Crossover(indexes, parents).First;
            //var actual2 = Genetic.Crossover(indexes, parents).Second;

            var indexes = new Pair<int, int>(3, 6);
            var parents = new Pair<int[], int[]>(
                                                 new int[] { 9, 2, 5, 4, 1, 6, 3, 7, 8 },
                                                 new int[] { 8, 1, 6, 7, 2, 9, 4, 5, 3 });
            var expected1 = new int[] { 1, 6, 3, 7, 2, 9, 4, 8, 5 };
            var expected2 = new int[] { 7, 2, 9, 4, 1, 6, 3, 5, 8 };

            var actual1 = Genetic.Crossover(indexes, parents).First;
            var actual2 = Genetic.Crossover(indexes, parents).Second;

            CollectionAssert.AreEqual(expected1, actual1);
            CollectionAssert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void MutateTest()
        {
            var indexes1 = new Pair<int, int>(3, 6);
            var indexes2 = new Pair<int, int>(1, 3);
            var child1 = new int[] { 9, 2, 5, 4, 1, 6, 3, 7, 8 };
            var child2 = new int[] { 8, 1, 6, 7, 2, 9, 4, 5, 3 };
            var expected1 = new int[] { 9, 2, 5, 3, 6, 1, 4, 7, 8 };
            var expected2 = new int[] { 8, 7, 6, 1, 2, 9, 4, 5, 3 };

            //Genetic.Mutate(child1, indexes1);
            ///Genetic.Mutate(child2, indexes2);

            CollectionAssert.AreEqual(expected1, child1);
            CollectionAssert.AreEqual(expected2, child2);
        }

    }
}