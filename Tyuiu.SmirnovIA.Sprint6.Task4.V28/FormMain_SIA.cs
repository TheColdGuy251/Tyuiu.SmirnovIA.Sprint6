using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SmirnovIA.Sprint6.Task4.V28.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task4.V28
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

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                this.chartResult_SIA.Series[0].Points.Clear();
                this.chartResult_SIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SIA.ChartAreas[0].AxisY.Title = "Ось Y";
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SIA.Text = "";
                textBoxResult_SIA.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_SIA.AppendText("|      X     |    F(x)    |" + Environment.NewLine);
                textBoxResult_SIA.AppendText("+------------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|  {0, 5:d}     |   {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_SIA.AppendText(strLine + Environment.NewLine);
                    this.chartResult_SIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
                textBoxResult_SIA.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-3 Смирнов Илья Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_SIA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_SIA_Click_1(object sender, EventArgs e)
        {

        }
    }
}
