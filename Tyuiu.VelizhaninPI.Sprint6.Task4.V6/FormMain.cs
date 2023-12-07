using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VelizhaninPI.Sprint6.Task4.V6.Lib;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart.Text);
                int stopStep = Convert.ToInt32(textBoxVarEnd.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFormula.Titles.Add("График функции F(x)");
                this.chartFormula.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFormula.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput.Text = "";

                chartFormula.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFormula.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutput.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-3 Велижанин Павел Ильич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutput.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + "сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
