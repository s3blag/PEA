namespace TSP
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
            this.textBoxBnB = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadFileBnB = new System.Windows.Forms.Button();
            this.buttonRunRandomCitiesBnB = new System.Windows.Forms.Button();
            this.textBoxNumberOfCitiesBnB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBnBSync = new System.Windows.Forms.RadioButton();
            this.radioBnBAsync = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBranchAndBound = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRunBnB = new System.Windows.Forms.Button();
            this.tabTabuSearch = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRunTabu = new System.Windows.Forms.Button();
            this.buttonLoadFileTabu = new System.Windows.Forms.Button();
            this.textBoxTabu = new System.Windows.Forms.TextBox();
            this.tabGenetic = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRunGenetic = new System.Windows.Forms.Button();
            this.buttonLoadFileGenetic = new System.Windows.Forms.Button();
            this.textBoxGenetic = new System.Windows.Forms.TextBox();
            this.tabTests = new System.Windows.Forms.TabPage();
            this.tabControlTest = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxOutputPathImprovementByTimeTabuTest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStartImprovementByTimeTabuTest = new System.Windows.Forms.Button();
            this.textBoxTimestampTabuTest = new System.Windows.Forms.TextBox();
            this.labelTimestamp = new System.Windows.Forms.Label();
            this.buttonStartTimestampTabuTest = new System.Windows.Forms.Button();
            this.buttonSelectOutputPathTimeStampTabuTest = new System.Windows.Forms.Button();
            this.textBoxOutputPathTimestampTabuTest = new System.Windows.Forms.TextBox();
            this.labelSelectPathTabu = new System.Windows.Forms.Label();
            this.textBoxNumberOfTrialsTimestampTabuTest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLoadCities = new System.Windows.Forms.Label();
            this.buttonLoadFileTimestampTabuTest = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelTestSize = new System.Windows.Forms.Label();
            this.labelWeightMax = new System.Windows.Forms.Label();
            this.buttonStartBnBTest = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonSelectOutputPathBnBTest = new System.Windows.Forms.Button();
            this.textBoxOutputPathBnBTest = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfTrialsBnBTest = new System.Windows.Forms.TextBox();
            this.labelWeightLow = new System.Windows.Forms.Label();
            this.textBoxWeightLowBnBTest = new System.Windows.Forms.TextBox();
            this.textBoxSeizeBnBTest = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelNumberOfTrials = new System.Windows.Forms.Label();
            this.textBoxWeightMaxBnBTest = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl.SuspendLayout();
            this.tabBranchAndBound.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTabuSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabGenetic.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabTests.SuspendLayout();
            this.tabControlTest.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBnB
            // 
            this.textBoxBnB.Location = new System.Drawing.Point(6, 6);
            this.textBoxBnB.Multiline = true;
            this.textBoxBnB.Name = "textBoxBnB";
            this.textBoxBnB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBnB.Size = new System.Drawing.Size(405, 298);
            this.textBoxBnB.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonLoadFileBnB
            // 
            this.buttonLoadFileBnB.Location = new System.Drawing.Point(6, 39);
            this.buttonLoadFileBnB.Name = "buttonLoadFileBnB";
            this.buttonLoadFileBnB.Size = new System.Drawing.Size(82, 23);
            this.buttonLoadFileBnB.TabIndex = 2;
            this.buttonLoadFileBnB.Text = "Wybierz Plik";
            this.buttonLoadFileBnB.UseVisualStyleBackColor = true;
            this.buttonLoadFileBnB.Click += new System.EventHandler(this.OpenFile);
            // 
            // buttonRunRandomCitiesBnB
            // 
            this.buttonRunRandomCitiesBnB.Location = new System.Drawing.Point(202, 35);
            this.buttonRunRandomCitiesBnB.Name = "buttonRunRandomCitiesBnB";
            this.buttonRunRandomCitiesBnB.Size = new System.Drawing.Size(156, 25);
            this.buttonRunRandomCitiesBnB.TabIndex = 3;
            this.buttonRunRandomCitiesBnB.Text = "Generuj oraz wyświetl";
            this.buttonRunRandomCitiesBnB.UseVisualStyleBackColor = true;
            this.buttonRunRandomCitiesBnB.Click += new System.EventHandler(this.buttonRunRandomCitiesBnB_Click);
            // 
            // textBoxNumberOfCitiesBnB
            // 
            this.textBoxNumberOfCitiesBnB.Location = new System.Drawing.Point(7, 40);
            this.textBoxNumberOfCitiesBnB.Name = "textBoxNumberOfCitiesBnB";
            this.textBoxNumberOfCitiesBnB.Size = new System.Drawing.Size(82, 20);
            this.textBoxNumberOfCitiesBnB.TabIndex = 5;
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
            // radioBnBSync
            // 
            this.radioBnBSync.AutoSize = true;
            this.radioBnBSync.Checked = true;
            this.radioBnBSync.Location = new System.Drawing.Point(123, 28);
            this.radioBnBSync.Name = "radioBnBSync";
            this.radioBnBSync.Size = new System.Drawing.Size(49, 17);
            this.radioBnBSync.TabIndex = 8;
            this.radioBnBSync.TabStop = true;
            this.radioBnBSync.Text = "Sync";
            this.radioBnBSync.UseVisualStyleBackColor = true;
            // 
            // radioBnBAsync
            // 
            this.radioBnBAsync.AutoSize = true;
            this.radioBnBAsync.Location = new System.Drawing.Point(123, 45);
            this.radioBnBAsync.Name = "radioBnBAsync";
            this.radioBnBAsync.Size = new System.Drawing.Size(54, 17);
            this.radioBnBAsync.TabIndex = 9;
            this.radioBnBAsync.Text = "Async";
            this.radioBnBAsync.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.AccessibleDescription = "";
            this.tabControl.Controls.Add(this.tabBranchAndBound);
            this.tabControl.Controls.Add(this.tabTabuSearch);
            this.tabControl.Controls.Add(this.tabGenetic);
            this.tabControl.Controls.Add(this.tabTests);
            this.tabControl.Location = new System.Drawing.Point(12, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(429, 507);
            this.tabControl.TabIndex = 10;
            // 
            // tabBranchAndBound
            // 
            this.tabBranchAndBound.Controls.Add(this.groupBox2);
            this.tabBranchAndBound.Controls.Add(this.groupBox1);
            this.tabBranchAndBound.Controls.Add(this.textBoxBnB);
            this.tabBranchAndBound.Location = new System.Drawing.Point(4, 22);
            this.tabBranchAndBound.Name = "tabBranchAndBound";
            this.tabBranchAndBound.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranchAndBound.Size = new System.Drawing.Size(421, 481);
            this.tabBranchAndBound.TabIndex = 0;
            this.tabBranchAndBound.Text = "Branch And Bound";
            this.tabBranchAndBound.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRunRandomCitiesBnB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNumberOfCitiesBnB);
            this.groupBox2.Controls.Add(this.radioBnBAsync);
            this.groupBox2.Controls.Add(this.radioBnBSync);
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
            this.groupBox1.Controls.Add(this.buttonRunBnB);
            this.groupBox1.Controls.Add(this.buttonLoadFileBnB);
            this.groupBox1.Location = new System.Drawing.Point(6, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytanie z pliku:";
            // 
            // buttonRunBnB
            // 
            this.buttonRunBnB.Location = new System.Drawing.Point(119, 39);
            this.buttonRunBnB.Name = "buttonRunBnB";
            this.buttonRunBnB.Size = new System.Drawing.Size(115, 23);
            this.buttonRunBnB.TabIndex = 10;
            this.buttonRunBnB.Text = "Uruchom algorytm";
            this.buttonRunBnB.UseVisualStyleBackColor = true;
            this.buttonRunBnB.Click += new System.EventHandler(this.buttonRunBnB_Click);
            // 
            // tabTabuSearch
            // 
            this.tabTabuSearch.Controls.Add(this.groupBox3);
            this.tabTabuSearch.Controls.Add(this.textBoxTabu);
            this.tabTabuSearch.Location = new System.Drawing.Point(4, 22);
            this.tabTabuSearch.Name = "tabTabuSearch";
            this.tabTabuSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabTabuSearch.Size = new System.Drawing.Size(421, 481);
            this.tabTabuSearch.TabIndex = 2;
            this.tabTabuSearch.Text = "Tabu Search";
            this.tabTabuSearch.UseVisualStyleBackColor = true;
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
            this.buttonLoadFileTabu.Click += new System.EventHandler(this.OpenTSPFile);
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
            // tabGenetic
            // 
            this.tabGenetic.Controls.Add(this.groupBox4);
            this.tabGenetic.Controls.Add(this.textBoxGenetic);
            this.tabGenetic.Location = new System.Drawing.Point(4, 22);
            this.tabGenetic.Name = "tabGenetic";
            this.tabGenetic.Size = new System.Drawing.Size(421, 481);
            this.tabGenetic.TabIndex = 3;
            this.tabGenetic.Text = "Genetic";
            this.tabGenetic.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.buttonRunGenetic);
            this.groupBox4.Controls.Add(this.buttonLoadFileGenetic);
            this.groupBox4.Location = new System.Drawing.Point(6, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 77);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wczytanie z pliku:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Otwórz plik:";
            // 
            // buttonRunGenetic
            // 
            this.buttonRunGenetic.Location = new System.Drawing.Point(119, 39);
            this.buttonRunGenetic.Name = "buttonRunGenetic";
            this.buttonRunGenetic.Size = new System.Drawing.Size(115, 23);
            this.buttonRunGenetic.TabIndex = 10;
            this.buttonRunGenetic.Text = "Uruchom algorytm";
            this.buttonRunGenetic.UseVisualStyleBackColor = true;
            this.buttonRunGenetic.Click += new System.EventHandler(this.buttonRunGenetic_Click);
            // 
            // buttonLoadFileGenetic
            // 
            this.buttonLoadFileGenetic.Location = new System.Drawing.Point(6, 39);
            this.buttonLoadFileGenetic.Name = "buttonLoadFileGenetic";
            this.buttonLoadFileGenetic.Size = new System.Drawing.Size(82, 23);
            this.buttonLoadFileGenetic.TabIndex = 2;
            this.buttonLoadFileGenetic.Text = "Wybierz Plik";
            this.buttonLoadFileGenetic.UseVisualStyleBackColor = true;
            // 
            // textBoxGenetic
            // 
            this.textBoxGenetic.Location = new System.Drawing.Point(6, 6);
            this.textBoxGenetic.Multiline = true;
            this.textBoxGenetic.Name = "textBoxGenetic";
            this.textBoxGenetic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGenetic.Size = new System.Drawing.Size(405, 298);
            this.textBoxGenetic.TabIndex = 13;
            // 
            // tabTests
            // 
            this.tabTests.Controls.Add(this.tabControlTest);
            this.tabTests.Location = new System.Drawing.Point(4, 22);
            this.tabTests.Name = "tabTests";
            this.tabTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabTests.Size = new System.Drawing.Size(421, 481);
            this.tabTests.TabIndex = 1;
            this.tabTests.Text = "Test";
            this.tabTests.UseVisualStyleBackColor = true;
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
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.textBoxTimestampTabuTest);
            this.tabPage5.Controls.Add(this.labelTimestamp);
            this.tabPage5.Controls.Add(this.buttonStartTimestampTabuTest);
            this.tabPage5.Controls.Add(this.buttonSelectOutputPathTimeStampTabuTest);
            this.tabPage5.Controls.Add(this.textBoxOutputPathTimestampTabuTest);
            this.tabPage5.Controls.Add(this.labelSelectPathTabu);
            this.tabPage5.Controls.Add(this.textBoxNumberOfTrialsTimestampTabuTest);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.labelLoadCities);
            this.tabPage5.Controls.Add(this.buttonLoadFileTimestampTabuTest);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(400, 443);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Tabu Search";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxOutputPathImprovementByTimeTabuTest);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.buttonStartImprovementByTimeTabuTest);
            this.groupBox5.Location = new System.Drawing.Point(6, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(388, 77);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Przebieg algorytmu od czasu";
            // 
            // textBoxOutputPathImprovementByTimeTabuTest
            // 
            this.textBoxOutputPathImprovementByTimeTabuTest.Location = new System.Drawing.Point(6, 44);
            this.textBoxOutputPathImprovementByTimeTabuTest.Name = "textBoxOutputPathImprovementByTimeTabuTest";
            this.textBoxOutputPathImprovementByTimeTabuTest.Size = new System.Drawing.Size(244, 20);
            this.textBoxOutputPathImprovementByTimeTabuTest.TabIndex = 16;
            this.textBoxOutputPathImprovementByTimeTabuTest.Text = "C:\\Users\\seblag-stacjonarny\\Desktop\\te.txt";
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
            // buttonStartImprovementByTimeTabuTest
            // 
            this.buttonStartImprovementByTimeTabuTest.Location = new System.Drawing.Point(256, 42);
            this.buttonStartImprovementByTimeTabuTest.Name = "buttonStartImprovementByTimeTabuTest";
            this.buttonStartImprovementByTimeTabuTest.Size = new System.Drawing.Size(75, 23);
            this.buttonStartImprovementByTimeTabuTest.TabIndex = 12;
            this.buttonStartImprovementByTimeTabuTest.Text = "Uruchom";
            this.buttonStartImprovementByTimeTabuTest.UseVisualStyleBackColor = true;
            // 
            // textBoxTimestampTabuTest
            // 
            this.textBoxTimestampTabuTest.Location = new System.Drawing.Point(155, 65);
            this.textBoxTimestampTabuTest.Name = "textBoxTimestampTabuTest";
            this.textBoxTimestampTabuTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimestampTabuTest.TabIndex = 9;
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
            // buttonStartTimestampTabuTest
            // 
            this.buttonStartTimestampTabuTest.Location = new System.Drawing.Point(7, 135);
            this.buttonStartTimestampTabuTest.Name = "buttonStartTimestampTabuTest";
            this.buttonStartTimestampTabuTest.Size = new System.Drawing.Size(158, 23);
            this.buttonStartTimestampTabuTest.TabIndex = 7;
            this.buttonStartTimestampTabuTest.Text = "Rozpocznij timestamp test";
            this.buttonStartTimestampTabuTest.UseVisualStyleBackColor = true;
            this.buttonStartTimestampTabuTest.Click += new System.EventHandler(this.buttonStartTimestampTabuTest_Click);
            // 
            // buttonSelectOutputPathTimeStampTabuTest
            // 
            this.buttonSelectOutputPathTimeStampTabuTest.Location = new System.Drawing.Point(257, 105);
            this.buttonSelectOutputPathTimeStampTabuTest.Name = "buttonSelectOutputPathTimeStampTabuTest";
            this.buttonSelectOutputPathTimeStampTabuTest.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputPathTimeStampTabuTest.TabIndex = 6;
            this.buttonSelectOutputPathTimeStampTabuTest.Text = "Wybierz";
            this.buttonSelectOutputPathTimeStampTabuTest.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputPathTimestampTabuTest
            // 
            this.textBoxOutputPathTimestampTabuTest.Location = new System.Drawing.Point(7, 108);
            this.textBoxOutputPathTimestampTabuTest.Name = "textBoxOutputPathTimestampTabuTest";
            this.textBoxOutputPathTimestampTabuTest.Size = new System.Drawing.Size(244, 20);
            this.textBoxOutputPathTimestampTabuTest.TabIndex = 5;
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
            // textBoxNumberOfTrialsTimestampTabuTest
            // 
            this.textBoxNumberOfTrialsTimestampTabuTest.Location = new System.Drawing.Point(7, 65);
            this.textBoxNumberOfTrialsTimestampTabuTest.Name = "textBoxNumberOfTrialsTimestampTabuTest";
            this.textBoxNumberOfTrialsTimestampTabuTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfTrialsTimestampTabuTest.TabIndex = 3;
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
            // buttonLoadFileTimestampTabuTest
            // 
            this.buttonLoadFileTimestampTabuTest.Location = new System.Drawing.Point(7, 23);
            this.buttonLoadFileTimestampTabuTest.Name = "buttonLoadFileTimestampTabuTest";
            this.buttonLoadFileTimestampTabuTest.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFileTimestampTabuTest.TabIndex = 0;
            this.buttonLoadFileTimestampTabuTest.Text = "Wybierz";
            this.buttonLoadFileTimestampTabuTest.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelTestSize);
            this.tabPage4.Controls.Add(this.labelWeightMax);
            this.tabPage4.Controls.Add(this.buttonStartBnBTest);
            this.tabPage4.Controls.Add(this.labelPath);
            this.tabPage4.Controls.Add(this.buttonSelectOutputPathBnBTest);
            this.tabPage4.Controls.Add(this.textBoxOutputPathBnBTest);
            this.tabPage4.Controls.Add(this.textBoxNumberOfTrialsBnBTest);
            this.tabPage4.Controls.Add(this.labelWeightLow);
            this.tabPage4.Controls.Add(this.textBoxWeightLowBnBTest);
            this.tabPage4.Controls.Add(this.textBoxSeizeBnBTest);
            this.tabPage4.Controls.Add(this.labelWeight);
            this.tabPage4.Controls.Add(this.labelNumberOfTrials);
            this.tabPage4.Controls.Add(this.textBoxWeightMaxBnBTest);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(400, 443);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Branch And Bound";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // buttonStartBnBTest
            // 
            this.buttonStartBnBTest.Location = new System.Drawing.Point(21, 177);
            this.buttonStartBnBTest.Name = "buttonStartBnBTest";
            this.buttonStartBnBTest.Size = new System.Drawing.Size(100, 23);
            this.buttonStartBnBTest.TabIndex = 9;
            this.buttonStartBnBTest.Text = "Rozpocznij test";
            this.buttonStartBnBTest.UseVisualStyleBackColor = true;
            this.buttonStartBnBTest.Click += new System.EventHandler(this.buttonStartBnBTest_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(21, 135);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(161, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Podaj ścieżkę pliku wyjściowego";
            // 
            // buttonSelectOutputPathBnBTest
            // 
            this.buttonSelectOutputPathBnBTest.Location = new System.Drawing.Point(294, 151);
            this.buttonSelectOutputPathBnBTest.Name = "buttonSelectOutputPathBnBTest";
            this.buttonSelectOutputPathBnBTest.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputPathBnBTest.TabIndex = 10;
            this.buttonSelectOutputPathBnBTest.Text = "Wybierz";
            this.buttonSelectOutputPathBnBTest.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputPathBnBTest
            // 
            this.textBoxOutputPathBnBTest.Location = new System.Drawing.Point(24, 151);
            this.textBoxOutputPathBnBTest.Name = "textBoxOutputPathBnBTest";
            this.textBoxOutputPathBnBTest.Size = new System.Drawing.Size(264, 20);
            this.textBoxOutputPathBnBTest.TabIndex = 8;
            // 
            // textBoxNumberOfTrialsBnBTest
            // 
            this.textBoxNumberOfTrialsBnBTest.Location = new System.Drawing.Point(24, 111);
            this.textBoxNumberOfTrialsBnBTest.Name = "textBoxNumberOfTrialsBnBTest";
            this.textBoxNumberOfTrialsBnBTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfTrialsBnBTest.TabIndex = 12;
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
            // textBoxWeightLowBnBTest
            // 
            this.textBoxWeightLowBnBTest.Location = new System.Drawing.Point(48, 72);
            this.textBoxWeightLowBnBTest.Name = "textBoxWeightLowBnBTest";
            this.textBoxWeightLowBnBTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightLowBnBTest.TabIndex = 6;
            // 
            // textBoxSeizeBnBTest
            // 
            this.textBoxSeizeBnBTest.Location = new System.Drawing.Point(24, 36);
            this.textBoxSeizeBnBTest.Name = "textBoxSeizeBnBTest";
            this.textBoxSeizeBnBTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeizeBnBTest.TabIndex = 5;
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
            // 
            // textBoxWeightMaxBnBTest
            // 
            this.textBoxWeightMaxBnBTest.Location = new System.Drawing.Point(181, 72);
            this.textBoxWeightMaxBnBTest.Name = "textBoxWeightMaxBnBTest";
            this.textBoxWeightMaxBnBTest.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightMaxBnBTest.TabIndex = 7;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 529);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "TSP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabBranchAndBound.ResumeLayout(false);
            this.tabBranchAndBound.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTabuSearch.ResumeLayout(false);
            this.tabTabuSearch.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabGenetic.ResumeLayout(false);
            this.tabGenetic.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabTests.ResumeLayout(false);
            this.tabControlTest.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBnB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonLoadFileBnB;
        private System.Windows.Forms.Button buttonRunRandomCitiesBnB;
        private System.Windows.Forms.TextBox textBoxNumberOfCitiesBnB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBnBSync;
        private System.Windows.Forms.RadioButton radioBnBAsync;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBranchAndBound;
        private System.Windows.Forms.TabPage tabTests;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelTestSize;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelWeightMax;
        private System.Windows.Forms.Label labelWeightLow;
        private System.Windows.Forms.Button buttonSelectOutputPathBnBTest;
        private System.Windows.Forms.Button buttonStartBnBTest;
        private System.Windows.Forms.TextBox textBoxOutputPathBnBTest;
        private System.Windows.Forms.TextBox textBoxWeightMaxBnBTest;
        private System.Windows.Forms.TextBox textBoxWeightLowBnBTest;
        private System.Windows.Forms.TextBox textBoxSeizeBnBTest;
        private System.Windows.Forms.TextBox textBoxNumberOfTrialsBnBTest;
        private System.Windows.Forms.Label labelNumberOfTrials;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRunBnB;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabTabuSearch;
        private System.Windows.Forms.TextBox textBoxTabu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRunTabu;
        private System.Windows.Forms.Button buttonLoadFileTabu;
        private System.Windows.Forms.TabControl tabControlTest;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label labelLoadCities;
        private System.Windows.Forms.Button buttonLoadFileTimestampTabuTest;
        private System.Windows.Forms.Button buttonStartTimestampTabuTest;
        private System.Windows.Forms.Button buttonSelectOutputPathTimeStampTabuTest;
        private System.Windows.Forms.TextBox textBoxOutputPathTimestampTabuTest;
        private System.Windows.Forms.Label labelSelectPathTabu;
        private System.Windows.Forms.TextBox textBoxNumberOfTrialsTimestampTabuTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTimestampTabuTest;
        private System.Windows.Forms.Label labelTimestamp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxOutputPathImprovementByTimeTabuTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStartImprovementByTimeTabuTest;
        private System.Windows.Forms.TabPage tabGenetic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRunGenetic;
        private System.Windows.Forms.Button buttonLoadFileGenetic;
        private System.Windows.Forms.TextBox textBoxGenetic;
    }
}

