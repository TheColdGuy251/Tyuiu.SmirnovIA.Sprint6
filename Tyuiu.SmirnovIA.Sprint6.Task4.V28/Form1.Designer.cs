namespace Tyuiu.SmirnovIA.Sprint6.Task4.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SIA));
            this.textBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.chartResult_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_SIA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SIA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SIA = new System.Windows.Forms.TextBox();
            this.labelStop_SIA = new System.Windows.Forms.Label();
            this.labelStart_SIA = new System.Windows.Forms.Label();
            this.buttonExecute_SIA = new System.Windows.Forms.Button();
            this.buttonSave_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.panelInputButtons_SIA = new System.Windows.Forms.Panel();
            this.splitterResult_SIA = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SIA)).BeginInit();
            this.groupBoxOutPut_SIA.SuspendLayout();
            this.groupBoxTask_SIA.SuspendLayout();
            this.groupBoxInPut_SIA.SuspendLayout();
            this.panelInputButtons_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult_SIA
            // 
            this.textBoxResult_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxResult_SIA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SIA.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_SIA.Multiline = true;
            this.textBoxResult_SIA.Name = "textBoxResult_SIA";
            this.textBoxResult_SIA.ReadOnly = true;
            this.textBoxResult_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SIA.Size = new System.Drawing.Size(230, 489);
            this.textBoxResult_SIA.TabIndex = 1;
            // 
            // chartResult_SIA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_SIA.ChartAreas.Add(chartArea1);
            this.chartResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_SIA.Legends.Add(legend1);
            this.chartResult_SIA.Location = new System.Drawing.Point(233, 18);
            this.chartResult_SIA.Name = "chartResult_SIA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_SIA.Series.Add(series1);
            this.chartResult_SIA.Size = new System.Drawing.Size(855, 489);
            this.chartResult_SIA.TabIndex = 2;
            this.chartResult_SIA.Text = "chartResult_SIA";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.DodgerBlue;
            title1.Name = "Title1";
            title1.Text = "График заданной функции";
            this.chartResult_SIA.Titles.Add(title1);
            // 
            // groupBoxOutPut_SIA
            // 
            this.groupBoxOutPut_SIA.Controls.Add(this.splitterResult_SIA);
            this.groupBoxOutPut_SIA.Controls.Add(this.chartResult_SIA);
            this.groupBoxOutPut_SIA.Controls.Add(this.textBoxResult_SIA);
            this.groupBoxOutPut_SIA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOutPut_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_SIA.Location = new System.Drawing.Point(0, 176);
            this.groupBoxOutPut_SIA.Name = "groupBoxOutPut_SIA";
            this.groupBoxOutPut_SIA.Size = new System.Drawing.Size(1091, 510);
            this.groupBoxOutPut_SIA.TabIndex = 12;
            this.groupBoxOutPut_SIA.TabStop = false;
            this.groupBoxOutPut_SIA.Text = "Вывод данных";
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(775, 176);
            this.groupBoxTask_SIA.TabIndex = 16;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(8, 16);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(740, 148);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // groupBoxInPut_SIA
            // 
            this.groupBoxInPut_SIA.Controls.Add(this.textBoxStop_SIA);
            this.groupBoxInPut_SIA.Controls.Add(this.textBoxStart_SIA);
            this.groupBoxInPut_SIA.Controls.Add(this.labelStop_SIA);
            this.groupBoxInPut_SIA.Controls.Add(this.labelStart_SIA);
            this.groupBoxInPut_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_SIA.Location = new System.Drawing.Point(6, 0);
            this.groupBoxInPut_SIA.Name = "groupBoxInPut_SIA";
            this.groupBoxInPut_SIA.Size = new System.Drawing.Size(290, 65);
            this.groupBoxInPut_SIA.TabIndex = 17;
            this.groupBoxInPut_SIA.TabStop = false;
            this.groupBoxInPut_SIA.Text = "Ввод данных";
            // 
            // textBoxStop_SIA
            // 
            this.textBoxStop_SIA.Location = new System.Drawing.Point(151, 34);
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
            this.labelStop_SIA.Location = new System.Drawing.Point(148, 16);
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
            // buttonExecute_SIA
            // 
            this.buttonExecute_SIA.BackColor = System.Drawing.Color.Green;
            this.buttonExecute_SIA.Location = new System.Drawing.Point(16, 71);
            this.buttonExecute_SIA.Name = "buttonExecute_SIA";
            this.buttonExecute_SIA.Size = new System.Drawing.Size(82, 65);
            this.buttonExecute_SIA.TabIndex = 19;
            this.buttonExecute_SIA.Text = "Выполнить";
            this.buttonExecute_SIA.UseVisualStyleBackColor = false;
            this.buttonExecute_SIA.Click += new System.EventHandler(this.buttonExecute_SIA_Click);
            // 
            // buttonSave_SIA
            // 
            this.buttonSave_SIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_SIA.Location = new System.Drawing.Point(104, 71);
            this.buttonSave_SIA.Name = "buttonSave_SIA";
            this.buttonSave_SIA.Size = new System.Drawing.Size(93, 65);
            this.buttonSave_SIA.TabIndex = 20;
            this.buttonSave_SIA.Text = "Сохранить";
            this.buttonSave_SIA.UseVisualStyleBackColor = false;
            this.buttonSave_SIA.Click += new System.EventHandler(this.buttonSave_SIA_Click);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_SIA.Location = new System.Drawing.Point(203, 71);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(82, 65);
            this.buttonHelp_SIA.TabIndex = 18;
            this.buttonHelp_SIA.Text = "Справка";
            this.buttonHelp_SIA.UseVisualStyleBackColor = false;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_SIA_Click);
            // 
            // panelInputButtons_SIA
            // 
            this.panelInputButtons_SIA.Controls.Add(this.groupBoxInPut_SIA);
            this.panelInputButtons_SIA.Controls.Add(this.buttonSave_SIA);
            this.panelInputButtons_SIA.Controls.Add(this.buttonHelp_SIA);
            this.panelInputButtons_SIA.Controls.Add(this.buttonExecute_SIA);
            this.panelInputButtons_SIA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInputButtons_SIA.Location = new System.Drawing.Point(775, 0);
            this.panelInputButtons_SIA.Name = "panelInputButtons_SIA";
            this.panelInputButtons_SIA.Size = new System.Drawing.Size(316, 176);
            this.panelInputButtons_SIA.TabIndex = 21;
            // 
            // splitterResult_SIA
            // 
            this.splitterResult_SIA.Location = new System.Drawing.Point(233, 18);
            this.splitterResult_SIA.Name = "splitterResult_SIA";
            this.splitterResult_SIA.Size = new System.Drawing.Size(3, 489);
            this.splitterResult_SIA.TabIndex = 3;
            this.splitterResult_SIA.TabStop = false;
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 686);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.Controls.Add(this.panelInputButtons_SIA);
            this.Controls.Add(this.groupBoxOutPut_SIA);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1107, 725);
            this.Name = "FormMain_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 4 | Вариант 28 | Смирнов И. А.";
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SIA)).EndInit();
            this.groupBoxOutPut_SIA.ResumeLayout(false);
            this.groupBoxOutPut_SIA.PerformLayout();
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.groupBoxInPut_SIA.ResumeLayout(false);
            this.groupBoxInPut_SIA.PerformLayout();
            this.panelInputButtons_SIA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SIA;
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SIA;
        private System.Windows.Forms.TextBox textBoxStop_SIA;
        private System.Windows.Forms.TextBox textBoxStart_SIA;
        private System.Windows.Forms.Label labelStop_SIA;
        private System.Windows.Forms.Label labelStart_SIA;
        private System.Windows.Forms.Button buttonExecute_SIA;
        private System.Windows.Forms.Button buttonSave_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.Panel panelInputButtons_SIA;
        private System.Windows.Forms.Splitter splitterResult_SIA;
    }
}

