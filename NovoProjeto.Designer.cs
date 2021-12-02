namespace EramusManager
{
    partial class NovoProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoProjeto));
            this.label1 = new System.Windows.Forms.Label();
            this.nomedoprojeto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboparceiros = new System.Windows.Forms.ComboBox();
            this.criarprojetobtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novo Projeto";
            // 
            // nomedoprojeto
            // 
            this.nomedoprojeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomedoprojeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomedoprojeto.Location = new System.Drawing.Point(279, 191);
            this.nomedoprojeto.Margin = new System.Windows.Forms.Padding(6);
            this.nomedoprojeto.Multiline = true;
            this.nomedoprojeto.Name = "nomedoprojeto";
            this.nomedoprojeto.Size = new System.Drawing.Size(552, 60);
            this.nomedoprojeto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Projeto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parceiros do Projeto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboparceiros
            // 
            this.comboparceiros.FormattingEnabled = true;
            this.comboparceiros.ItemHeight = 25;
            this.comboparceiros.Location = new System.Drawing.Point(279, 342);
            this.comboparceiros.Name = "comboparceiros";
            this.comboparceiros.Size = new System.Drawing.Size(550, 33);
            this.comboparceiros.TabIndex = 9;
            this.comboparceiros.Text = "Procurar ...";
            // 
            // criarprojetobtt
            // 
            this.criarprojetobtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.criarprojetobtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.criarprojetobtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.criarprojetobtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.criarprojetobtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.criarprojetobtt.ForeColor = System.Drawing.Color.White;
            this.criarprojetobtt.Location = new System.Drawing.Point(329, 534);
            this.criarprojetobtt.Margin = new System.Windows.Forms.Padding(4);
            this.criarprojetobtt.Name = "criarprojetobtt";
            this.criarprojetobtt.Size = new System.Drawing.Size(464, 96);
            this.criarprojetobtt.TabIndex = 10;
            this.criarprojetobtt.Text = "Criar Projeto";
            this.criarprojetobtt.UseVisualStyleBackColor = false;
            // 
            // NovoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 765);
            this.Controls.Add(this.criarprojetobtt);
            this.Controls.Add(this.comboparceiros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomedoprojeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovoProjeto";
            this.Text = "Eramus Manager - Novo Projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomedoprojeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboparceiros;
        private System.Windows.Forms.Button criarprojetobtt;
    }
}