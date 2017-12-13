namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonGenShow = new System.Windows.Forms.Button();
            this.textBoxNumberOfCities = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioSync = new System.Windows.Forms.RadioButton();
            this.radioAsync = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRunAlgorithm = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRunTabu = new System.Windows.Forms.Button();
            this.buttonLoadFileTabu = new System.Windows.Forms.Button();
            this.textBoxTabu = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxNumberOfTrials = new System.Windows.Forms.TextBox();
            this.labelNumberOfTrials = new System.Windows.Forms.Label();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.textBoxTestPath = new System.Windows.Forms.TextBox();
            this.textBoxWeightMax = new System.Windows.Forms.TextBox();
            this.textBoxWeightLow = new System.Windows.Forms.TextBox();
            this.textBoxTestSize = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelWeightMax = new System.Windows.Forms.Label();
            this.labelWeightLow = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelTestSize = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBoxBnBTest = new System.Windows.Forms.GroupBox();
            this.groupBoxTabuTest = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxBnBTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(405, 298);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(6, 39);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(82, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Wybierz Plik";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonGenShow
            // 
            this.buttonGenShow.Location = new System.Drawing.Point(202, 35);
            this.buttonGenShow.Name = "buttonGenShow";
            this.buttonGenShow.Size = new System.Drawing.Size(156, 25);
            this.buttonGenShow.TabIndex = 3;
            this.buttonGenShow.Text = "Generuj oraz wyświetl";
            this.buttonGenShow.UseVisualStyleBackColor = true;
            this.buttonGenShow.Click += new System.EventHandler(this.buttonGenShow_Click);
            // 
            // textBoxNumberOfCities
            // 
            this.textBoxNumberOfCities.Location = new System.Drawing.Point(7, 40);
            this.textBoxNumberOfCities.Name = "textBoxNumberOfCities";
            this.textBoxNumberOfCities.Size = new System.Drawing.Size(82, 20);
            this.textBoxNumberOfCities.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ilość miast:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Otwórz plik:";
            // 
            // radioSync
            // 
            this.radioSync.AutoSize = true;
            this.radioSync.Checked = true;
            this.radioSync.Location = new System.Drawing.Point(123, 28);
            this.radioSync.Name = "radioSync";
            this.radioSync.Size = new System.Drawing.Size(49, 17);
            this.radioSync.TabIndex = 8;
            this.radioSync.TabStop = true;
            this.radioSync.Text = "Sync";
            this.radioSync.UseVisualStyleBackColor = true;
            // 
            // radioAsync
            // 
            this.radioAsync.AutoSize = true;
            this.radioAsync.Location = new System.Drawing.Point(123, 45);
            this.radioAsync.Name = "radioAsync";
            this.radioAsync.Size = new System.Drawing.Size(54, 17);
            this.radioAsync.TabIndex = 9;
            this.radioAsync.Text = "Async";
            this.radioAsync.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 507);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Branch And Bound";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGenShow);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNumberOfCities);
            this.groupBox2.Controls.Add(this.radioAsync);
            this.groupBox2.Controls.Add(this.radioSync);
            this.groupBox2.Location = new System.Drawing.Point(6, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 77);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generacja:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonRunAlgorithm);
            this.groupBox1.Controls.Add(this.buttonOpenFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytanie z pliku:";
            // 
            // buttonRunAlgorithm
            // 
            this.buttonRunAlgorithm.Location = new System.Drawing.Point(119, 39);
            this.buttonRunAlgorithm.Name = "buttonRunAlgorithm";
            this.buttonRunAlgorithm.Size = new System.Drawing.Size(115, 23);
            this.buttonRunAlgorithm.TabIndex = 10;
            this.buttonRunAlgorithm.Text = "Uruchom algorytm";
            this.buttonRunAlgorithm.UseVisualStyleBackColor = true;
            this.buttonRunAlgorithm.Click += new System.EventHandler(this.buttonRunAlgorithm_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.textBoxTabu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(421, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tabu Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonRunTabu);
            this.groupBox3.Controls.Add(this.buttonLoadFileTabu);
            this.groupBox3.Location = new System.Drawing.Point(10, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 77);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wczytanie z pliku:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Otwórz plik:";
            // 
            // buttonRunTabu
            // 
            this.buttonRunTabu.Location = new System.Drawing.Point(119, 39);
            this.buttonRunTabu.Name = "buttonRunTabu";
            this.buttonRunTabu.Size = new System.Drawing.Size(115, 23);
            this.buttonRunTabu.TabIndex = 10;
            this.buttonRunTabu.Text = "Uruchom algorytm";
            this.buttonRunTabu.UseVisualStyleBackColor = true;
            this.buttonRunTabu.Click += new System.EventHandler(this.buttonRunTabu_Click);
            // 
            // buttonLoadFileTabu
            // 
            this.buttonLoadFileTabu.Location = new System.Drawing.Point(6, 39);
            this.buttonLoadFileTabu.Name = "buttonLoadFileTabu";
            this.buttonLoadFileTabu.Size = new System.Drawing.Size(82, 23);
            this.buttonLoadFileTabu.TabIndex = 2;
            this.buttonLoadFileTabu.Text = "Wybierz Plik";
            this.buttonLoadFileTabu.UseVisualStyleBackColor = true;
            this.buttonLoadFileTabu.Click += new System.EventHandler(this.buttonLoadFileTabu_Click);
            // 
            // textBoxTabu
            // 
            this.textBoxTabu.Location = new System.Drawing.Point(8, 8);
            this.textBoxTabu.Multiline = true;
            this.textBoxTabu.Name = "textBoxTabu";
            this.textBoxTabu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTabu.Size = new System.Drawing.Size(405, 298);
            this.textBoxTabu.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxTabuTest);
            this.tabPage2.Controls.Add(this.groupBoxBnBTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxNumberOfTrials
            // 
            this.textBoxNumberOfTrials.Location = new System.Drawing.Point(17, 107);
            this.textBoxNumberOfTrials.Name = "textBoxNumberOfTrials";
            this.textBoxNumberOfTrials.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfTrials.TabIndex = 12;
            // 
            // labelNumberOfTrials
            // 
            this.labelNumberOfTrials.AutoSize = true;
            this.labelNumberOfTrials.Location = new System.Drawing.Point(14, 91);
            this.labelNumberOfTrials.Name = "labelNumberOfTrials";
            this.labelNumberOfTrials.Size = new System.Drawing.Size(62, 13);
            this.labelNumberOfTrials.TabIndex = 11;
            this.labelNumberOfTrials.Text = "Liczba prób";
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(287, 147);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPath.TabIndex = 10;
            this.buttonSelectPath.Text = "Wybierz";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(123, 105);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(100, 23);
            this.buttonStartTest.TabIndex = 9;
            this.buttonStartTest.Text = "Rozpocznij test";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // textBoxTestPath
            // 
            this.textBoxTestPath.Location = new System.Drawing.Point(17, 147);
            this.textBoxTestPath.Name = "textBoxTestPath";
            this.textBoxTestPath.Size = new System.Drawing.Size(264, 20);
            this.textBoxTestPath.TabIndex = 8;
            // 
            // textBoxWeightMax
            // 
            this.textBoxWeightMax.Location = new System.Drawing.Point(174, 68);
            this.textBoxWeightMax.Name = "textBoxWeightMax";
            this.textBoxWeightMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightMax.TabIndex = 7;
            // 
            // textBoxWeightLow
            // 
            this.textBoxWeightLow.Location = new System.Drawing.Point(41, 68);
            this.textBoxWeightLow.Name = "textBoxWeightLow";
            this.textBoxWeightLow.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightLow.TabIndex = 6;
            // 
            // textBoxTestSize
            // 
            this.textBoxTestSize.Location = new System.Drawing.Point(17, 32);
            this.textBoxTestSize.Name = "textBoxTestSize";
            this.textBoxTestSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxTestSize.TabIndex = 5;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(14, 131);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(161, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Podaj ścieżkę pliku wyjściowego";
            // 
            // labelWeightMax
            // 
            this.labelWeightMax.AutoSize = true;
            this.labelWeightMax.Location = new System.Drawing.Point(147, 75);
            this.labelWeightMax.Name = "labelWeightMax";
            this.labelWeightMax.Size = new System.Drawing.Size(21, 13);
            this.labelWeightMax.TabIndex = 3;
            this.labelWeightMax.Text = "Do";
            // 
            // labelWeightLow
            // 
            this.labelWeightLow.AutoSize = true;
            this.labelWeightLow.Location = new System.Drawing.Point(14, 75);
            this.labelWeightLow.Name = "labelWeightLow";
            this.labelWeightLow.Size = new System.Drawing.Size(21, 13);
            this.labelWeightLow.TabIndex = 2;
            this.labelWeightLow.Text = "Od";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(14, 55);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Zakres wagi";
            // 
            // labelTestSize
            // 
            this.labelTestSize.AutoSize = true;
            this.labelTestSize.Location = new System.Drawing.Point(14, 16);
            this.labelTestSize.Name = "labelTestSize";
            this.labelTestSize.Size = new System.Drawing.Size(86, 13);
            this.labelTestSize.TabIndex = 0;
            this.labelTestSize.Text = "Rozmiar instancji";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // groupBoxBnBTest
            // 
            this.groupBoxBnBTest.Controls.Add(this.labelTestSize);
            this.groupBoxBnBTest.Controls.Add(this.buttonStartTest);
            this.groupBoxBnBTest.Controls.Add(this.textBoxNumberOfTrials);
            this.groupBoxBnBTest.Controls.Add(this.labelWeight);
            this.groupBoxBnBTest.Controls.Add(this.labelNumberOfTrials);
            this.groupBoxBnBTest.Controls.Add(this.labelWeightLow);
            this.groupBoxBnBTest.Controls.Add(this.buttonSelectPath);
            this.groupBoxBnBTest.Controls.Add(this.labelWeightMax);
            this.groupBoxBnBTest.Controls.Add(this.labelPath);
            this.groupBoxBnBTest.Controls.Add(this.textBoxTestPath);
            this.groupBoxBnBTest.Controls.Add(this.textBoxTestSize);
            this.groupBoxBnBTest.Controls.Add(this.textBoxWeightMax);
            this.groupBoxBnBTest.Controls.Add(this.textBoxWeightLow);
            this.groupBoxBnBTest.Location = new System.Drawing.Point(15, 6);
            this.groupBoxBnBTest.Name = "groupBoxBnBTest";
            this.groupBoxBnBTest.Size = new System.Drawing.Size(388, 191);
            this.groupBoxBnBTest.TabIndex = 13;
            this.groupBoxBnBTest.TabStop = false;
            this.groupBoxBnBTest.Text = "BranchAndBound";
            // 
            // groupBoxTabuTest
            // 
            this.groupBoxTabuTest.Location = new System.Drawing.Point(15, 204);
            this.groupBoxTabuTest.Name = "groupBoxTabuTest";
            this.groupBoxTabuTest.Size = new System.Drawing.Size(388, 172);
            this.groupBoxTabuTest.TabIndex = 14;
            this.groupBoxTabuTest.TabStop = false;
            this.groupBoxTabuTest.Text = "Tabu Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxBnBTest.ResumeLayout(false);
            this.groupBoxBnBTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonGenShow;
        private System.Windows.Forms.TextBox textBoxNumberOfCities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioSync;
        private System.Windows.Forms.RadioButton radioAsync;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelTestSize;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelWeightMax;
        private System.Windows.Forms.Label labelWeightLow;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.TextBox textBoxTestPath;
        private System.Windows.Forms.TextBox textBoxWeightMax;
        private System.Windows.Forms.TextBox textBoxWeightLow;
        private System.Windows.Forms.TextBox textBoxTestSize;
        private System.Windows.Forms.TextBox textBoxNumberOfTrials;
        private System.Windows.Forms.Label labelNumberOfTrials;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonRunAlgorithm;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxTabu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRunTabu;
        private System.Windows.Forms.Button buttonLoadFileTabu;
        private System.Windows.Forms.GroupBox groupBoxTabuTest;
        private System.Windows.Forms.GroupBox groupBoxBnBTest;
    }
}

