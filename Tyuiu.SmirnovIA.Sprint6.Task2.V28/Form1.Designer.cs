namespace Tyuiu.SmirnovIA.Sprint6.Task2.V28
{
    partial class FormMain_SIA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SIA));
            this.buttonExecute_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SIA = new System.Windows.Forms.GroupBox();
            this.chartResult_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_SIA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FfromX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_sia = new System.Windows.Forms.Label();
            this.groupBoxInPut_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SIA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SIA = new System.Windows.Forms.TextBox();
            this.labelStop_SIA = new System.Windows.Forms.Label();
            this.labelStart_SIA = new System.Windows.Forms.Label();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SIA)).BeginInit();
            this.groupBoxInPut_SIA.SuspendLayout();
            this.groupBoxTask_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecute_SIA
            // 
            this.buttonExecute_SIA.BackColor = System.Drawing.Color.Green;
            this.buttonExecute_SIA.Location = new System.Drawing.Point(362, 282);
            this.buttonExecute_SIA.Name = "buttonExecute_SIA";
            this.buttonExecute_SIA.Size = new System.Drawing.Size(93, 65);
            this.buttonExecute_SIA.TabIndex = 9;
            this.buttonExecute_SIA.Text = "Выполнить";
            this.buttonExecute_SIA.UseVisualStyleBackColor = false;
            this.buttonExecute_SIA.Click += new System.EventHandler(this.buttonExecute_SIA_Click);
            this.buttonExecute_SIA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonExecute_SIA_MouseDown);
            this.buttonExecute_SIA.MouseEnter += new System.EventHandler(this.buttonExecute_SIA_MouseEnter);
            this.buttonExecute_SIA.MouseLeave += new System.EventHandler(this.buttonExecute_SIA_MouseLeave);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SIA.Location = new System.Drawing.Point(291, 282);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(65, 65);
            this.buttonHelp_SIA.TabIndex = 8;
            this.buttonHelp_SIA.Text = "Справка";
            this.buttonHelp_SIA.UseVisualStyleBackColor = false;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_SIA_Click);
            // 
            // groupBoxOutPut_SIA
            // 
            this.groupBoxOutPut_SIA.Controls.Add(this.chartResult_SIA);
            this.groupBoxOutPut_SIA.Controls.Add(this.dataGridViewResult_SIA);
            this.groupBoxOutPut_SIA.Controls.Add(this.labelResult_sia);
            this.groupBoxOutPut_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_SIA.Location = new System.Drawing.Point(461, 12);
            this.groupBoxOutPut_SIA.Name = "groupBoxOutPut_SIA";
            this.groupBoxOutPut_SIA.Size = new System.Drawing.Size(534, 335);
            this.groupBoxOutPut_SIA.TabIndex = 7;
            this.groupBoxOutPut_SIA.TabStop = false;
            this.groupBoxOutPut_SIA.Text = "Вывод данных";
            // 
            // chartResult_SIA
            // 
            chartArea7.Name = "ChartArea1";
            this.chartResult_SIA.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartResult_SIA.Legends.Add(legend7);
            this.chartResult_SIA.Location = new System.Drawing.Point(176, 42);
            this.chartResult_SIA.Name = "chartResult_SIA";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartResult_SIA.Series.Add(series7);
            this.chartResult_SIA.Size = new System.Drawing.Size(352, 300);
            this.chartResult_SIA.TabIndex = 3;
            this.chartResult_SIA.Text = "chart1";
            // 
            // dataGridViewResult_SIA
            // 
            this.dataGridViewResult_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.FfromX});
            this.dataGridViewResult_SIA.Location = new System.Drawing.Point(11, 42);
            this.dataGridViewResult_SIA.Name = "dataGridViewResult_SIA";
            this.dataGridViewResult_SIA.RowHeadersVisible = false;
            this.dataGridViewResult_SIA.Size = new System.Drawing.Size(159, 293);
            this.dataGridViewResult_SIA.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 69;
            // 
            // FfromX
            // 
            this.FfromX.HeaderText = "F(X)";
            this.FfromX.Name = "FfromX";
            this.FfromX.ReadOnly = true;
            this.FfromX.Width = 69;
            // 
            // labelResult_sia
            // 
            this.labelResult_sia.AutoSize = true;
            this.labelResult_sia.Location = new System.Drawing.Point(7, 23);
            this.labelResult_sia.Name = "labelResult_sia";
            this.labelResult_sia.Size = new System.Drawing.Size(80, 16);
            this.labelResult_sia.TabIndex = 1;
            this.labelResult_sia.Text = "Результат:";
            // 
            // groupBoxInPut_SIA
            // 
            this.groupBoxInPut_SIA.Controls.Add(this.textBoxStop_SIA);
            this.groupBoxInPut_SIA.Controls.Add(this.textBoxStart_SIA);
            this.groupBoxInPut_SIA.Controls.Add(this.labelStop_SIA);
            this.groupBoxInPut_SIA.Controls.Add(this.labelStart_SIA);
            this.groupBoxInPut_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_SIA.Location = new System.Drawing.Point(7, 282);
            this.groupBoxInPut_SIA.Name = "groupBoxInPut_SIA";
            this.groupBoxInPut_SIA.Size = new System.Drawing.Size(278, 65);
            this.groupBoxInPut_SIA.TabIndex = 6;
            this.groupBoxInPut_SIA.TabStop = false;
            this.groupBoxInPut_SIA.Text = "Ввод данных";
            // 
            // textBoxStop_SIA
            // 
            this.textBoxStop_SIA.Location = new System.Drawing.Point(144, 34);
            this.textBoxStop_SIA.Name = "textBoxStop_SIA";
            this.textBoxStop_SIA.Size = new System.Drawing.Size(128, 22);
            this.textBoxStop_SIA.TabIndex = 3;
            // 
            // textBoxStart_SIA
            // 
            this.textBoxStart_SIA.Location = new System.Drawing.Point(10, 34);
            this.textBoxStart_SIA.Name = "textBoxStart_SIA";
            this.textBoxStart_SIA.Size = new System.Drawing.Size(128, 22);
            this.textBoxStart_SIA.TabIndex = 2;
            // 
            // labelStop_SIA
            // 
            this.labelStop_SIA.AutoSize = true;
            this.labelStop_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop_SIA.Location = new System.Drawing.Point(141, 16);
            this.labelStop_SIA.Name = "labelStop_SIA";
            this.labelStop_SIA.Size = new System.Drawing.Size(84, 16);
            this.labelStop_SIA.TabIndex = 1;
            this.labelStop_SIA.Text = "Конец шага:";
            // 
            // labelStart_SIA
            // 
            this.labelStart_SIA.AutoSize = true;
            this.labelStart_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_SIA.Location = new System.Drawing.Point(7, 16);
            this.labelStart_SIA.Name = "labelStart_SIA";
            this.labelStart_SIA.Size = new System.Drawing.Size(83, 16);
            this.labelStart_SIA.TabIndex = 0;
            this.labelStart_SIA.Text = "Старт шага:";
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(7, 12);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(448, 264);
            this.groupBoxTask_SIA.TabIndex = 5;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(10, 22);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(432, 216);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 355);
            this.Controls.Add(this.buttonExecute_SIA);
            this.Controls.Add(this.buttonHelp_SIA);
            this.Controls.Add(this.groupBoxOutPut_SIA);
            this.Controls.Add(this.groupBoxInPut_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "FormMain_SIA";
            this.groupBoxOutPut_SIA.ResumeLayout(false);
            this.groupBoxOutPut_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SIA)).EndInit();
            this.groupBoxInPut_SIA.ResumeLayout(false);
            this.groupBoxInPut_SIA.PerformLayout();
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SIA;
        private System.Windows.Forms.Label labelResult_sia;
        private System.Windows.Forms.GroupBox groupBoxInPut_SIA;
        private System.Windows.Forms.TextBox textBoxStop_SIA;
        private System.Windows.Forms.TextBox textBoxStart_SIA;
        private System.Windows.Forms.Label labelStop_SIA;
        private System.Windows.Forms.Label labelStart_SIA;
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn FfromX;
    }
}

