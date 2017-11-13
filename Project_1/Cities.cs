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
        private Random rand;
        private int numberOfCities;

        public int NumberOfCities
        {
            get
            {
                return numberOfCities; 
            
            }

        }

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


        public Cities(int _numberOfCities)
        {
            rand = new Random();
            numberOfCities = _numberOfCities;
            GenerateCities(numberOfCities);
         }

        public Cities(string path)
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

        private void GenerateCities(int numberOfCities)
        {
            int randomDistance;
            adjacencyMatrix = new int[numberOfCities, numberOfCities];

            //dopoki ilosc obecnych drog jest mniejsza od zadanej wielkosci grafu to generujemy kolejne drogi
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    //sprawdzenie czy droga istnieje juz w grafie oraz czy losowa droga nie jest petla
                    if (i != j)
                    {   //dodanie drogi
                        randomDistance = rand.Next(1, (2 * numberOfCities));
                        adjacencyMatrix[i, j] = randomDistance;
                    }
                    else
                    {
                        adjacencyMatrix[i, j] = INF;
                    }

                }

            }
            //aktualizacja pól charakteryzujących symulacją sieci miast

            this.numberOfCities = numberOfCities;
          
        }

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
            return matrixString;
        }

        
     
    }

 }
