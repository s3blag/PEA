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
            this.tabControlTest = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelTestSize = new System.Windows.Forms.Label();
            this.labelWeightMax = new System.Windows.Forms.Label();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.textBoxTestPath = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfTrials = new System.Windows.Forms.TextBox();
            this.labelWeightLow = new System.Windows.Forms.Label();
            this.textBoxWeightLow = new System.Windows.Forms.TextBox();
            this.textBoxTestSize = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelNumberOfTrials = new System.Windows.Forms.Label();
            this.textBoxWeightMax = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxSaveImprovementByTimeTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonImprovementByTimeTest = new System.Windows.Forms.Button();
            this.textBoxTimestamp = new System.Windows.Forms.TextBox();
            this.labelTimestamp = new System.Windows.Forms.Label();
            this.buttonStartTestTabu = new System.Windows.Forms.Button();
            this.buttonSelectPathTabu = new System.Windows.Forms.Button();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.labelSelectPathTabu = new System.Windows.Forms.Label();
            this.textBoxNumberOfTrialsTabu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLoadCities = new System.Windows.Forms.Label();
            this.buttonSelectPathTabuTest = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlTest.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(6, 310);
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
            this.textBoxTabu.Location = new System.Drawing.Point(6, 6);
            this.textBoxTabu.Multiline = true;
            this.textBoxTabu.Name = "textBoxTabu";
            this.textBoxTabu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTabu.Size = new System.Drawing.Size(405, 298);
            this.textBoxTabu.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlTest
            // 
            this.tabControlTest.Controls.Add(this.tabPage5);
            this.tabControlTest.Controls.Add(this.tabPage4);
            this.tabControlTest.Location = new System.Drawing.Point(6, 6);
            this.tabControlTest.Name = "tabControlTest";
            this.tabControlTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlTest.SelectedIndex = 0;
            this.tabControlTest.Size = new System.Drawing.Size(408, 469);
            this.tabControlTest.TabIndex = 13;
            this.tabControlTest.SelectedIndexChanged += new System.EventHandler(this.tabControlTest_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelTestSize);
            this.tabPage4.Controls.Add(this.labelWeightMax);
            this.tabPage4.Controls.Add(this.buttonStartTest);
            this.tabPage4.Controls.Add(this.labelPath);
            this.tabPage4.Controls.Add(this.buttonSelectPath);
            this.tabPage4.Controls.Add(this.textBoxTestPath);
            this.tabPage4.Controls.Add(this.textBoxNumberOfTrials);
            this.tabPage4.Controls.Add(this.labelWeightLow);
            this.tabPage4.Controls.Add(this.textBoxWeightLow);
            this.tabPage4.Controls.Add(this.textBoxTestSize);
            this.tabPage4.Controls.Add(this.labelWeight);
            this.tabPage4.Controls.Add(this.labelNumberOfTrials);
            this.tabPage4.Controls.Add(this.textBoxWeightMax);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(400, 443);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Branch And Bound";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // labelTestSize
            // 
            this.labelTestSize.AutoSize = true;
            this.labelTestSize.Location = new System.Drawing.Point(21, 20);
            this.labelTestSize.Name = "labelTestSize";
            this.labelTestSize.Size = new System.Drawing.Size(86, 13);
            this.labelTestSize.TabIndex = 0;
            this.labelTestSize.Text = "Rozmiar instancji";
            // 
            // labelWeightMax
            // 
            this.labelWeightMax.AutoSize = true;
            this.labelWeightMax.Location = new System.Drawing.Point(154, 79);
            this.labelWeightMax.Name = "labelWeightMax";
            this.labelWeightMax.Size = new System.Drawing.Size(21, 13);
            this.labelWeightMax.TabIndex = 3;
            this.labelWeightMax.Text = "Do";
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(21, 177);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(100, 23);
            this.buttonStartTest.TabIndex = 9;
            this.buttonStartTest.Text = "Rozpocznij test";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(21, 135);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(161, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Podaj ścieżkę pliku wyjściowego";
            this.labelPath.Click += new System.EventHandler(this.labelPath_Click);
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(294, 151);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPath.TabIndex = 10;
            this.buttonSelectPath.Text = "Wybierz";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // textBoxTestPath
            // 
            this.textBoxTestPath.Location = new System.Drawing.Point(24, 151);
            this.textBoxTestPath.Name = "textBoxTestPath";
            this.textBoxTestPath.Size = new System.Drawing.Size(264, 20);
            this.textBoxTestPath.TabIndex = 8;
            this.textBoxTestPath.TextChanged += new System.EventHandler(this.textBoxTestPath_TextChanged);
            // 
            // textBoxNumberOfTrials
            // 
            this.textBoxNumberOfTrials.Location = new System.Drawing.Point(24, 111);
            this.textBoxNumberOfTrials.Name = "textBoxNumberOfTrials";
            this.textBoxNumberOfTrials.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfTrials.TabIndex = 12;
            this.textBoxNumberOfTrials.TextChanged += new System.EventHandler(this.textBoxNumberOfTrials_TextChanged);
            // 
            // labelWeightLow
            // 
            this.labelWeightLow.AutoSize = true;
            this.labelWeightLow.Location = new System.Drawing.Point(21, 79);
            this.labelWeightLow.Name = "labelWeightLow";
            this.labelWeightLow.Size = new System.Drawing.Size(21, 13);
            this.labelWeightLow.TabIndex = 2;
            this.labelWeightLow.Text = "Od";
            // 
            // textBoxWeightLow
            // 
            this.textBoxWeightLow.Location = new System.Drawing.Point(48, 72);
            this.textBoxWeightLow.Name = "textBoxWeightLow";
            this.textBoxWeightLow.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightLow.TabIndex = 6;
            // 
            // textBoxTestSize
            // 
            this.textBoxTestSize.Location = new System.Drawing.Point(24, 36);
            this.textBoxTestSize.Name = "textBoxTestSize";
            this.textBoxTestSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxTestSize.TabIndex = 5;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(21, 59);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Zakres wagi";
            // 
            // labelNumberOfTrials
            // 
            this.labelNumberOfTrials.AutoSize = true;
            this.labelNumberOfTrials.Location = new System.Drawing.Point(21, 95);
            this.labelNumberOfTrials.Name = "labelNumberOfTrials";
            this.labelNumberOfTrials.Size = new System.Drawing.Size(62, 13);
            this.labelNumberOfTrials.TabIndex = 11;
            this.labelNumberOfTrials.Text = "Liczba prób";
            this.labelNumberOfTrials.Click += new System.EventHandler(this.labelNumberOfTrials_Click);
            // 
            // textBoxWeightMax
            // 
            this.textBoxWeightMax.Location = new System.Drawing.Point(181, 72);
            this.textBoxWeightMax.Name = "textBoxWeightMax";
            this.textBoxWeightMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightMax.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.textBoxTimestamp);
            this.tabPage5.Controls.Add(this.labelTimestamp);
            this.tabPage5.Controls.Add(this.buttonStartTestTabu);
            this.tabPage5.Controls.Add(this.buttonSelectPathTabu);
            this.tabPage5.Controls.Add(this.textBoxOutputPath);
            this.tabPage5.Controls.Add(this.labelSelectPathTabu);
            this.tabPage5.Controls.Add(this.textBoxNumberOfTrialsTabu);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.labelLoadCities);
            this.tabPage5.Controls.Add(this.buttonSelectPathTabuTest);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(400, 443);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Tabu Search";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxSaveImprovementByTimeTest);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.buttonImprovementByTimeTest);
            this.groupBox5.Location = new System.Drawing.Point(6, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(388, 77);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Przebieg algorytmu od czasu";
            // 
            // textBoxSaveImprovementByTimeTest
            // 
            this.textBoxSaveImprovementByTimeTest.Location = new System.Drawing.Point(6, 44);
            this.textBoxSaveImprovementByTimeTest.Name = "textBoxSaveImprovementByTimeTest";
            this.textBoxSaveImprovementByTimeTest.Size = new System.Drawing.Size(244, 20);
            this.textBoxSaveImprovementByTimeTest.TabIndex = 16;
            this.textBoxSaveImprovementByTimeTest.Text = "C:\\Users\\seblag-stacjonarny\\Desktop\\te.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Podaj ścieżkę pliku wyjściowego";
            // 
            // buttonImprovementByTimeTest
            // 
            this.buttonImprovementByTimeTest.Location = new System.Drawing.Point(256, 42);
            this.buttonImprovementByTimeTest.Name = "buttonImprovementByTimeTest";
            this.buttonImprovementByTimeTest.Size = new System.Drawing.Size(75, 23);
            this.buttonImprovementByTimeTest.TabIndex = 12;
            this.buttonImprovementByTimeTest.Text = "Uruchom";
            this.buttonImprovementByTimeTest.UseVisualStyleBackColor = true;
            this.buttonImprovementByTimeTest.Click += new System.EventHandler(this.buttonImprovementByTimeTest_Click);
            // 
            // textBoxTimestamp
            // 
            this.textBoxTimestamp.Location = new System.Drawing.Point(155, 65);
            this.textBoxTimestamp.Name = "textBoxTimestamp";
            this.textBoxTimestamp.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimestamp.TabIndex = 9;
            // 
            // labelTimestamp
            // 
            this.labelTimestamp.AutoSize = true;
            this.labelTimestamp.Location = new System.Drawing.Point(155, 49);
            this.labelTimestamp.Name = "labelTimestamp";
            this.labelTimestamp.Size = new System.Drawing.Size(58, 13);
            this.labelTimestamp.TabIndex = 8;
            this.labelTimestamp.Text = "Timestamp";
            // 
            // buttonStartTestTabu
            // 
            this.buttonStartTestTabu.Location = new System.Drawing.Point(7, 135);
            this.buttonStartTestTabu.Name = "buttonStartTestTabu";
            this.buttonStartTestTabu.Size = new System.Drawing.Size(158, 23);
            this.buttonStartTestTabu.TabIndex = 7;
            this.buttonStartTestTabu.Text = "Rozpocznij timestamp test";
            this.buttonStartTestTabu.UseVisualStyleBackColor = true;
            this.buttonStartTestTabu.Click += new System.EventHandler(this.buttonStartTestTabu_Click);
            // 
            // buttonSelectPathTabu
            // 
            this.buttonSelectPathTabu.Location = new System.Drawing.Point(257, 105);
            this.buttonSelectPathTabu.Name = "buttonSelectPathTabu";
            this.buttonSelectPathTabu.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPathTabu.TabIndex = 6;
            this.buttonSelectPathTabu.Text = "Wybierz";
            this.buttonSelectPathTabu.UseVisualStyleBackColor = true;
            this.buttonSelectPathTabu.Click += new System.EventHandler(this.buttonSelectPathTabu_Click);
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Location = new System.Drawing.Point(7, 108);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.Size = new System.Drawing.Size(244, 20);
            this.textBoxOutputPath.TabIndex = 5;
            // 
            // labelSelectPathTabu
            // 
            this.labelSelectPathTabu.AutoSize = true;
            this.labelSelectPathTabu.Location = new System.Drawing.Point(7, 92);
            this.labelSelectPathTabu.Name = "labelSelectPathTabu";
            this.labelSelectPathTabu.Size = new System.Drawing.Size(161, 13);
            this.labelSelectPathTabu.TabIndex = 4;
            this.labelSelectPathTabu.Text = "Podaj ścieżkę pliku wyjściowego";
            // 
            // textBoxNumberOfTrialsTabu
            // 
            this.textBoxNumberOfTrialsTabu.Location = new System.Drawing.Point(7, 65);
            this.textBoxNumberOfTrialsTabu.Name = "textBoxNumberOfTrialsTabu";
            this.textBoxNumberOfTrialsTabu.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfTrialsTabu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Liczba prób";
            // 
            // labelLoadCities
            // 
            this.labelLoadCities.AutoSize = true;
            this.labelLoadCities.Location = new System.Drawing.Point(7, 7);
            this.labelLoadCities.Name = "labelLoadCities";
            this.labelLoadCities.Size = new System.Drawing.Size(90, 13);
            this.labelLoadCities.TabIndex = 1;
            this.labelLoadCities.Text = "Wczytaj instancję";
            // 
            // buttonSelectPathTabuTest
            // 
            this.buttonSelectPathTabuTest.Location = new System.Drawing.Point(7, 23);
            this.buttonSelectPathTabuTest.Name = "buttonSelectPathTabuTest";
            this.buttonSelectPathTabuTest.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPathTabuTest.TabIndex = 0;
            this.buttonSelectPathTabuTest.Text = "Wybierz";
            this.buttonSelectPathTabuTest.UseVisualStyleBackColor = true;
            this.buttonSelectPathTabuTest.Click += new System.EventHandler(this.buttonSelectPathTabuTest_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
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
            this.tabControlTest.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControlTest;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label labelLoadCities;
        private System.Windows.Forms.Button buttonSelectPathTabuTest;
        private System.Windows.Forms.Button buttonStartTestTabu;
        private System.Windows.Forms.Button buttonSelectPathTabu;
        private System.Windows.Forms.TextBox textBoxOutputPath;
        private System.Windows.Forms.Label labelSelectPathTabu;
        private System.Windows.Forms.TextBox textBoxNumberOfTrialsTabu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTimestamp;
        private System.Windows.Forms.Label labelTimestamp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxSaveImprovementByTimeTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonImprovementByTimeTest;
    }
}

