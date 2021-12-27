namespace EramusManager
{
    partial class SelecaoDeEstudantes
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
            this.labelnomedoaluno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSIM = new System.Windows.Forms.RadioButton();
            this.radioButtonNAO = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonESPANHOL = new System.Windows.Forms.RadioButton();
            this.radioButtonINGLES = new System.Windows.Forms.RadioButton();
            this.radioButtonFRANCES = new System.Windows.Forms.RadioButton();
            this.radioButtonITALIANO = new System.Windows.Forms.RadioButton();
            this.radioButtonALEMAO = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelnomedoaluno
            // 
            this.labelnomedoaluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnomedoaluno.AutoSize = true;
            this.labelnomedoaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomedoaluno.Location = new System.Drawing.Point(290, 30);
            this.labelnomedoaluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnomedoaluno.Name = "labelnomedoaluno";
            this.labelnomedoaluno.Size = new System.Drawing.Size(178, 29);
            this.labelnomedoaluno.TabIndex = 6;
            this.labelnomedoaluno.Text = "Nome do aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(140, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "O estudante já resolveu ou conseguiu resolver problemas \nrelativos à sua área de " +
    "estudo sem a ajuda de colegas?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonSIM
            // 
            this.radioButtonSIM.AutoSize = true;
            this.radioButtonSIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonSIM.Location = new System.Drawing.Point(144, 127);
            this.radioButtonSIM.Name = "radioButtonSIM";
            this.radioButtonSIM.Size = new System.Drawing.Size(52, 22);
            this.radioButtonSIM.TabIndex = 8;
            this.radioButtonSIM.TabStop = true;
            this.radioButtonSIM.Text = "Sim";
            this.radioButtonSIM.UseVisualStyleBackColor = true;
            // 
            // radioButtonNAO
            // 
            this.radioButtonNAO.AutoSize = true;
            this.radioButtonNAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonNAO.Location = new System.Drawing.Point(144, 150);
            this.radioButtonNAO.Name = "radioButtonNAO";
            this.radioButtonNAO.Size = new System.Drawing.Size(54, 22);
            this.radioButtonNAO.TabIndex = 9;
            this.radioButtonNAO.TabStop = true;
            this.radioButtonNAO.Text = "Não";
            this.radioButtonNAO.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(140, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "O estudante tem conhecimento médio ou avançado de entre\nas seguintes línguas?";
            // 
            // radioButtonESPANHOL
            // 
            this.radioButtonESPANHOL.AutoSize = true;
            this.radioButtonESPANHOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonESPANHOL.Location = new System.Drawing.Point(144, 260);
            this.radioButtonESPANHOL.Name = "radioButtonESPANHOL";
            this.radioButtonESPANHOL.Size = new System.Drawing.Size(88, 22);
            this.radioButtonESPANHOL.TabIndex = 12;
            this.radioButtonESPANHOL.TabStop = true;
            this.radioButtonESPANHOL.Text = "Espanhol";
            this.radioButtonESPANHOL.UseVisualStyleBackColor = true;
            // 
            // radioButtonINGLES
            // 
            this.radioButtonINGLES.AutoSize = true;
            this.radioButtonINGLES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonINGLES.Location = new System.Drawing.Point(144, 232);
            this.radioButtonINGLES.Name = "radioButtonINGLES";
            this.radioButtonINGLES.Size = new System.Drawing.Size(64, 22);
            this.radioButtonINGLES.TabIndex = 11;
            this.radioButtonINGLES.TabStop = true;
            this.radioButtonINGLES.Text = "Inglês";
            this.radioButtonINGLES.UseVisualStyleBackColor = true;
            // 
            // radioButtonFRANCES
            // 
            this.radioButtonFRANCES.AutoSize = true;
            this.radioButtonFRANCES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonFRANCES.Location = new System.Drawing.Point(144, 288);
            this.radioButtonFRANCES.Name = "radioButtonFRANCES";
            this.radioButtonFRANCES.Size = new System.Drawing.Size(80, 22);
            this.radioButtonFRANCES.TabIndex = 13;
            this.radioButtonFRANCES.TabStop = true;
            this.radioButtonFRANCES.Text = "Francês";
            this.radioButtonFRANCES.UseVisualStyleBackColor = true;
            this.radioButtonFRANCES.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButtonITALIANO
            // 
            this.radioButtonITALIANO.AutoSize = true;
            this.radioButtonITALIANO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonITALIANO.Location = new System.Drawing.Point(144, 316);
            this.radioButtonITALIANO.Name = "radioButtonITALIANO";
            this.radioButtonITALIANO.Size = new System.Drawing.Size(72, 22);
            this.radioButtonITALIANO.TabIndex = 14;
            this.radioButtonITALIANO.TabStop = true;
            this.radioButtonITALIANO.Text = "Italiano";
            this.radioButtonITALIANO.UseVisualStyleBackColor = true;
            // 
            // radioButtonALEMAO
            // 
            this.radioButtonALEMAO.AutoSize = true;
            this.radioButtonALEMAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioButtonALEMAO.Location = new System.Drawing.Point(144, 344);
            this.radioButtonALEMAO.Name = "radioButtonALEMAO";
            this.radioButtonALEMAO.Size = new System.Drawing.Size(76, 22);
            this.radioButtonALEMAO.TabIndex = 15;
            this.radioButtonALEMAO.TabStop = true;
            this.radioButtonALEMAO.Text = "Alemão";
            this.radioButtonALEMAO.UseVisualStyleBackColor = true;
            // 
            // SelecaoDeEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonALEMAO);
            this.Controls.Add(this.radioButtonITALIANO);
            this.Controls.Add(this.radioButtonFRANCES);
            this.Controls.Add(this.radioButtonESPANHOL);
            this.Controls.Add(this.radioButtonINGLES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonNAO);
            this.Controls.Add(this.radioButtonSIM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnomedoaluno);
            this.Name = "SelecaoDeEstudantes";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.SelecaoDeEstudantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnomedoaluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSIM;
        private System.Windows.Forms.RadioButton radioButtonNAO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonESPANHOL;
        private System.Windows.Forms.RadioButton radioButtonINGLES;
        private System.Windows.Forms.RadioButton radioButtonFRANCES;
        private System.Windows.Forms.RadioButton radioButtonITALIANO;
        private System.Windows.Forms.RadioButton radioButtonALEMAO;
    }
}