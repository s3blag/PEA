using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using TSP.Algorithms;
using TSP.Tests;

namespace TSP
{
    public partial class Form1 : Form
    {
        #region Fields
        Stopwatch stopWatch = new Stopwatch();
        Cities cities;
        string fileName;
        #endregion

        #region Constructors
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxOutputPathBnBTest.Text = Directory.GetCurrentDirectory() + "\\test.txt";
            textBoxOutputPathTimestampTabuTest.Text = Directory.GetCurrentDirectory() + "\\test.txt";
            buttonLoadFileGenetic.Click += OpenTSPFile;
            buttonLoadFileTimestampTabuTest.Click += OpenTSPFile;
            buttonStartImprovementByTimeTabuTest.Click += OpenTSPFile;
            buttonSelectOutputPathTimeStampTabuTest.Click += SelectOutputPath;
            buttonSelectOutputPathBnBTest.Click += SelectOutputPath;
            buttonLoadFileGeneticTest.Click += OpenTSPFile;
        }
        #endregion

        #region I/O
        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                if (openFileDialog.OpenFile() != null)
                {
                    fileName = openFileDialog.FileName;
                    cities = new Cities(fileName, true);
                    //textBox1.Text = cities.ShowCities();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można odczytać pliku! Błąd: " + ex.Message);
            }
        }

        private void OpenTSPFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                if (openFileDialog.OpenFile() != null)
                {
                    fileName = openFileDialog.FileName;
                    cities = new Cities(fileName, true);
                    switch (tabControl.SelectedTab.Text)
                    {
                        case "Tabu Search":
                            textBoxTabu.Text = cities.ShowCities();
                            break;
                        case "Genetic":
                            textBoxGenetic.Text = cities.ShowCities();
                            break;
                    }

                    var button = (Button)sender;
                    switch (button.Name)
                    {
                        case "buttonImprovementByTimeTabuTest":
                            buttonStartImprovementByTimeTabuTest_FileOpened();
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można odczytać pliku! Błąd: " + ex.Message);
            }
        }

        private void SelectOutputPath(object sender, EventArgs e)
        {
            var button = (Button)sender;
            TextBox textBox;

            switch (button.Name)
            {
                case "buttonSelectOutputPathTimeStampTabuTest":
                    textBox = textBoxOutputPathTimestampTabuTest;
                    break;
                case "buttonSelectOutputPathBnBTest":
                    textBox = textBoxOutputPathBnBTest;
                    break;
                default:
                    return;
            }

            saveFileDialog.ShowDialog();
            try
            {
                textBox.Text = saveFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Run Algorithm
        private void buttonRunBnB_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxBnB.Text += Algorithms.BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd: Źle podane wartości! ");
            }
        }

        private void buttonRunRandomCitiesBnB_Click(object sender, EventArgs e)
        {
            try
            {
                cities = new Cities(Int32.Parse(textBoxNumberOfCitiesBnB.Text),1,100, radioBnBAsync.Checked);
                textBoxBnB.Text = cities.ShowCities();
                textBoxBnB.Text += Algorithms.BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nie można wygenerować miast! Błąd: " + exception.Message);
            }      
        }

        private void buttonRunTabu_Click(object sender, EventArgs e)
        {
            textBoxTabu.Text = "";
            textBoxTabu.Text += cities.ShowCities() + Environment.NewLine;
            textBoxTabu.Text += Environment.NewLine + "-------------------   TABU   ---------------------" + Environment.NewLine;
            textBoxTabu.Text += TabuSearch.RunAlgorithm(cities.AdjacencyMatrix, (int)Math.Ceiling((double)cities.AdjacencyMatrix.GetLength(0) / 10), cities.AdjacencyMatrix.GetLength(0));
        }
        #endregion

        #region Algorithms Tests
        private void buttonStartBnBTest_Click(object sender, EventArgs e)
        {
            int size = Int32.Parse(textBoxSeizeBnBTest.Text);
            int weightLow = Int32.Parse(textBoxWeightLowBnBTest.Text);
            int weightMax = Int32.Parse(textBoxWeightMaxBnBTest.Text);
            int numberOfTrials = Int32.Parse(textBoxNumberOfTrialsBnBTest.Text);
            string path = textBoxOutputPathBnBTest.Text;
            try
            {
                BnBTest.RunTest(size, weightLow, weightMax, numberOfTrials, path);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonStartTimestampTabuTest_Click(object sender, EventArgs e)
        {
            TabuTest.RunTimestampTest(cities, Int32.Parse(textBoxTimestampTabuTest.Text), cities.AdjacencyMatrix.GetLength(0), Int32.Parse(textBoxNumberOfTrialsTimestampTabuTest.Text), textBoxOutputPathTimestampTabuTest.Text);
        }

        private void buttonStartImprovementByTimeTabuTest_FileOpened()
        {
            TabuTest.RunImprovementByTimeTest(cities, textBoxOutputPathImprovementByTimeTabuTest.Text);
        }
        #endregion

        private void buttonRunGenetic_Click(object sender, EventArgs e)
        {
            textBoxGenetic.Text = cities.ShowCities();
            textBoxGenetic.Text += Environment.NewLine + Genetic.RunAlgorithm(cities, 120, 1000, 1000/2, 20, 1, 0);
        }

        private void buttonStartGeneticAnalyzeTest_Click(object sender, EventArgs e)
        {
            try
            {
                int time = Int32.Parse(textBoxTimeGeneticTest.Text);
                int populationSize = Int32.Parse(textBoxPopulationSizeGeneticTest.Text);
                int matingPoolSize = Int32.Parse(textBoxMatingPoolSizeGeneticTest.Text);
                int tournamentSize = Int32.Parse(textBoxTournamentSizeGeneticTest.Text);
                int mutationProbability = Int32.Parse(textBoxMutationProbabilityGeneticTest.Text);
                int mutationType = RadioButtonInvertGeneticTest.Checked == true ? 0 : 1;
            }
            catch
            {
                MessageBox.Show("Błędne dane!");
                return;
            }
            




        }
    }
}
