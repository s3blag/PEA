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
        Cities cities;
        string fileName;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTestPath.Text = Directory.GetCurrentDirectory() + "\\test.txt";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                if (openFileDialog1.OpenFile() != null)
                {
                    fileName = openFileDialog1.FileName;
                    cities = new Cities(fileName, true);
                    //textBox1.Text = cities.ShowCities();
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
                cities = new Cities(Int32.Parse(textBoxNumberOfCities.Text),1,100, radioAsync.Checked);
                textBox1.Text = cities.ShowCities();
                textBox1.Text += BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nie można wygenerować miast! Błąd: " + exception.Message);
            }      
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            int size = Int32.Parse(textBoxTestSize.Text);
            int weightLow = Int32.Parse(textBoxWeightLow.Text);
            int weightMax = Int32.Parse(textBoxWeightMax.Text);
            int numberOfTrials = Int32.Parse(textBoxNumberOfTrials.Text);
            string path = textBoxTestPath.Text;
            try
            {
                BnBTest.RunTest(size, weightLow, weightMax, numberOfTrials, path);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            try
            {
                textBoxTestPath.Text = saveFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRunAlgorithm_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd: Źle podane wartości! ");
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

            try
            {
                cities = new Cities(Int32.Parse(textBoxNumberOfCities.Text), 1, 100, radioAsync.Checked);
                textBox1.Text = cities.ShowCities();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nie można wygenerować miast! Błąd: " + exception.Message);
            }


            textBox1.Text += Environment.NewLine +  "-------------------   TABU   ---------------------" + Environment.NewLine;
            textBox1.Text += TabuSearch.RunAlgorithm(cities.AdjacencyMatrix, 10*(cities.AdjacencyMatrix.GetLength(0)/10), 100);
            //textBox1.Text += Environment.NewLine + "-------------------   Branch and Bound   ---------------------" + Environment.NewLine;
            // textBox1.Text += BranchAndBound.RunAlgorithm(cities.AdjacencyMatrix);*/
            textBox1.Text += Environment.NewLine + "-------------------   Brute Force   ---------------------" + Environment.NewLine;
            textBox1.Text += Environment.NewLine;
        //  textBox1.Text += BruteForce.RunAlgorithm(cities);

            
        }

        private void buttonTestTabu_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine + "-------------------   TABU   ---------------------" + Environment.NewLine;
            textBox1.Text += TabuSearch.RunAlgorithm(cities.AdjacencyMatrix, cities.AdjacencyMatrix.GetLength(0), 100);
        }
    }
}
