using System;
using System.Collections.Generic;
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

        
     
    }

 }
