namespace Tyuiu.SmirnovIA.Sprint6.Task7.V24
{
    partial class FormAbout_SIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SIA));
            this.buttonOK_SIA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SIA = new System.Windows.Forms.PictureBox();
            this.labelInfo_SIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SIA
            // 
            this.buttonOK_SIA.Location = new System.Drawing.Point(330, 145);
            this.buttonOK_SIA.Name = "buttonOK_SIA";
            this.buttonOK_SIA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SIA.TabIndex = 5;
            this.buttonOK_SIA.Text = "Ок";
            this.buttonOK_SIA.UseVisualStyleBackColor = true;
            this.buttonOK_SIA.Click += new System.EventHandler(this.buttonOK_SIA_Click);
            // 
            // pictureBoxAvatar_SIA
            // 
            this.pictureBoxAvatar_SIA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_SIA.Name = "pictureBoxAvatar_SIA";
            this.pictureBoxAvatar_SIA.Size = new System.Drawing.Size(103, 143);
            this.pictureBoxAvatar_SIA.TabIndex = 4;
            this.pictureBoxAvatar_SIA.TabStop = false;
            // 
            // labelInfo_SIA
            // 
            this.labelInfo_SIA.AutoSize = true;
            this.labelInfo_SIA.Location = new System.Drawing.Point(121, 12);
            this.labelInfo_SIA.Name = "labelInfo_SIA";
            this.labelInfo_SIA.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_SIA.TabIndex = 3;
            this.labelInfo_SIA.Text = resources.GetString("labelInfo_SIA.Text");
            // 
            // FormAbout_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 176);
            this.Controls.Add(this.buttonOK_SIA);
            this.Controls.Add(this.pictureBoxAvatar_SIA);
            this.Controls.Add(this.labelInfo_SIA);
            this.Name = "FormAbout_SIA";
            this.Text = "FormAbout_SIA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_SIA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SIA;
        private System.Windows.Forms.Label labelInfo_SIA;
    }
}