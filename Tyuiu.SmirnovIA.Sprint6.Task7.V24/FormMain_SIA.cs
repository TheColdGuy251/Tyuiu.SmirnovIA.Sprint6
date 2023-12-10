using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.SmirnovIA.Sprint6.Task7.V24.Lib;

namespace Tyuiu.SmirnovIA.Sprint6.Task7.V24
{
    public partial class FormMain_SIA : Form
    {
        public FormMain_SIA()
        {
            InitializeComponent();
            openFileDialogTask_SIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_SIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SIA.ShowDialog();
            openFilePath = openFileDialogTask_SIA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_SIA.ColumnCount = columns;
            dataGridViewInput_SIA.RowCount = rows;
            dataGridViewOutput_SIA.ColumnCount = columns;
            dataGridViewOutput_SIA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_SIA.Columns[i].Width = 30;
                dataGridViewOutput_SIA.Columns[i].Width = 30;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_SIA.Enabled = true;
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_SIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_SIA.Enabled = true;
        }

        private void buttonSave_SIA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SIA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SIA.ShowDialog(); 

            string path = saveFileDialogMatrix_SIA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists; 

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutput_SIA.RowCount;
            int columns = dataGridViewOutput_SIA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <  columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_SIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_SIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            FormAbout_SIA formAbout = new FormAbout_SIA();
            formAbout.ShowDialog();
        }

        private void FormMain_SIA_Load(object sender, EventArgs e)
        {
            dataGridViewInput_SIA.ColumnCount = 50;
            dataGridViewOutput_SIA.ColumnCount = 50;

            dataGridViewInput_SIA.RowCount = 50;
            dataGridViewOutput_SIA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_SIA.Columns[i].Width = 30;
                dataGridViewOutput_SIA.Columns[i].Width = 30;
            }
        }

        private void buttonOpenFile_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SIA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SIA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SIA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_SIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SIA.ToolTipTitle = "Сведения";
        }
    }
}
