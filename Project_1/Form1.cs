using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_1
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        Stream stream;
        int[,] matrix;
        string fileName;
        static int INF = Int32.MaxValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}", ts.TotalMilliseconds);
            textBox1.Text = "Czas: " + elapsedTime + "ms";
            stopWatch.Reset();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {   
            stopWatch.Start();
            textBox1.Text = "Start! ";

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                if (openFileDialog1.OpenFile() != null)
                {
                    fileName = openFileDialog1.FileName;
                    matrix = LoadMatrixFromFile(fileName);                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można odczytać pliku! Błąd: " + ex.Message);
            }
        }

        private void buttonGenShow_Click(object sender, EventArgs e)
        {
            try
            {
                Cities cities = new Cities(Int32.Parse(textBoxNumberOfCities.Text));
                string matrixString = "";
                for (int i = 0; i < cities.AdjacencyMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < cities.AdjacencyMatrix.GetLength(1); j++)
                    {
                        if (cities.AdjacencyMatrix[i, j] != INF)
                            matrixString += cities.AdjacencyMatrix[i, j].ToString();
                        else
                            matrixString += "INF";
                        matrixString += "  ";
                    }

                    matrixString += Environment.NewLine;
                }
                this.textBox1.Text = matrixString;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nie można wygenerować miast! Błąd: " + exception.Message);
            }      
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {                                   //           0    1   2   3   4   5   6   7   8   9  10  11  12  13  14
            int[,] testMatrix = new int[,]{     /* 0 */{INF, 29, 82, 46, 68, 52, 72, 42, 51, 55, 29, 74 ,23 ,72, 46},
                                                /* 1 */{29, INF, 55 ,46 ,42 ,43 ,43 ,23 ,23 ,31 ,41 ,51, 11, 52, 21},
                                                /* 2 */{82 , 55,INF, 68, 46, 55, 23, 43, 41 ,29, 79 ,21, 64, 31, 51},
                                                /* 3 */{46 ,46, 68, INF ,82 ,15, 72, 31, 62, 42, 21, 51, 51, 43, 64},
                                                /* 4 */{68 ,42 ,46 ,82, INF ,74, 23 ,52 ,21 ,46 ,82 ,58 ,46 ,65, 23},
                                                /* 5 */{52 ,43, 55, 15, 74, INF ,61 ,23 ,55 ,31 ,33 ,37 ,51, 29, 59},
                                                /* 6 */{72 ,43, 23 ,72, 23, 61 ,INF ,42 ,23 ,31, 77, 37 ,51 ,46 ,33},
                                                /* 7 */{42 ,23 ,43 ,31 ,52 ,23 ,42 ,INF ,33, 15 ,37 ,33 ,33 ,31 ,37},
                                                /* 8 */{51 ,23, 41 ,62, 21, 55 ,23 ,33, INF, 29 ,62 ,46, 29, 51 ,11},
                                                /* 9 */{55 ,31 ,29 ,42 ,46 ,31 ,31, 15, 29 ,INF ,51 ,21 ,41 ,23 ,37},
                                               /* 10 */{29 ,41, 79, 21, 82, 33, 77, 37, 62 ,51 ,INF, 65, 42, 59 ,61},
                                               /* 11 */{74 ,51 ,21 ,51 ,58 ,37 ,37 ,33 ,46 ,21 ,65 ,INF, 61 ,11 ,55},
                                               /* 12 */{23 ,11 ,64, 51, 46, 51, 51, 33, 29, 41 ,42 ,61 , INF, 62 ,23},
                                               /* 13 */{72 ,52 ,31 ,43 ,65 ,29 ,46 ,31 ,51 ,23 , 59 ,11 ,62, INF, 59},
                                               /* 14 */{46 ,21, 51, 64, 23 ,59 ,33 ,37, 11, 37,  61 ,55 ,23 ,59 ,INF}};


            testMatrix = new int[,]{            { INF,81,50,18,75,39,107,77,87,43 },
                                                { 81,INF,76,21,37,26,34,58,66,15  },
                                                { 50,76,INF,24,14,58,100,68,33,30 },
                                                { 18,21,24,INF,19,58,68,62,84,81  },
                                                { 75,37,14,19,INF,31,60,65,29,91  },
                                                { 39,26,58,58,31,INF,64,21,42,46  },
                                                { 107,34,100,68,60,64,INF,15,55,16},
                                                { 77,58,68,62,65,21,15,INF,17,34  },
                                                { 87,66,33,84,29,42,55,17,INF,68  },
                                                { 43,15,30,81,91,46,16,34,68,INF  },
                                          };
            /*

            testMatrix = new int[,]{{ INF,3,5 ,  48  , 48,8,8,5,5,3,3,0,3,5,8,8
,5},
{3 ,INF,3  , 48  , 48,8,8,5,5,0,0,3,0,3,8,8
,5},
{5,3, INF  , 72   ,72  , 48  , 48 ,  24   ,24,3,3,5,3,0 ,  48 ,  48,
   24},
   { 48  , 48  , 74 ,INF,0,6,6  , 12  , 12  , 48 ,  48  , 48   ,48,   74,6,6,
   12},
            { 48  , 48 ,  74,0 ,INF,6,6  , 12  , 12  , 48 ,  48   ,48   ,48  , 74,6,6,
   12},
            { 8,8 ,  50,6,6 ,INF,0,8,8,8,8,8,8 ,  50,0,0
,8},
            { 8,8  , 50,6,6,0 ,INF,8,8,8,8,8,8  , 50,0,0
,8},
            { 5,5,   26,   12,   12,8,8, INF,0,5,5,5,5  , 26,8,8
,0},
            { 5,5  , 26 ,  12 ,  12,8,8,0, INF,5,5,5,5   ,26,8,8
,0},
            { 3,0,3   ,48   ,48,8,8,5,5 ,INF,0,3,0,3,8,8
,5},
            { 3,0,3 ,  48  , 48,8,8,5,5,0 ,INF,3,0,3,8,8
,5},
            { 0,3,5 ,  48 ,  48,8,8,5,5,3,3, INF,3,5,8,8
,5},
            { 3,0,3 ,  48 ,  48,8,8,5,5,0,0,3 ,INF,3,8,8
,5},
            { 5,3,0  , 72 ,  72   ,48  , 48 ,  24  , 24,3,3,5,3, INF  , 48   ,48,
   24},
            { 8,8 ,  50,6,6,0,0,8,8,8,8,8,8 ,  50, INF,0
,8},
            { 8,8 ,  50,6,6,0,0,8,8,8,8,8,8  , 50,0 ,INF
,8},
            { 5,5  , 26  , 12 ,  12,8,8,0,0,5,5,5,5  , 26,8,8,
 INF} };

    */

            try
            {
                List<BranchAndBound.Pair<int, int[]>> solution = BranchAndBound.RunAlgorithm(matrix);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Błąd: " + exception.Message);
            }
        }

        private int[,] LoadMatrixFromFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int numberOfCities = 0;
                    string numberOfCitiesString = "";
                    int[,] matrix;
                    int character = sr.Read();
                    while (character >= 48 && character <= 57)
                    {
                        numberOfCitiesString += (char)character;
                        character = sr.Read();
                    }

                    if (!int.TryParse(numberOfCitiesString, out numberOfCities))
                    {
                        MessageBox.Show("Błędny format danych!");
                        return null;
                    }
                    //  ASCII   symbol
                    //  48      0
                    //  57      9
                    matrix = new int[numberOfCities, numberOfCities];
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
                                    MessageBox.Show("Błędny format danych!");
                                    return null;
                                }
                                if (i == j)
                                    currentWeight = Int32.MaxValue;
                                matrix[i, j] = currentWeight;
                            }
                            else
                                j--;
                        }
                    }
                    return matrix;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
