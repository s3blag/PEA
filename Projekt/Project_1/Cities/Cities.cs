using System;
using System.IO;
using System.Text;

namespace TSP
{
    public class Cities
    {
        #region Fields and Properties
        public const int INF = Int32.MaxValue;

        public int[,] AdjacencyMatrix { get; set; }
        private int _bestDistance = -1;
        private Random _rand;
        private int _numberOfCities;

        public int BestDistance
        {
            get
            {
                return _bestDistance;
            }
            set
            {
                _bestDistance = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Konstruktor generujący instancję miast o losowych wagach i zadanym rozmiarze
        /// </summary>
        /// <param name="numberOfCities"> Ilość miast </param>
        /// <param name="min"> Dolny zakres losowania wag </param>
        /// <param name="max"> Górny zakres losowania wag </param>
        /// <param name="isAsync"> Zmienna mówiąca dla jakiego problemu mamy generować miasta: asymetrycznego, bądź symetrycznego </param>
        public Cities(int numberOfCities, int min, int max, bool isAsync)
        {
            _rand = new Random();
            _numberOfCities = numberOfCities;

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
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda odpowiedzialna za wizualizację macierzy miast 
        /// </summary>
        /// <returns> string przechowujący zwizualizowaną macierz sąsiedztwa </returns>
        public string ShowCities()
        {
            StringBuilder matrixSB = new StringBuilder();
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                {
                    if (AdjacencyMatrix[i, j] != INF)
                        matrixSB.Append(AdjacencyMatrix[i, j].ToString());
                    else
                        matrixSB.Append("INF");
                    matrixSB.Append("  ");
                }

                matrixSB.Append(Environment.NewLine);
            }
            if (_bestDistance > 0)
                matrixSB.Append("Najlepsze rozwiązanie: " + _bestDistance);
            return matrixSB.ToString();
        }
        #endregion

        #region Private Methods
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
                    _numberOfCities = 0;
                    string numberOfCitiesString = "";
                    int character = sr.Read();
                    while (character >= 48 && character <= 57)
                    {
                        numberOfCitiesString += (char)character;
                        character = sr.Read();
                    }

                    if (!int.TryParse(numberOfCitiesString, out _numberOfCities))
                    {
                        Console.WriteLine("Błędny format danych!");
                        return;
                    }

                    AdjacencyMatrix = new int[_numberOfCities, _numberOfCities];
                    for (int i = 0; i < _numberOfCities; i++)
                    {
                        for (int j = 0; j < _numberOfCities; j++)
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
                                AdjacencyMatrix[i, j] = currentWeight;
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
                    _numberOfCities = 0;
                    string numberOfCitiesString = "";
                    string bestDistanceString = "";
                    int character = sr.Read();
                    while (character >= 48 && character <= 57)
                    {
                        numberOfCitiesString += (char)character;
                        character = sr.Read();
                    }

                    if (!int.TryParse(numberOfCitiesString, out _numberOfCities))
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

                    if (!int.TryParse(bestDistanceString, out _bestDistance))
                    {
                        Console.WriteLine("Błędny format danych!");
                        return;
                    }


                    AdjacencyMatrix = new int[_numberOfCities, _numberOfCities];
                    for (int i = 0; i < _numberOfCities; i++)
                    {
                        for (int j = 0; j < _numberOfCities; j++)
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
                                AdjacencyMatrix[i, j] = currentWeight;
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
            AdjacencyMatrix = new int[numberOfCities, numberOfCities];

            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    if (i != j)
                    { 
                        randomDistance = _rand.Next(min, max + 1);
                        AdjacencyMatrix[i, j] = randomDistance;
                    }
                    else
                        AdjacencyMatrix[i, j] = INF;
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
            AdjacencyMatrix = new int[numberOfCities, numberOfCities];

            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    if (AdjacencyMatrix[i, j] == 0)
                        if (i != j)
                        {
                            randomDistance = _rand.Next(min, max + 1);
                            AdjacencyMatrix[i, j] = randomDistance;
                            AdjacencyMatrix[j, i] = randomDistance;
                        }
                        else
                            AdjacencyMatrix[i, j] = INF;
                }
            }
        }
        #endregion

    }
}
