using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_1
{
   
    abstract class BranchAndBound
    {
        private const int INF = Int32.MaxValue;

       //na private
        public struct Node
        {
            public Pair<int, int[]>[,] matrix;
            public int lowerBound;
            public List<Pair<int, int[]>> excludedCities;
            public bool leaf;
            public Node(Pair<int, int[]>[,] newMatrix, int newLowerBound, List<Pair<int, int[]>> newExcludedCities)
            {
                matrix = newMatrix;
                lowerBound = newLowerBound;
                excludedCities = newExcludedCities;
                leaf = true;
            }
        }

        //na private
        public class Pair<T, U>
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


        //zmienic na private
        public static void ReduceMatrix(Node node)
        {
            Pair<int, int[]>[,] matrix = node.matrix;
            int reductionLevel = 0;
            reductionLevel += ReduceRow(matrix);
            reductionLevel += ReduceColumn(matrix);

            node.lowerBound += reductionLevel;
        }

        private static int ReduceRow(Pair<int, int[]>[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                min = INF;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j].First < min)
                    {
                        min = matrix[i, j].First;
                    }
                }

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

        private static int ReduceColumn(Pair<int, int[]>[,] matrix)
        {
            int min;
            int reductionLevel = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                min = INF;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {

                    if (matrix[j, i].First < min)
                    {
                        min = matrix[j, i].First;
                    }
                }

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

        //zmienic na private
        //public static int[] DivideMatrix(Pair<int, int[]>[,] matrix)
        public static Pair<Node, Node> DivideMatrix(Node node)
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
                        currentCost = FindMaxExclusionCost(matrix, i, j);
                        if (FindMaxExclusionCost(matrix, i, j) > currentMaxCost)
                        {
                            currentSolution[0] = i;
                            currentSolution[1] = j;
                            currentMaxCost = currentCost;
                        }
                    }
                }                 
            }

            //obcieta macierz
            Node newNode1 = DeleteRoads(node, currentSolution);
            Node newNode2 = BlockRoad(node, currentSolution);
            Pair<Node, Node> nodes = new Pair<Node, Node>(newNode1, newNode2);
            nodes.First = newNode1;
            nodes.Second = newNode2;
            return nodes;
        }


        private static Node DeleteRoads(Node node, int[] coordinatesToDelete)
        {
            Pair<int, int[]>[,] matrix = node.matrix;
            Pair<int, int[]>[,] newMatrix = new Pair<int, int[]>[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            Console.Write(coordinatesToDelete[0]);
            Console.Write(coordinatesToDelete[1] + " ");
            Console.Write(Environment.NewLine);

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
            for (int i = 0; i < node.excludedCities.Count; i++)
                newNode.excludedCities.Add(node.excludedCities[i]);
            newNode.excludedCities.Add(matrix[coordinatesToDelete[0], coordinatesToDelete[1]]);
            //trzeba zawrzeć w tym lowerBound, liste usunietych miast -> wejsc o poziom wyzej = przejsc z funkcjami by obrabialy node, a nie matrix
            return newNode;
        }

        private static Node BlockRoad(Node node, int[] coordinatesToDelete)
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
            for (int i = 0; i < node.excludedCities.Count; i++)
                newNode.excludedCities.Add(node.excludedCities[i]);
            newNode.excludedCities.Add(matrix[coordinatesToDelete[0], coordinatesToDelete[1]]);
            return newNode;
        }

        private static int FindMaxExclusionCost(Pair<int, int[]>[,] matrix, int row, int column)
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

            totalCost += currentMinCost;
            currentMinCost = INF;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == row)
                    continue;
                if (matrix[i, column].First < currentMinCost)
                    currentMinCost = matrix[i, column].First;
            }

            totalCost += currentMinCost;

            return totalCost;
        }

        public static List<Pair<int, int[]>> RunAlgorithm(int[,] matrix)
        {
            List<Pair<int, int[]>> solution = new List<Pair<int, int[]>>();
            List<Node> tree = new List<Node>();
            Node firstNode = PrepareMatrix(matrix);
            tree.Add(firstNode);
            // Pętla for tylko na potrzeby testu, normalnie tu powinien być jakiś while
            for(int i = 0; i < 3; i++)
            {
                int currentNodeIndex = RefreshTree(tree);
                Node currentNode = tree[currentNodeIndex];
                Pair<Node, Node> newNodes = DivideMatrix(currentNode);
                tree.RemoveAt(currentNodeIndex);
                ReduceMatrix(newNodes.First);
                ReduceMatrix(newNodes.Second);
                tree.Add(newNodes.First);
                tree.Add(newNodes.Second);
            }
            //Node firstNode = new Node(preparedMatrix = PrepareMatrix(matrix), ReduceMatrix(preparedMatrix), new List<Pair<int, int[]>>());

            return solution;
        }

        private static int RefreshTree(List<Node> tree)
        {
            int currentMinLowerBound = INF;
            int currentSolution = 0;
            for(int currentNode = 0; currentNode < tree.Count; currentNode++)
            {                
                    if (tree[currentNode].lowerBound < currentMinLowerBound)
                        currentSolution = tree[currentNode].lowerBound;                
            }
            return currentSolution;
        }

        public static Node PrepareMatrix(int[,] matrix)
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
            ReduceMatrix(node);
            return node;
        }

    }
}
