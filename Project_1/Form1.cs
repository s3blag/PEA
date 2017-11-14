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
                    cities = new Cities(fileName);
                    textBox1.Text = cities.ShowCities();
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

        private void buttonTest_Click(object sender, EventArgs e)
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

    }
}
