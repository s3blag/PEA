﻿using System;
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

        
    }
}