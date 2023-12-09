namespace Tyuiu.SmirnovIA.Sprint6.Task6.V13
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
            this.labelInfo_SIA = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_SIA = new System.Windows.Forms.PictureBox();
            this.buttonOK_SIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_SIA
            // 
            this.labelInfo_SIA.AutoSize = true;
            this.labelInfo_SIA.Location = new System.Drawing.Point(122, 13);
            this.labelInfo_SIA.Name = "labelInfo_SIA";
            this.labelInfo_SIA.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_SIA.TabIndex = 0;
            this.labelInfo_SIA.Text = resources.GetString("labelInfo_SIA.Text");
            // 
            // pictureBoxAvatar_SIA
            // 
            this.pictureBoxAvatar_SIA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_SIA.Name = "pictureBoxAvatar_SIA";
            this.pictureBoxAvatar_SIA.Size = new System.Drawing.Size(103, 143);
            this.pictureBoxAvatar_SIA.TabIndex = 1;
            this.pictureBoxAvatar_SIA.TabStop = false;
            // 
            // buttonOK_SIA
            // 
            this.buttonOK_SIA.Location = new System.Drawing.Point(331, 146);
            this.buttonOK_SIA.Name = "buttonOK_SIA";
            this.buttonOK_SIA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SIA.TabIndex = 2;
            this.buttonOK_SIA.Text = "Ок";
            this.buttonOK_SIA.UseVisualStyleBackColor = true;
            this.buttonOK_SIA.Click += new System.EventHandler(this.buttonOK_SIA_Click);
            // 
            // FormAbout_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 171);
            this.Controls.Add(this.buttonOK_SIA);
            this.Controls.Add(this.pictureBoxAvatar_SIA);
            this.Controls.Add(this.labelInfo_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_SIA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SIA;
        private System.Windows.Forms.Button buttonOK_SIA;
    }
}