using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VelizhaninPI.Sprint6.Task7.V10.Lib;
using System.IO;

namespace Tyuiu.VelizhaninPI.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();


        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput.ColumnCount = colums;
            dataGridViewInput.RowCount = rows;
            dataGridViewOutput.ColumnCount = colums;
            dataGridViewOutput.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewInput.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }


        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutput.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput.RowCount;
            int columns = dataGridViewOutput.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput.ColumnCount = 50;
            dataGridViewOutput.ColumnCount = 50;

            dataGridViewInput.RowCount = 50;
            dataGridViewOutput.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }
        }

        private void buttonOpen_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonAbout_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Справка";
        }
    }
}
