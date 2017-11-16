using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;

namespace Project_1
{
   
    static internal class BranchAndBound
    {
        private const int INF = Int32.MaxValue;

        /// <summary>
        /// Węzeł drzewa rozwiązań
        /// </summary>
        struct Node
        {
            public Node(Pair<int, int[]>[,] newMatrix, int newLowerBound, List<Pair<int, int[]>> newExcludedCities)
            {
                this.matrix = newMatrix;
                this.lowerBound = newLowerBound;
                this.excludedPaths = newExcludedCities;
            }

            /// <summary>
            /// Macierz pary - (Waga na danej pozycji, oryginalne współrzędne)
            /// </summary>
            public Pair<int, int[]>[,] matrix;
            /// <summary>
            /// Dolne ograniczenie danego węzła
            /// </summary>
            public int lowerBound;
            /// <summary>
            /// Lista wyłączonych miast - służy do odczytu ścieżki rozwiązania
            /// </summary>
            public List<Pair<int, int[]>> excludedPaths;
            
        }

        class Pair<T, U>
        {
            public Pair()
            {
            }

            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }
        };

        /// <summary>
        /// Redukcja wierszy oraz kolumn macierzy
        /// </summary>
        /// <param name="node"> Węzeł, którego macierz chcemy zredukować</param>
        /// <returns> Stopień redukcji </returns>
        private static int ReduceMatrix(Node node)
        {
            Pair<int, int[]>[,] matrix = node.matrix;
            int reductionLevel = 0;
            reductionLevel += ReduceRow(matrix);
            reductionLevel += ReduceColumn(matrix);

            return reductionLevel;
        }

        /// <summary>
        /// Redukcja wiersza macierzy
        /// </summary>
        /// <param name="matrix"> Macierz, której wiersz chcemy zredukować </param>
        /// <returns> Stopień redukcji(Suma wartości, o które zredukowaliśmy kolumny) </returns>
        private static int ReduceRow(Pair<int, int[]>[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                min = INF;
                //znalezienie wartości minimalnej dla danego wiersza
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].First < min)
                        min = matrix[i, j].First;
                }

                //usunięcie min od wag wszystkich kolumn danego wiersza
                if (min != 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j].First != INF)
                            matrix[i, j].First -= min;
                    }
                    reductionLevel += min;
                }
            }

            return reductionLevel;
        }
        /// <summary>
        /// Redukcja kolumny macierzy
        /// </summary>
        /// <param name="matrix"> Macierz, której wiersz chcemy zredukować </param>
        /// <returns> Stopień redukcji(Suma wartości, o które zredukowaliśmy wiersze) </returns>
        private static int ReduceColumn(Pair<int, int[]>[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                min = INF;
                //znalezienie wartości minimalnej dla danej kolumny
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i].First < min)
                        min = matrix[j, i].First;
                }

                //usunięcie min od wag wszystkich wierszy danej kolumny
                if (min != 0)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[j, i].First != INF)
                            matrix[j, i].First -= min;
                    }
                    reductionLevel += min;
                }
            }

            return reductionLevel;
        }
       
        /// <summary>
        /// Podział węzła na dwa nowe: 
        /// 1. Ze zredukowaną macierzą
        /// 2. Ze zmodyfikowaną macierzą
        /// </summary>
        /// <param name="node"> Węzeł, na którym chcemy wykonać podział </param>
        /// <returns> Para nowych węzłów </returns>
        private static Pair<Node, Node> DivideMatrix(Node node)
        {
            Pair<int, int[]>[,] matrix = node.matrix;
            int currentMaxCost = 0;
            int[] currentSolution = new int[2];
            int currentCost;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].First == 0)
                    {
                        currentCost = FindExclusionCost(matrix, i, j);
                        if (currentCost > currentMaxCost)
                        {
                            currentSolution[0] = i;
                            currentSolution[1] = j;
                            currentMaxCost = currentCost;
                        }
                    }
                }                 
            }

            //Tworzenie dwóch nowych węzłów
            Node newNode1 = DeleteSelectedPaths(node, currentSolution);
            Node newNode2 = BlockPath(node, currentSolution);

            Pair<Node, Node> nodes = new Pair<Node, Node>(newNode1, newNode2);
            nodes.First = newNode1;
            nodes.Second = newNode2;

            return nodes;
        }

        /// <summary>
        /// Tworzenie nowego węzła ze zredukowaną ilością wierszy i kolumn macierzy
        /// </summary>
        /// <param name="node"> Węzeł, na podstawie którego tworzymy nowy, zredukowany węzeł </param>
        /// <param name="coordinatesToDelete"> Współrzędne wiersza i kolumny do usunięcia (pominięcia przy kopiowaniu) </param>
        /// <returns></returns>
        private static Node DeleteSelectedPaths(Node node, int[] coordinatesToDelete)
        {
            Pair<int, int[]>[,] matrix = node.matrix;
            Pair<int, int[]>[,] newMatrix = new Pair<int, int[]>[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

            int newRowIndex = 0, newColumnIndex = 0, originalCurrentRowIndex = 0, originalCurrentColumnIndex = 0;
            int originalDeletedColumnIndex = matrix[coordinatesToDelete[0], coordinatesToDelete[1]].Second[1];
            int originalDeletedRowIndex = matrix[coordinatesToDelete[0], coordinatesToDelete[1]].Second[0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == coordinatesToDelete[0])
                        break;
                    if (j == coordinatesToDelete[1])
                        continue;

                    newRowIndex = i;
                    newColumnIndex = j;

                    //obranie offsetu indeksu, w przypadku wcześniejszego usunięcia kolumny/wiersza
                    if (i > coordinatesToDelete[0])
                        newRowIndex = i - 1;
                    if (j > coordinatesToDelete[1])
                        newColumnIndex = j - 1;

                    originalCurrentColumnIndex = matrix[i, j].Second[1];
                    originalCurrentRowIndex = matrix[i, j].Second[0];
                    
                    if (originalCurrentRowIndex == originalDeletedColumnIndex && originalCurrentColumnIndex == originalDeletedRowIndex)
                        newMatrix[newRowIndex, newColumnIndex] = new Pair<int, int[]>(INF, matrix[i, j].Second);
                    else
                        newMatrix[newRowIndex, newColumnIndex] = new Pair<int, int[]>(matrix[i, j].First, matrix[i, j].Second);
                }
            }

            Node newNode = new Node(newMatrix, node.lowerBound, new List<Pair<int, int[]>>());
            //kopiowanie listy usuniętych ścieżek
            for (int i = 0; i < node.excludedPaths.Count; i++)
                newNode.excludedPaths.Add(node.excludedPaths[i]);
            //dodanie usuniętej pary (wiersz,kolumna) do nowo powstałego węzła
            newNode.excludedPaths.Add(matrix[coordinatesToDelete[0], coordinatesToDelete[1]]);

            return newNode;
        }

        /// <summary>
        /// Tworzenie nowego węzła z zablokowaną wybraną ścieżką
        /// </summary>
        /// <param name="node"> Węzeł, na podstawie którego tworzymy nowy, zmodyfikowany węzeł </param>
        /// <param name="coordinatesToDelete"> Ścieżka, którą mamy zablokować </param>
        /// <returns> Nowy węzeł z zablokowaną ścieżką </returns>
        private static Node BlockPath(Node node, int[] coordinatesToDelete)
        {
            Pair<int, int[]>[,] matrix = node.matrix;
            Pair<int, int[]>[,] newMatrix = new Pair<int, int[]>[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = new Pair<int, int[]>(matrix[i, j].First, matrix[i, j].Second);
                }
            }

            newMatrix[coordinatesToDelete[0], coordinatesToDelete[1]].First = INF;
            Node newNode = new Node(newMatrix, 0, new List<Pair<int, int[]>>());
            //kopiowanie listy usuniętych ścieżek
            for (int i = 0; i < node.excludedPaths.Count; i++)
                newNode.excludedPaths.Add(node.excludedPaths[i]);

            return newNode;
        }

        /// <summary>
        /// Znalezienie kosztu wyłączenia danej kolumny i wiersza macierzy
        /// </summary>
        /// <param name="matrix"> Macierz, którą będziemy badać </param>
        /// <param name="row"> Wiersz, dla którego będziemy szukać kosztu wyłączenia </param>
        /// <param name="column"> Kolumna, dla której będziemy szukać kosztu wyłączenia </param>
        /// <returns> Koszt wyłączenia danej kolumny i wiersza </returns>
        private static int FindExclusionCost(Pair<int, int[]>[,] matrix, int row, int column)
        {   
            int currentMinCost = INF;
            int totalCost = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i == column)
                    continue;
                if (matrix[row, i].First < currentMinCost)
                    currentMinCost = matrix[row, i].First;
            }
            if (currentMinCost != INF)
                totalCost += currentMinCost;
            else
                totalCost = INF;

            currentMinCost = INF;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == row)
                    continue;
                if (matrix[i, column].First < currentMinCost)
                    currentMinCost = matrix[i, column].First;
            }
            if (currentMinCost != INF && totalCost!= INF)
                totalCost += currentMinCost;

            return totalCost;
        }

        /// <summary>
        /// Metoda, w której wykonuje się całość algorytmu
        /// </summary>
        /// <param name="matrix"> Macierz miast, dla której zostanie uruchomiony algorytm </param>
        /// <returns> Rozwiązanie problemu metodą podziału i ograniczeń </returns>
        public static string RunAlgorithm(int[,] matrix)
        {
            SimplePriorityQueue<Node> treeq = new SimplePriorityQueue<Node>();
            //Przygotowanie macierzy miast
            Node firstNode = PrepareMatrix(matrix);
            Node lastNode = firstNode;
            Node currentNode = firstNode;
            treeq.Enqueue(firstNode, firstNode.lowerBound);

            while (currentNode.matrix.GetLength(1) != 2)
            {
                currentNode = treeq.Dequeue();
                Pair<Node, Node> newNodes = DivideMatrix(currentNode);
                
                Node firstDividedNode = newNodes.First;
                Node secondDividedNode = newNodes.Second;

                //Redukcja węzła z macierzą zredukowaną oraz aktualizacja jego dolnego ograniczenia
                int tempReductionLevel = ReduceMatrix(firstDividedNode);
                if (tempReductionLevel != INF && currentNode.lowerBound != INF)
                    firstDividedNode.lowerBound = tempReductionLevel + currentNode.lowerBound;
                else
                    firstDividedNode.lowerBound = INF;

                //Redukcja węzła z macierzą o zablokowanej drodze oraz aktualizacja jego dolnego ograniczenia
                tempReductionLevel = ReduceMatrix(secondDividedNode);
                if (tempReductionLevel != INF && currentNode.lowerBound != INF)
                    secondDividedNode.lowerBound = tempReductionLevel + currentNode.lowerBound;
                else
                    secondDividedNode.lowerBound = INF;
                
                //Dodanie obu węzłów do drzewa rozwiązań
                treeq.Enqueue(firstDividedNode, firstDividedNode.lowerBound);
                treeq.Enqueue(secondDividedNode, secondDividedNode.lowerBound);

                if (currentNode.matrix.GetLength(1) == 2)
                    lastNode = firstDividedNode;
            }
            //Operacje na węźle o rozmiarze macierzy = 1
            Node solutionNode = new Node(null, lastNode.lowerBound, lastNode.excludedPaths);
            int solutionNodeReductionLevel = ReduceMatrix(lastNode);
            if (solutionNodeReductionLevel != INF && lastNode.lowerBound != INF)
                solutionNode.lowerBound = solutionNodeReductionLevel + lastNode.lowerBound;
            else
                solutionNode.lowerBound = INF;
            lastNode.excludedPaths.Add(new Pair<int, int[]>(0, lastNode.matrix[0, 0].Second));

            //Zwrócenie wyniku działania algorytmu
            return ShowSolution(solutionNode);
        }

        /// <summary>
        /// Przygotowanie macierzy miast(sąsiedztwa) do pracy z algorytmem
        /// </summary>
        /// <param name="matrix"> Macierz sąsiedztwa </param>
        /// <returns> Węzeł początkowy algorytmu </returns>
        private static Node PrepareMatrix(int[,] matrix)
        {
            int matrixLength = matrix.GetLength(0);
            Pair<int, int[]>[,] preparedMatrix = new Pair<int, int[]>[matrixLength, matrixLength];

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    preparedMatrix[i, j] = new Pair<int, int[]>(matrix[i, j], new int[2]);
                    preparedMatrix[i, j].Second[0] = i;
                    preparedMatrix[i, j].Second[1] = j;
                }
            }
            Node node = new Node(preparedMatrix, 0, new List<Pair<int, int[]>>());
            node.lowerBound = ReduceMatrix(node);
            
            return node;
        }


        /// <summary>
        /// Generacja wizualizacji rozwiązania w postaci ścieżek będących rozwiązaniem
        /// </summary>
        /// <param name="solutionNode"> Węzeł będący rozwiązaniem </param>
        /// <returns> Ciąg krawędzi będących rozwiązaniem oraz koszt podróży </returns>
        private static string ShowSolution(Node solutionNode)
        {
           
            List<Pair<int, int[]>> list = solutionNode.excludedPaths;

            string solution = Environment.NewLine + "Rozwiązanie:" + Environment.NewLine;

            foreach (var path in list)
            {   
                solution += (" <" + path.Second[0].ToString() + " ; " + path.Second[1].ToString() + "> ");
            }

            solution += Environment.NewLine;
            solution += "Całkowity koszt: " + solutionNode.lowerBound;

            return solution;
        }
    }
}
