using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        Stream stream;

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
        {
            int[,] testMatrix = new int[,] { { INF, 2, 7, 3 },
                                             { 7, INF, 8, 5 },
                                             { 9, 4, INF, 6 },
                                             { 3, 8, 5, INF}};
            try
            {   


                BranchAndBound.Pair<int, int[]>[,] preparedMatrix = BranchAndBound.PrepareMatrix(testMatrix);
                BranchAndBound.ReduceMatrix(preparedMatrix);
                BranchAndBound.Pair<BranchAndBound.Node, BranchAndBound.Node> node = BranchAndBound.DivideMatrix(preparedMatrix);
                //MessageBox.Show(solution[0].ToString() + " " + solution[1].ToString());

                
                string matrixString = "";
                for (int i = 0; i < preparedMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < preparedMatrix.GetLength(1); j++)
                    {
                        if (preparedMatrix[i, j].First != INF)
                            matrixString += preparedMatrix[i, j].First.ToString();
                        else
                            matrixString += "INF";
                        matrixString += "  ";
                    }

                matrixString += Environment.NewLine;
                }
                matrixString += Environment.NewLine;
                this.textBox1.Text += matrixString;



                // Wyswietlenie nowo powstalego node-a z DivideMatrix -> DeleteRoad
                BranchAndBound.Pair<int, int[]>[,] firstNode = node.First.matrix;
                matrixString = "";
                matrixString += Environment.NewLine;
                for (int i = 0; i < firstNode.GetLength(0); i++)
                {
                    for (int j = 0; j < firstNode.GetLength(1); j++)
                    {
                        if (firstNode[i, j].First != INF)
                            matrixString += firstNode[i, j].First.ToString();
                        else
                            matrixString += "INF";
                        matrixString += "  ";
                    }

                    matrixString += Environment.NewLine;
                }
                this.textBox1.Text += matrixString;


                // Wyswietlenie nowo powstalego node-a z DivideMatrix -> BlockRoad
                BranchAndBound.Pair<int, int[]>[,] secondNode = node.Second.matrix;
                matrixString = "";
                matrixString += Environment.NewLine;
                for (int i = 0; i < secondNode.GetLength(0); i++)
                {
                    for (int j = 0; j < secondNode.GetLength(1); j++)
                    {
                        if (secondNode[i, j].First != INF)
                            matrixString += secondNode[i, j].First.ToString();
                        else
                            matrixString += "INF";
                        matrixString += "  ";
                    }

                    matrixString += Environment.NewLine;
                }
                this.textBox1.Text += matrixString;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Błąd: " + exception.Message);
            }
        }
    }
}
