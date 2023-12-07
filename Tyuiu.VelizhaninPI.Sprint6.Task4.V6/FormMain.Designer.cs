
namespace Tyuiu.VelizhaninPI.Sprint6.Task4.V6
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelVarEnd = new System.Windows.Forms.Label();
            this.labelVarStart = new System.Windows.Forms.Label();
            this.textBoxVarEnd = new System.Windows.Forms.TextBox();
            this.textBoxVarStart = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartFormula = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.groupBoxInput);
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.groupBoxTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 101);
            this.panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave.Location = new System.Drawing.Point(753, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 83);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.White;
            this.buttonDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone.Location = new System.Drawing.Point(640, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(107, 83);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelVarEnd);
            this.groupBoxInput.Controls.Add(this.labelVarStart);
            this.groupBoxInput.Controls.Add(this.textBoxVarEnd);
            this.groupBoxInput.Controls.Add(this.textBoxVarStart);
            this.groupBoxInput.Location = new System.Drawing.Point(381, 3);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(253, 92);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelVarEnd
            // 
            this.labelVarEnd.AutoSize = true;
            this.labelVarEnd.ForeColor = System.Drawing.Color.White;
            this.labelVarEnd.Location = new System.Drawing.Point(126, 22);
            this.labelVarEnd.Name = "labelVarEnd";
            this.labelVarEnd.Size = new System.Drawing.Size(89, 17);
            this.labelVarEnd.TabIndex = 3;
            this.labelVarEnd.Text = "Конец шага:";
            // 
            // labelVarStart
            // 
            this.labelVarStart.AutoSize = true;
            this.labelVarStart.ForeColor = System.Drawing.Color.White;
            this.labelVarStart.Location = new System.Drawing.Point(7, 22);
            this.labelVarStart.Name = "labelVarStart";
            this.labelVarStart.Size = new System.Drawing.Size(98, 17);
            this.labelVarStart.TabIndex = 2;
            this.labelVarStart.Text = "Начало шага:";
            // 
            // textBoxVarEnd
            // 
            this.textBoxVarEnd.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxVarEnd.Location = new System.Drawing.Point(126, 44);
            this.textBoxVarEnd.Name = "textBoxVarEnd";
            this.textBoxVarEnd.Size = new System.Drawing.Size(113, 22);
            this.textBoxVarEnd.TabIndex = 1;
            // 
            // textBoxVarStart
            // 
            this.textBoxVarStart.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxVarStart.Location = new System.Drawing.Point(7, 44);
            this.textBoxVarStart.Name = "textBoxVarStart";
            this.textBoxVarStart.Size = new System.Drawing.Size(113, 22);
            this.textBoxVarStart.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackColor = System.Drawing.Color.White;
            this.buttonHelp.ForeColor = System.Drawing.Color.Gray;
            this.buttonHelp.Location = new System.Drawing.Point(866, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(82, 83);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(9, 3);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(365, 92);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxTask.Location = new System.Drawing.Point(9, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTask.Size = new System.Drawing.Size(350, 65);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelOutput.Controls.Add(this.groupBoxOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutput.Location = new System.Drawing.Point(0, 101);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(194, 352);
            this.panelOutput.TabIndex = 2;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(9, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(182, 349);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(194, 101);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 352);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelChart.Controls.Add(this.chartFormula);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(197, 101);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(754, 352);
            this.panelChart.TabIndex = 4;
            // 
            // chartFormula
            // 
            this.chartFormula.BackColor = System.Drawing.Color.LightSteelBlue;
            chartArea4.Name = "ChartArea1";
            this.chartFormula.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartFormula.Legends.Add(legend4);
            this.chartFormula.Location = new System.Drawing.Point(6, 7);
            this.chartFormula.Name = "chartFormula";
            this.chartFormula.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFormula.Series.Add(series4);
            this.chartFormula.Size = new System.Drawing.Size(736, 333);
            this.chartFormula.TabIndex = 0;
            this.chartFormula.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(188, 331);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(176, 328);
            this.textBoxOutput.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 453);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(969, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 6 | Велижанин П.И.";
            this.panel1.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFormula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelVarEnd;
        private System.Windows.Forms.Label labelVarStart;
        private System.Windows.Forms.TextBox textBoxVarEnd;
        private System.Windows.Forms.TextBox textBoxVarStart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFormula;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

