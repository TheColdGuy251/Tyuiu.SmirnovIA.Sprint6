using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SmirnovIA.Sprint6.Task5.V17.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task5.V17
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"D:\tyuiu projects\Tyuiu.SmirnovIA.Sprint6\Tyuiu.SmirnovIA.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";

        private void buttonExecute_SIA_Click(object sender, EventArgs e)
        {
            dataGridViewNum_SIA.ColumnCount = 2;
            dataGridViewNum_SIA.Columns[0].Width = 35;
            dataGridViewNum_SIA.Columns[1].Width = 60;

            this.chartResult_SIA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_SIA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_SIA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNum_SIA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_SIA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_SIA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-3 Смирнов Илья Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
