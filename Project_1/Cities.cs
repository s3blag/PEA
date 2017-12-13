using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Cities
    {
        public const int INF = Int32.MaxValue;

        private int[,] adjacencyMatrix;
        private int bestDistance = -1;
        private Random rand;
        private int numberOfCities;

        //akcesor
        public int BestDistance
        {
            get
            {
                return bestDistance;
            }
        }

        //akcesor
        public int NumberOfCities
        {
            get
            {
                return numberOfCities; 
            }

        }

        //akcesor
        public int[,] AdjacencyMatrix
        {
            get
            {
                return adjacencyMatrix;
            }

            set
            {
                adjacencyMatrix = value;
            }
        }
        
        /// <summary>
        /// Konstruktor generujący instancję miast o losowych wagach i zadanym rozmiarze
        /// </summary>
        /// <param name="numberOfCities"> Ilość miast </param>
        /// <param name="min"> Dolny zakres losowania wag </param>
        /// <param name="max"> Górny zakres losowania wag </param>
        /// <param name="isAsync"> Zmienna mówiąca dla jakiego problemu mamy generować miasta: asymetrycznego, bądź symetrycznego </param>
        public Cities(int numberOfCities, int min, int max, bool isAsync)
        {
            rand = new Random();
            this.numberOfCities = numberOfCities;

            if (isAsync)
                GenerateAsynchronousCities(numberOfCities, min, max);
            else
                GenerateSynchronousCities(numberOfCities, min, max);
        }

        /// <summary>
        /// Konstruktor wczytujący miasta z zadanego pliku
        /// </summary>
        /// <param name="path"></param>
        public Cities(string path, bool isFromTSPLIB)
        {   
            if(isFromTSPLIB)
                ReadCitiesFromTspFile(path);
            else
                ReadCitiesFromFile(path);
        }

        /// <summary>
        /// Metoda wczytująca miasta z zadanego pliku
        /// </summary>
        /// <param name="path"> Ścieżka do pliku </param>
        private void ReadCitiesFromFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    numberOfCities = 0;
                    string numberOfCitiesString = "";
                    int character = sr.Read();
                    while (character >= 48 && character <= 57)
                    {
                        numberOfCitiesString += (char)character;
                        character = sr.Read();
                    }

                    if (!int.TryParse(numberOfCitiesString, out numberOfCities))
                    {
                        Console.WriteLine("Błędny format danych!");
                        return;
                    }

                    adjacencyMatrix = new int[numberOfCities, numberOfCities];
                    for (int i = 0; i < numberOfCities; i++)
                    {
                        for (int j = 0; j < numberOfCities; j++)
                        {
                            string numberString = "";
                            character = sr.Read();
                            int currentWeight;
                            while ((character >= 48 && character <= 57) || character == 45)
                            {
                                numberString += (char)character;
                                character = sr.Read();
                            }
                            if (numberString != "")
                            {
                                if (!int.TryParse(numberString, out currentWeight))
                                {
                                    Console.WriteLine("Błędny format danych!");
                                    return;
                                }
                                if (i == j)
                                    currentWeight = INF;
                                adjacencyMatrix[i, j] = currentWeight;
                            }
                            else
                                j--;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Metoda wczytująca miasta z zadanego pliku
        /// </summary>
        /// <param name="path"> Ścieżka do pliku </param>
        private void ReadCitiesFromTspFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    numberOfCities = 0;
                    string numberOfCitiesString = "";
                    string bestDistanceString = "";
                    int character = sr.Read();
                    while (character >= 48 && character <= 57)
                    {
                        numberOfCitiesString += (char)character;
                        character = sr.Read();
                    }

                    if (!int.TryParse(numberOfCitiesString, out numberOfCities))
                    {
                        Console.WriteLine("Błędny format danych!");
                        return;
                    }

                    character = sr.Read();

                    while (character >= 48 && character <= 57)
                    {
                        bestDistanceString += (char)character;
                        character = sr.Read();
                    }

                    if (!int.TryParse(bestDistanceString, out bestDistance))
                    {
                        Console.WriteLine("Błędny format danych!");
                        return;
                    }


                    adjacencyMatrix = new int[numberOfCities, numberOfCities];
                    for (int i = 0; i < numberOfCities; i++)
                    {
                        for (int j = 0; j < numberOfCities; j++)
                        {
                            string numberString = "";
                            character = sr.Read();
                            int currentWeight;
                            while ((character >= 48 && character <= 57) || character == 45)
                            {
                                numberString += (char)character;
                                character = sr.Read();
                            }
                            if (numberString != "")
                            {
                                if (!int.TryParse(numberString, out currentWeight))
                                {
                                    Console.WriteLine("Błędny format danych!");
                                    return;
                                }
                                if (i == j)
                                    currentWeight = INF;
                                adjacencyMatrix[i, j] = currentWeight;
                            }
                            else
                                j--;
                        }
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Metoda generująca miasta dla asynchronicznego problemu komiwojażera
        /// </summary>
        /// <param name="numberOfCities"> Ilość miast </param>
        /// <param name="min"> Dolny zakres losowania wag </param>
        /// <param name="max"> Górny zakres losowania wag </param>
        private void GenerateAsynchronousCities(int numberOfCities, int min, int max)
        {
            int randomDistance;
            adjacencyMatrix = new int[numberOfCities, numberOfCities];

            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    if (i != j)
                    { 
                        randomDistance = rand.Next(min, max + 1);
                        adjacencyMatrix[i, j] = randomDistance;
                    }
                    else
                        adjacencyMatrix[i, j] = INF;
                }
            }
        }

        /// <summary>
        /// Metoda generująca miasta dla synchronicznego problemu komiwojażera
        /// </summary>
        /// <param name="numberOfCities"> Ilość miast </param>
        /// <param name="min"> Dolny zakres losowania wag </param>
        /// <param name="max"> Górny zakres losowania wag </param>
        private void GenerateSynchronousCities(int numberOfCities, int min, int max)
        {
            int randomDistance;
            adjacencyMatrix = new int[numberOfCities, numberOfCities];

            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    if (adjacencyMatrix[i, j] == 0)
                        if (i != j)
                        {
                            randomDistance = rand.Next(min, max + 1);
                            adjacencyMatrix[i, j] = randomDistance;
                            adjacencyMatrix[j, i] = randomDistance;
                        }
                        else
                            adjacencyMatrix[i, j] = INF;
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za wizualizację macierzy miast 
        /// </summary>
        /// <returns> string przechowujący zwizualizowaną macierz sąsiedztwa </returns>
        public string ShowCities()
        {
            string matrixString = "";
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                {
                    if (AdjacencyMatrix[i, j] != INF)
                        matrixString += AdjacencyMatrix[i, j].ToString();
                    else
                        matrixString += "INF";
                    matrixString += "  ";
                }

                matrixString += Environment.NewLine;
            }
            if (bestDistance > 0)
                matrixString += "Najlepsze rozwiązanie: " + bestDistance;
            return matrixString;
        }

    }
 }
