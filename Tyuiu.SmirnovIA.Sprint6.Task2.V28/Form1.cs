using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SmirnovIA.Sprint6.Task2.V28.Lib;
namespace Tyuiu.SmirnovIA.Sprint6.Task2.V28
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonExecute_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SIA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SIA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_SIA.Titles.Clear();
                this.dataGridViewResult_SIA.Rows.Clear();
                this.chartResult_SIA.Series[0].Points.Clear();
                this.chartResult_SIA.Titles.Add("График заданной функции");
                this.chartResult_SIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SIA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SIA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_SIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    
                    startStep++;
                }
                
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-3 Смирнов Илья Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
