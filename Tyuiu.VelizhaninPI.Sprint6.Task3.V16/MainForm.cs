using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VelizhaninPI.Sprint6.Task3.V16.Lib;

namespace Tyuiu.VelizhaninPI.Sprint6.Task3.V16
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[,] { {14, 1, -3, 1, 10 },
                                   {7, -3, 5, -4, 0 },
                                   {-10, -19, -18, -9, 19},
                                   {-2, -2, -16, 2, -17},
                                   {-16, 9, 5, -10, 16} };

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;    //stroki
            int columns = mtrx.Length / rows;    //stolbiki

            dataGridViewOutput.ColumnCount = columns;
            dataGridViewOutput.RowCount = rows;

            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutput.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;    //stroki
            int columns = mtrx.Length / rows;    //stolbiki

            dataGridViewInput.ColumnCount = columns;
            dataGridViewInput.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 Велижанин Павел Ильич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
