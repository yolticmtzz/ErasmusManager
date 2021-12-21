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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.estadolabel = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novo Projeto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomedoprojeto
            // 
            this.nomedoprojeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomedoprojeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomedoprojeto.Location = new System.Drawing.Point(296, 117);
            this.nomedoprojeto.Multiline = true;
            this.nomedoprojeto.Name = "nomedoprojeto";
            this.nomedoprojeto.Size = new System.Drawing.Size(276, 31);
            this.nomedoprojeto.TabIndex = 7;
            this.nomedoprojeto.TextChanged += new System.EventHandler(this.nomedoprojeto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Projeto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parceiros do Projeto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboparceiros
            // 
            this.comboparceiros.FormattingEnabled = true;
            this.comboparceiros.ItemHeight = 13;
            this.comboparceiros.Location = new System.Drawing.Point(295, 198);
            this.comboparceiros.Margin = new System.Windows.Forms.Padding(2);
            this.comboparceiros.Name = "comboparceiros";
            this.comboparceiros.Size = new System.Drawing.Size(277, 21);
            this.comboparceiros.TabIndex = 9;
            this.comboparceiros.Text = "Procurar ...";
            this.comboparceiros.SelectedIndexChanged += new System.EventHandler(this.comboparceiros_SelectedIndexChanged);
            // 
            // criarprojetobtt
            // 
            this.criarprojetobtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.criarprojetobtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.criarprojetobtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.criarprojetobtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.criarprojetobtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.criarprojetobtt.ForeColor = System.Drawing.Color.White;
            this.criarprojetobtt.Location = new System.Drawing.Point(340, 320);
            this.criarprojetobtt.Margin = new System.Windows.Forms.Padding(2);
            this.criarprojetobtt.Name = "criarprojetobtt";
            this.criarprojetobtt.Size = new System.Drawing.Size(232, 50);
            this.criarprojetobtt.TabIndex = 10;
            this.criarprojetobtt.Text = "Criar Projeto";
            this.criarprojetobtt.UseVisualStyleBackColor = false;
            this.criarprojetobtt.Click += new System.EventHandler(this.criarprojetobtt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado do Projeto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(296, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 20);
            this.panel1.TabIndex = 13;
            // 
            // estadolabel
            // 
            this.estadolabel.AutoSize = true;
            this.estadolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadolabel.Location = new System.Drawing.Point(325, 273);
            this.estadolabel.Name = "estadolabel";
            this.estadolabel.Size = new System.Drawing.Size(118, 20);
            this.estadolabel.TabIndex = 14;
            this.estadolabel.Text = "Em andamento";
            this.estadolabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(52, 336);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.TabIndex = 15;
            this.test.Text = "label5";
            // 
            // NovoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 441);
            this.Controls.Add(this.test);
            this.Controls.Add(this.estadolabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.criarprojetobtt);
            this.Controls.Add(this.comboparceiros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomedoprojeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NovoProjeto";
            this.Text = "Eramus Manager - Novo Projeto";
            this.Load += new System.EventHandler(this.NovoProjeto_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label estadolabel;
        private System.Windows.Forms.Label test;
    }
}