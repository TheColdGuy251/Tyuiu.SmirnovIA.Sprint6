namespace Tyuiu.SmirnovIA.Sprint6.Task5.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SIA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.panelInputButtons_SIA = new System.Windows.Forms.Panel();
            this.buttonOpen_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.buttonExecute_SIA = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNum_SIA = new System.Windows.Forms.DataGridView();
            this.chartResult_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_SIA.SuspendLayout();
            this.panelInputButtons_SIA.SuspendLayout();
            this.groupBoxOutPut_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNum_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(802, 92);
            this.groupBoxTask_SIA.TabIndex = 23;
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
            this.textBoxTask_SIA.Size = new System.Drawing.Size(740, 70);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // panelInputButtons_SIA
            // 
            this.panelInputButtons_SIA.Controls.Add(this.buttonOpen_SIA);
            this.panelInputButtons_SIA.Controls.Add(this.buttonHelp_SIA);
            this.panelInputButtons_SIA.Controls.Add(this.buttonExecute_SIA);
            this.panelInputButtons_SIA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInputButtons_SIA.Location = new System.Drawing.Point(802, 0);
            this.panelInputButtons_SIA.Name = "panelInputButtons_SIA";
            this.panelInputButtons_SIA.Size = new System.Drawing.Size(316, 92);
            this.panelInputButtons_SIA.TabIndex = 24;
            // 
            // buttonOpen_SIA
            // 
            this.buttonOpen_SIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpen_SIA.Location = new System.Drawing.Point(113, 3);
            this.buttonOpen_SIA.Name = "buttonOpen_SIA";
            this.buttonOpen_SIA.Size = new System.Drawing.Size(93, 65);
            this.buttonOpen_SIA.TabIndex = 20;
            this.buttonOpen_SIA.Text = "Открыть файл";
            this.buttonOpen_SIA.UseVisualStyleBackColor = false;
            this.buttonOpen_SIA.Click += new System.EventHandler(this.buttonOpen_SIA_Click);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_SIA.Location = new System.Drawing.Point(222, 3);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(82, 65);
            this.buttonHelp_SIA.TabIndex = 18;
            this.buttonHelp_SIA.Text = "Справка";
            this.buttonHelp_SIA.UseVisualStyleBackColor = false;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_SIA_Click);
            // 
            // buttonExecute_SIA
            // 
            this.buttonExecute_SIA.BackColor = System.Drawing.Color.Green;
            this.buttonExecute_SIA.Location = new System.Drawing.Point(16, 3);
            this.buttonExecute_SIA.Name = "buttonExecute_SIA";
            this.buttonExecute_SIA.Size = new System.Drawing.Size(82, 65);
            this.buttonExecute_SIA.TabIndex = 19;
            this.buttonExecute_SIA.Text = "Выполнить";
            this.buttonExecute_SIA.UseVisualStyleBackColor = false;
            this.buttonExecute_SIA.Click += new System.EventHandler(this.buttonExecute_SIA_Click);
            // 
            // groupBoxOutPut_SIA
            // 
            this.groupBoxOutPut_SIA.Controls.Add(this.splitter1);
            this.groupBoxOutPut_SIA.Controls.Add(this.chartResult_SIA);
            this.groupBoxOutPut_SIA.Controls.Add(this.dataGridViewNum_SIA);
            this.groupBoxOutPut_SIA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOutPut_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_SIA.Location = new System.Drawing.Point(0, 92);
            this.groupBoxOutPut_SIA.Name = "groupBoxOutPut_SIA";
            this.groupBoxOutPut_SIA.Size = new System.Drawing.Size(1118, 597);
            this.groupBoxOutPut_SIA.TabIndex = 22;
            this.groupBoxOutPut_SIA.TabStop = false;
            this.groupBoxOutPut_SIA.Text = "Вывод данных";
            // 
            // dataGridViewNum_SIA
            // 
            this.dataGridViewNum_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNum_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewNum_SIA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewNum_SIA.Name = "dataGridViewNum_SIA";
            this.dataGridViewNum_SIA.Size = new System.Drawing.Size(240, 576);
            this.dataGridViewNum_SIA.TabIndex = 4;
            // 
            // chartResult_SIA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_SIA.ChartAreas.Add(chartArea2);
            this.chartResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartResult_SIA.Legends.Add(legend2);
            this.chartResult_SIA.Location = new System.Drawing.Point(243, 18);
            this.chartResult_SIA.Name = "chartResult_SIA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_SIA.Series.Add(series2);
            this.chartResult_SIA.Size = new System.Drawing.Size(872, 576);
            this.chartResult_SIA.TabIndex = 5;
            this.chartResult_SIA.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(243, 18);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 576);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 689);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.Controls.Add(this.panelInputButtons_SIA);
            this.Controls.Add(this.groupBoxOutPut_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "Спринт 6 | Таск 5 | Вариант 17 | Смирнов И. А.";
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.panelInputButtons_SIA.ResumeLayout(false);
            this.groupBoxOutPut_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNum_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.Panel panelInputButtons_SIA;
        private System.Windows.Forms.Button buttonOpen_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.Button buttonExecute_SIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SIA;
        private System.Windows.Forms.DataGridView dataGridViewNum_SIA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SIA;
    }
}

