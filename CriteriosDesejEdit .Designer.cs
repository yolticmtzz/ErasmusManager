namespace EramusManager
{
    partial class CriteriosDesejEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelautonomia = new System.Windows.Forms.Label();
            this.autonomia = new System.Windows.Forms.ComboBox();
            this.labelcomunicacaoling = new System.Windows.Forms.Label();
            this.linguas = new System.Windows.Forms.ComboBox();
            this.labelareaespecializa = new System.Windows.Forms.Label();
            this.areadeespecializacao = new System.Windows.Forms.ComboBox();
            this.nivelaceitavellingua = new System.Windows.Forms.ComboBox();
            this.labellingua2parte = new System.Windows.Forms.Label();
            this.labelarea2parte = new System.Windows.Forms.Label();
            this.nivelaceitavel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.debugPID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Critérios Desejáveis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelautonomia
            // 
            this.labelautonomia.AutoSize = true;
            this.labelautonomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelautonomia.Location = new System.Drawing.Point(131, 65);
            this.labelautonomia.Name = "labelautonomia";
            this.labelautonomia.Size = new System.Drawing.Size(95, 22);
            this.labelautonomia.TabIndex = 6;
            this.labelautonomia.Text = "Autonomia";
            // 
            // autonomia
            // 
            this.autonomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.autonomia.FormattingEnabled = true;
            this.autonomia.ItemHeight = 18;
            this.autonomia.Location = new System.Drawing.Point(135, 89);
            this.autonomia.Margin = new System.Windows.Forms.Padding(2);
            this.autonomia.Name = "autonomia";
            this.autonomia.Size = new System.Drawing.Size(545, 26);
            this.autonomia.TabIndex = 11;
            this.autonomia.Text = "Coloque o nivel aceitável... (sim ou não)";
            this.autonomia.SelectedIndexChanged += new System.EventHandler(this.comboparceiros_SelectedIndexChanged_1);
            // 
            // labelcomunicacaoling
            // 
            this.labelcomunicacaoling.AutoSize = true;
            this.labelcomunicacaoling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelcomunicacaoling.Location = new System.Drawing.Point(131, 127);
            this.labelcomunicacaoling.Name = "labelcomunicacaoling";
            this.labelcomunicacaoling.Size = new System.Drawing.Size(57, 22);
            this.labelcomunicacaoling.TabIndex = 12;
            this.labelcomunicacaoling.Text = "Inglês";
            this.labelcomunicacaoling.Click += new System.EventHandler(this.labelcomunicacaoling_Click);
            // 
            // linguas
            // 
            this.linguas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linguas.FormattingEnabled = true;
            this.linguas.ItemHeight = 18;
            this.linguas.Location = new System.Drawing.Point(135, 151);
            this.linguas.Margin = new System.Windows.Forms.Padding(2);
            this.linguas.Name = "linguas";
            this.linguas.Size = new System.Drawing.Size(545, 26);
            this.linguas.TabIndex = 13;
            this.linguas.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.linguas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelareaespecializa
            // 
            this.labelareaespecializa.AutoSize = true;
            this.labelareaespecializa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelareaespecializa.Location = new System.Drawing.Point(131, 455);
            this.labelareaespecializa.Name = "labelareaespecializa";
            this.labelareaespecializa.Size = new System.Drawing.Size(204, 22);
            this.labelareaespecializa.TabIndex = 14;
            this.labelareaespecializa.Text = "Áreas de especialização";
            // 
            // areadeespecializacao
            // 
            this.areadeespecializacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.areadeespecializacao.FormattingEnabled = true;
            this.areadeespecializacao.ItemHeight = 18;
            this.areadeespecializacao.Location = new System.Drawing.Point(135, 479);
            this.areadeespecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.areadeespecializacao.Name = "areadeespecializacao";
            this.areadeespecializacao.Size = new System.Drawing.Size(545, 26);
            this.areadeespecializacao.TabIndex = 15;
            this.areadeespecializacao.Text = "Procurar área ...";
            // 
            // nivelaceitavellingua
            // 
            this.nivelaceitavellingua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nivelaceitavellingua.FormattingEnabled = true;
            this.nivelaceitavellingua.ItemHeight = 18;
            this.nivelaceitavellingua.Location = new System.Drawing.Point(134, 216);
            this.nivelaceitavellingua.Margin = new System.Windows.Forms.Padding(2);
            this.nivelaceitavellingua.Name = "nivelaceitavellingua";
            this.nivelaceitavellingua.Size = new System.Drawing.Size(545, 26);
            this.nivelaceitavellingua.TabIndex = 19;
            this.nivelaceitavellingua.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.nivelaceitavellingua.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labellingua2parte
            // 
            this.labellingua2parte.AutoSize = true;
            this.labellingua2parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labellingua2parte.Location = new System.Drawing.Point(130, 192);
            this.labellingua2parte.Name = "labellingua2parte";
            this.labellingua2parte.Size = new System.Drawing.Size(85, 22);
            this.labellingua2parte.TabIndex = 20;
            this.labellingua2parte.Text = "Espanhol";
            this.labellingua2parte.Click += new System.EventHandler(this.labellingua2parte_Click);
            // 
            // labelarea2parte
            // 
            this.labelarea2parte.AutoSize = true;
            this.labelarea2parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelarea2parte.Location = new System.Drawing.Point(131, 520);
            this.labelarea2parte.Name = "labelarea2parte";
            this.labelarea2parte.Size = new System.Drawing.Size(131, 22);
            this.labelarea2parte.TabIndex = 22;
            this.labelarea2parte.Text = "Nivel desejável";
            this.labelarea2parte.Click += new System.EventHandler(this.labelarea2parte_Click);
            // 
            // nivelaceitavel
            // 
            this.nivelaceitavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nivelaceitavel.FormattingEnabled = true;
            this.nivelaceitavel.ItemHeight = 18;
            this.nivelaceitavel.Location = new System.Drawing.Point(135, 544);
            this.nivelaceitavel.Margin = new System.Windows.Forms.Padding(2);
            this.nivelaceitavel.Name = "nivelaceitavel";
            this.nivelaceitavel.Size = new System.Drawing.Size(545, 26);
            this.nivelaceitavel.TabIndex = 21;
            this.nivelaceitavel.Text = "Coloque o nível aceitável ... (0 a 10)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(131, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Francês";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(135, 281);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(545, 26);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Coloque o nível aceitável ... (0 a 10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(130, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Italiano";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 18;
            this.comboBox2.Location = new System.Drawing.Point(134, 349);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(545, 26);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(130, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Alemão";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 18;
            this.comboBox3.Location = new System.Drawing.Point(134, 415);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(545, 26);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(546, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Salvar Configurações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // debugPID
            // 
            this.debugPID.AutoSize = true;
            this.debugPID.Location = new System.Drawing.Point(26, 415);
            this.debugPID.Name = "debugPID";
            this.debugPID.Size = new System.Drawing.Size(35, 13);
            this.debugPID.TabIndex = 31;
            this.debugPID.Text = "label5";
            // 
            // CriteriosDesejEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.debugPID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelarea2parte);
            this.Controls.Add(this.nivelaceitavel);
            this.Controls.Add(this.labellingua2parte);
            this.Controls.Add(this.nivelaceitavellingua);
            this.Controls.Add(this.areadeespecializacao);
            this.Controls.Add(this.labelareaespecializa);
            this.Controls.Add(this.linguas);
            this.Controls.Add(this.labelcomunicacaoling);
            this.Controls.Add(this.autonomia);
            this.Controls.Add(this.labelautonomia);
            this.Controls.Add(this.label1);
            this.Name = "CriteriosDesejEdit";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CriteriosDesej_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelautonomia;
        private System.Windows.Forms.Label labelcomunicacaoling;
        private System.Windows.Forms.ComboBox linguas;
        private System.Windows.Forms.Label labelareaespecializa;
        private System.Windows.Forms.ComboBox areadeespecializacao;
        private System.Windows.Forms.ComboBox nivelaceitavellingua;
        private System.Windows.Forms.Label labellingua2parte;
        private System.Windows.Forms.Label labelarea2parte;
        private System.Windows.Forms.ComboBox nivelaceitavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox autonomia;
        private System.Windows.Forms.Label debugPID;
    }
}