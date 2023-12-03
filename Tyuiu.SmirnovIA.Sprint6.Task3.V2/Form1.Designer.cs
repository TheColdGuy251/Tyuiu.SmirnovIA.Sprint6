namespace Tyuiu.SmirnovIA.Sprint6.Task3.V2
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
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_SIA = new System.Windows.Forms.DataGridView();
            this.labelResult_SIA = new System.Windows.Forms.Label();
            this.buttonExecute_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.dataGridViewResult_SIA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_SIA.SuspendLayout();
            this.groupBoxOutPut_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.dataGridViewMatrix_SIA);
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(614, 280);
            this.groupBoxTask_SIA.TabIndex = 0;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // groupBoxOutPut_SIA
            // 
            this.groupBoxOutPut_SIA.Controls.Add(this.dataGridViewResult_SIA);
            this.groupBoxOutPut_SIA.Controls.Add(this.labelResult_SIA);
            this.groupBoxOutPut_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_SIA.Location = new System.Drawing.Point(632, 12);
            this.groupBoxOutPut_SIA.Name = "groupBoxOutPut_SIA";
            this.groupBoxOutPut_SIA.Size = new System.Drawing.Size(286, 280);
            this.groupBoxOutPut_SIA.TabIndex = 1;
            this.groupBoxOutPut_SIA.TabStop = false;
            this.groupBoxOutPut_SIA.Text = "Вывод данных";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(339, 229);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // dataGridViewMatrix_SIA
            // 
            this.dataGridViewMatrix_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SIA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SIA.Location = new System.Drawing.Point(371, 42);
            this.dataGridViewMatrix_SIA.Name = "dataGridViewMatrix_SIA";
            this.dataGridViewMatrix_SIA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SIA.Size = new System.Drawing.Size(237, 227);
            this.dataGridViewMatrix_SIA.TabIndex = 1;
            // 
            // labelResult_SIA
            // 
            this.labelResult_SIA.AutoSize = true;
            this.labelResult_SIA.Location = new System.Drawing.Point(95, 23);
            this.labelResult_SIA.Name = "labelResult_SIA";
            this.labelResult_SIA.Size = new System.Drawing.Size(80, 16);
            this.labelResult_SIA.TabIndex = 0;
            this.labelResult_SIA.Text = "Результат:";
            // 
            // buttonExecute_SIA
            // 
            this.buttonExecute_SIA.Location = new System.Drawing.Point(826, 298);
            this.buttonExecute_SIA.Name = "buttonExecute_SIA";
            this.buttonExecute_SIA.Size = new System.Drawing.Size(92, 29);
            this.buttonExecute_SIA.TabIndex = 2;
            this.buttonExecute_SIA.Text = "Выполнить";
            this.buttonExecute_SIA.UseVisualStyleBackColor = true;
            this.buttonExecute_SIA.Click += new System.EventHandler(this.buttonExecute_SIA_Click);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.Location = new System.Drawing.Point(775, 298);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(36, 29);
            this.buttonHelp_SIA.TabIndex = 3;
            this.buttonHelp_SIA.Text = "?";
            this.buttonHelp_SIA.UseVisualStyleBackColor = true;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_SIA_Click);
            // 
            // dataGridViewResult_SIA
            // 
            this.dataGridViewResult_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SIA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SIA.Location = new System.Drawing.Point(21, 42);
            this.dataGridViewResult_SIA.Name = "dataGridViewResult_SIA";
            this.dataGridViewResult_SIA.RowHeadersVisible = false;
            this.dataGridViewResult_SIA.Size = new System.Drawing.Size(237, 227);
            this.dataGridViewResult_SIA.TabIndex = 2;
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 337);
            this.Controls.Add(this.buttonHelp_SIA);
            this.Controls.Add(this.buttonExecute_SIA);
            this.Controls.Add(this.groupBoxOutPut_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "Спринт 6 | Таск 3 | Вариант 2 | Смирнов И. А.";
            this.Load += new System.EventHandler(this.FormMain_SIA_Load);
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.groupBoxOutPut_SIA.ResumeLayout(false);
            this.groupBoxOutPut_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SIA;
        private System.Windows.Forms.Label labelResult_SIA;
        private System.Windows.Forms.Button buttonExecute_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SIA;
    }
}

