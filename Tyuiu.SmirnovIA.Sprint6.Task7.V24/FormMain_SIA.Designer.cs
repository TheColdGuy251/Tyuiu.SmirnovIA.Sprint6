namespace Tyuiu.SmirnovIA.Sprint6.Task7.V24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SIA));
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.panelButton_SIA = new System.Windows.Forms.Panel();
            this.buttonSave_SIA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SIA = new System.Windows.Forms.Button();
            this.buttonHelp_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.openFileDialogTask_SIA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_SIA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_SIA = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewInput_SIA = new System.Windows.Forms.DataGridView();
            this.groupBoxInput_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_SIA = new System.Windows.Forms.TextBox();
            this.dataGridViewOutput_SIA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_SIA = new System.Windows.Forms.GroupBox();
            this.panelBetweenButtons_SIA = new System.Windows.Forms.Panel();
            this.splitContainerResult_SIA = new System.Windows.Forms.SplitContainer();
            this.groupBoxTask_SIA.SuspendLayout();
            this.panelButton_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_SIA)).BeginInit();
            this.groupBoxInput_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SIA)).BeginInit();
            this.groupBoxOutput_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerResult_SIA)).BeginInit();
            this.splitContainerResult_SIA.Panel1.SuspendLayout();
            this.splitContainerResult_SIA.Panel2.SuspendLayout();
            this.splitContainerResult_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(0, 65);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(800, 76);
            this.groupBoxTask_SIA.TabIndex = 29;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(794, 55);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // panelButton_SIA
            // 
            this.panelButton_SIA.AutoSize = true;
            this.panelButton_SIA.Controls.Add(this.panelBetweenButtons_SIA);
            this.panelButton_SIA.Controls.Add(this.buttonSave_SIA);
            this.panelButton_SIA.Controls.Add(this.buttonDone_SIA);
            this.panelButton_SIA.Controls.Add(this.buttonHelp_SIA);
            this.panelButton_SIA.Controls.Add(this.buttonOpenFile_SIA);
            this.panelButton_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelButton_SIA.Name = "panelButton_SIA";
            this.panelButton_SIA.Size = new System.Drawing.Size(800, 65);
            this.panelButton_SIA.TabIndex = 30;
            // 
            // buttonSave_SIA
            // 
            this.buttonSave_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave_SIA.BackgroundImage")));
            this.buttonSave_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave_SIA.Enabled = false;
            this.buttonSave_SIA.Location = new System.Drawing.Point(156, 0);
            this.buttonSave_SIA.Name = "buttonSave_SIA";
            this.buttonSave_SIA.Size = new System.Drawing.Size(77, 65);
            this.buttonSave_SIA.TabIndex = 3;
            this.toolTipButton_SIA.SetToolTip(this.buttonSave_SIA, "Сохранить обработанные данные в формате CSV");
            this.buttonSave_SIA.UseVisualStyleBackColor = true;
            this.buttonSave_SIA.Click += new System.EventHandler(this.buttonSave_SIA_Click);
            this.buttonSave_SIA.MouseEnter += new System.EventHandler(this.buttonSave_SIA_MouseEnter);
            // 
            // buttonOpenFile_SIA
            // 
            this.buttonOpenFile_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SIA.BackgroundImage")));
            this.buttonOpenFile_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOpenFile_SIA.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenFile_SIA.Name = "buttonOpenFile_SIA";
            this.buttonOpenFile_SIA.Size = new System.Drawing.Size(79, 65);
            this.buttonOpenFile_SIA.TabIndex = 0;
            this.toolTipButton_SIA.SetToolTip(this.buttonOpenFile_SIA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_SIA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SIA.Click += new System.EventHandler(this.buttonOpenFile_SIA_Click);
            this.buttonOpenFile_SIA.MouseEnter += new System.EventHandler(this.buttonOpenFile_SIA_MouseEnter);
            // 
            // buttonHelp_SIA
            // 
            this.buttonHelp_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SIA.BackgroundImage")));
            this.buttonHelp_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_SIA.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_SIA.Location = new System.Drawing.Point(721, 0);
            this.buttonHelp_SIA.Name = "buttonHelp_SIA";
            this.buttonHelp_SIA.Size = new System.Drawing.Size(79, 65);
            this.buttonHelp_SIA.TabIndex = 2;
            this.toolTipButton_SIA.SetToolTip(this.buttonHelp_SIA, "Сведения о программе");
            this.buttonHelp_SIA.UseVisualStyleBackColor = true;
            this.buttonHelp_SIA.Click += new System.EventHandler(this.buttonHelp_SIA_Click);
            this.buttonHelp_SIA.MouseEnter += new System.EventHandler(this.buttonHelp_SIA_MouseEnter);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone_SIA.BackgroundImage")));
            this.buttonDone_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDone_SIA.Enabled = false;
            this.buttonDone_SIA.Location = new System.Drawing.Point(79, 0);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(77, 65);
            this.buttonDone_SIA.TabIndex = 1;
            this.toolTipButton_SIA.SetToolTip(this.buttonDone_SIA, "Выполнить обработку данных");
            this.buttonDone_SIA.UseVisualStyleBackColor = true;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SIA_Click);
            this.buttonDone_SIA.MouseEnter += new System.EventHandler(this.buttonDone_SIA_MouseEnter);
            // 
            // openFileDialogTask_SIA
            // 
            this.openFileDialogTask_SIA.FileName = "openFileDialog1";
            // 
            // toolTipButton_SIA
            // 
            this.toolTipButton_SIA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dataGridViewInput_SIA
            // 
            this.dataGridViewInput_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_SIA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInput_SIA.Name = "dataGridViewInput_SIA";
            this.dataGridViewInput_SIA.Size = new System.Drawing.Size(382, 288);
            this.dataGridViewInput_SIA.TabIndex = 2;
            // 
            // groupBoxInput_SIA
            // 
            this.groupBoxInput_SIA.Controls.Add(this.dataGridViewInput_SIA);
            this.groupBoxInput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_SIA.Name = "groupBoxInput_SIA";
            this.groupBoxInput_SIA.Size = new System.Drawing.Size(388, 309);
            this.groupBoxInput_SIA.TabIndex = 25;
            this.groupBoxInput_SIA.TabStop = false;
            this.groupBoxInput_SIA.Text = "Ввод:";
            // 
            // textBoxOutput_SIA
            // 
            this.textBoxOutput_SIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_SIA.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutput_SIA.Multiline = true;
            this.textBoxOutput_SIA.Name = "textBoxOutput_SIA";
            this.textBoxOutput_SIA.ReadOnly = true;
            this.textBoxOutput_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SIA.Size = new System.Drawing.Size(402, 288);
            this.textBoxOutput_SIA.TabIndex = 2;
            // 
            // dataGridViewOutput_SIA
            // 
            this.dataGridViewOutput_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_SIA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutput_SIA.Name = "dataGridViewOutput_SIA";
            this.dataGridViewOutput_SIA.Size = new System.Drawing.Size(402, 288);
            this.dataGridViewOutput_SIA.TabIndex = 3;
            // 
            // groupBoxOutput_SIA
            // 
            this.groupBoxOutput_SIA.Controls.Add(this.dataGridViewOutput_SIA);
            this.groupBoxOutput_SIA.Controls.Add(this.textBoxOutput_SIA);
            this.groupBoxOutput_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_SIA.Name = "groupBoxOutput_SIA";
            this.groupBoxOutput_SIA.Size = new System.Drawing.Size(408, 309);
            this.groupBoxOutput_SIA.TabIndex = 26;
            this.groupBoxOutput_SIA.TabStop = false;
            this.groupBoxOutput_SIA.Text = "Вывод:";
            // 
            // panelBetweenButtons_SIA
            // 
            this.panelBetweenButtons_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBetweenButtons_SIA.Location = new System.Drawing.Point(233, 0);
            this.panelBetweenButtons_SIA.Name = "panelBetweenButtons_SIA";
            this.panelBetweenButtons_SIA.Size = new System.Drawing.Size(488, 65);
            this.panelBetweenButtons_SIA.TabIndex = 4;
            // 
            // splitContainerResult_SIA
            // 
            this.splitContainerResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerResult_SIA.Location = new System.Drawing.Point(0, 141);
            this.splitContainerResult_SIA.Name = "splitContainerResult_SIA";
            // 
            // splitContainerResult_SIA.Panel1
            // 
            this.splitContainerResult_SIA.Panel1.Controls.Add(this.groupBoxInput_SIA);
            // 
            // splitContainerResult_SIA.Panel2
            // 
            this.splitContainerResult_SIA.Panel2.Controls.Add(this.groupBoxOutput_SIA);
            this.splitContainerResult_SIA.Size = new System.Drawing.Size(800, 309);
            this.splitContainerResult_SIA.SplitterDistance = 388;
            this.splitContainerResult_SIA.TabIndex = 31;
            // 
            // FormMain_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerResult_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.Controls.Add(this.panelButton_SIA);
            this.Name = "FormMain_SIA";
            this.Text = "Спринт 6 | Таск 7 | Вариант 24 | Смирнов И. А.";
            this.Load += new System.EventHandler(this.FormMain_SIA_Load);
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.panelButton_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_SIA)).EndInit();
            this.groupBoxInput_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SIA)).EndInit();
            this.groupBoxOutput_SIA.ResumeLayout(false);
            this.groupBoxOutput_SIA.PerformLayout();
            this.splitContainerResult_SIA.Panel1.ResumeLayout(false);
            this.splitContainerResult_SIA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerResult_SIA)).EndInit();
            this.splitContainerResult_SIA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.Panel panelButton_SIA;
        private System.Windows.Forms.Button buttonSave_SIA;
        private System.Windows.Forms.Button buttonOpenFile_SIA;
        private System.Windows.Forms.Button buttonHelp_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.ToolTip toolTipButton_SIA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SIA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SIA;
        private System.Windows.Forms.DataGridView dataGridViewInput_SIA;
        private System.Windows.Forms.GroupBox groupBoxInput_SIA;
        private System.Windows.Forms.TextBox textBoxOutput_SIA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_SIA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SIA;
        private System.Windows.Forms.Panel panelBetweenButtons_SIA;
        private System.Windows.Forms.SplitContainer splitContainerResult_SIA;
    }
}

