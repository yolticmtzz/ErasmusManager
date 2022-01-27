namespace EramusManager
{
    partial class CriteriosDesej
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriteriosDesej));
            this.label1 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Critérios Desejáveis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelcomunicacaoling
            // 
            this.labelcomunicacaoling.AutoSize = true;
            this.labelcomunicacaoling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelcomunicacaoling.Location = new System.Drawing.Point(128, 44);
            this.labelcomunicacaoling.Name = "labelcomunicacaoling";
            this.labelcomunicacaoling.Size = new System.Drawing.Size(377, 22);
            this.labelcomunicacaoling.TabIndex = 12;
            this.labelcomunicacaoling.Text = "Quais línguas são importantes para o projeto?";
            this.labelcomunicacaoling.Click += new System.EventHandler(this.labelcomunicacaoling_Click);
            // 
            // linguas
            // 
            this.linguas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linguas.FormattingEnabled = true;
            this.linguas.ItemHeight = 18;
            this.linguas.Items.AddRange(new object[] {
            "Inglês",
            "Espanhol",
            "Italiano",
            "Francês",
            "Alemão"});
            this.linguas.Location = new System.Drawing.Point(132, 68);
            this.linguas.Margin = new System.Windows.Forms.Padding(2);
            this.linguas.Name = "linguas";
            this.linguas.Size = new System.Drawing.Size(545, 26);
            this.linguas.TabIndex = 13;
            this.linguas.Text = "Escolha até três linguas...";
            this.linguas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelareaespecializa
            // 
            this.labelareaespecializa.AutoSize = true;
            this.labelareaespecializa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelareaespecializa.Location = new System.Drawing.Point(126, 108);
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
            this.areadeespecializacao.Location = new System.Drawing.Point(130, 132);
            this.areadeespecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.areadeespecializacao.Name = "areadeespecializacao";
            this.areadeespecializacao.Size = new System.Drawing.Size(545, 26);
            this.areadeespecializacao.TabIndex = 15;
            this.areadeespecializacao.Text = "Procurar área ...";
            this.areadeespecializacao.SelectedIndexChanged += new System.EventHandler(this.areadeespecializacao_SelectedIndexChanged);
            // 
            // nivelaceitavellingua
            // 
            this.nivelaceitavellingua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nivelaceitavellingua.FormattingEnabled = true;
            this.nivelaceitavellingua.ItemHeight = 18;
            this.nivelaceitavellingua.Location = new System.Drawing.Point(129, 197);
            this.nivelaceitavellingua.Margin = new System.Windows.Forms.Padding(2);
            this.nivelaceitavellingua.Name = "nivelaceitavellingua";
            this.nivelaceitavellingua.Size = new System.Drawing.Size(545, 26);
            this.nivelaceitavellingua.TabIndex = 19;
            this.nivelaceitavellingua.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.nivelaceitavellingua.Visible = false;
            this.nivelaceitavellingua.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // labellingua2parte
            // 
            this.labellingua2parte.AutoSize = true;
            this.labellingua2parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labellingua2parte.Location = new System.Drawing.Point(125, 173);
            this.labellingua2parte.Name = "labellingua2parte";
            this.labellingua2parte.Size = new System.Drawing.Size(85, 22);
            this.labellingua2parte.TabIndex = 20;
            this.labellingua2parte.Text = "Espanhol";
            this.labellingua2parte.Visible = false;
            this.labellingua2parte.Click += new System.EventHandler(this.labellingua2parte_Click);
            // 
            // labelarea2parte
            // 
            this.labelarea2parte.AutoSize = true;
            this.labelarea2parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelarea2parte.Location = new System.Drawing.Point(125, 366);
            this.labelarea2parte.Name = "labelarea2parte";
            this.labelarea2parte.Size = new System.Drawing.Size(131, 22);
            this.labelarea2parte.TabIndex = 22;
            this.labelarea2parte.Text = "Nivel desejável";
            this.labelarea2parte.Visible = false;
            this.labelarea2parte.Click += new System.EventHandler(this.labelarea2parte_Click);
            // 
            // nivelaceitavel
            // 
            this.nivelaceitavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nivelaceitavel.FormattingEnabled = true;
            this.nivelaceitavel.ItemHeight = 18;
            this.nivelaceitavel.Location = new System.Drawing.Point(129, 390);
            this.nivelaceitavel.Margin = new System.Windows.Forms.Padding(2);
            this.nivelaceitavel.Name = "nivelaceitavel";
            this.nivelaceitavel.Size = new System.Drawing.Size(545, 26);
            this.nivelaceitavel.TabIndex = 21;
            this.nivelaceitavel.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.nivelaceitavel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(126, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Francês";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 18;
            this.comboBox1.Location = new System.Drawing.Point(130, 262);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(545, 26);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.comboBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(126, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Italiano";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 18;
            this.comboBox2.Location = new System.Drawing.Point(130, 324);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(545, 26);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(546, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Salvar Configurações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(125, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nivel desejável";
            this.label4.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 18;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(129, 457);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(545, 26);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.comboBox3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(125, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nivel desejável";
            this.label5.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 18;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(129, 528);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(545, 26);
            this.comboBox4.TabIndex = 33;
            this.comboBox4.Text = "Coloque o nível aceitável ... (0 a 10)";
            this.comboBox4.Visible = false;
            // 
            // CriteriosDesej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 592);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriteriosDesej";
            this.Text = "Eramus Manager - Criterios Desej";
            this.Load += new System.EventHandler(this.CriteriosDesej_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}