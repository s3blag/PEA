using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    abstract internal class Test
    {
        public static void RunTest(int size, int lowerWeight, int maxWeight, int numberOfTrials, string path)
        {
            string output = "";
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i < numberOfTrials; i++)
            {                
                Cities cities = new Cities(size, lowerWeight, maxWeight, true);
                Console.WriteLine("Próba: " + i.ToString());

                stopWatch.Start();
                BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);
                stopWatch.Stop();

                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}", ts.TotalMilliseconds);
                output += elapsedTime + Environment.NewLine;

                stopWatch.Reset();
            }
            WriteOutputToFile(path, output);
        }

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
