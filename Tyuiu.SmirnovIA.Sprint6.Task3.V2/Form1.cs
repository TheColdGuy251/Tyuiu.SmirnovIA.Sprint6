using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SmirnovIA.Sprint6.Task3.V2.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task3.V2
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{-12, -4, -20, 5, -5},
                          { 2, 15, 1, -20, 7},
                          { 15, -15, 2, 11, 5},
                          { -19, -9, 16, 0, 1},
                          { 17, 16, 5, 12, -8}};
        private void buttonExecute_SIA_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            int[,] gotmtrx = ds.Calculate(mtrx);

            dataGridViewResult_SIA.ColumnCount = columns;
            dataGridViewResult_SIA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SIA.Columns[i].Width = 46;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SIA.Rows[i].Cells[j].Value = Convert.ToString(gotmtrx[i, j]);
                }
            }
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 Смирнов Илья Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_SIA_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_SIA.ColumnCount = columns;
            dataGridViewMatrix_SIA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SIA.Columns[i].Width = 46;
            }
            for(int i = 0;i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SIA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }
    }
}
