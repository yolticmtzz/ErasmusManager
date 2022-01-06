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
            this.label1 = new System.Windows.Forms.Label();
            this.labelautonomia = new System.Windows.Forms.Label();
            this.autonomia = new System.Windows.Forms.ComboBox();
            this.labelcomunicacaoling = new System.Windows.Forms.Label();
            this.linguas = new System.Windows.Forms.ComboBox();
            this.labelareaespecializa = new System.Windows.Forms.Label();
            this.areadeespecializacao = new System.Windows.Forms.ComboBox();
            this.scrollautonomia = new System.Windows.Forms.VScrollBar();
            this.scrollbarareaespecializacao = new System.Windows.Forms.VScrollBar();
            this.scrollpaginainteira = new System.Windows.Forms.VScrollBar();
            this.nivelaceitavellingua = new System.Windows.Forms.ComboBox();
            this.labellingua2parte = new System.Windows.Forms.Label();
            this.labelarea2parte = new System.Windows.Forms.Label();
            this.nivelaceitavel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 30);
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
            this.autonomia.Text = "Sim";
            this.autonomia.SelectedIndexChanged += new System.EventHandler(this.comboparceiros_SelectedIndexChanged_1);
            // 
            // labelcomunicacaoling
            // 
            this.labelcomunicacaoling.AutoSize = true;
            this.labelcomunicacaoling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelcomunicacaoling.Location = new System.Drawing.Point(131, 127);
            this.labelcomunicacaoling.Name = "labelcomunicacaoling";
            this.labelcomunicacaoling.Size = new System.Drawing.Size(203, 22);
            this.labelcomunicacaoling.TabIndex = 12;
            this.labelcomunicacaoling.Text = "Comunicação linguística";
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
            this.linguas.Text = "Procurar línguas ...";
            this.linguas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelareaespecializa
            // 
            this.labelareaespecializa.AutoSize = true;
            this.labelareaespecializa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelareaespecializa.Location = new System.Drawing.Point(130, 258);
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
            this.areadeespecializacao.Location = new System.Drawing.Point(134, 282);
            this.areadeespecializacao.Margin = new System.Windows.Forms.Padding(2);
            this.areadeespecializacao.Name = "areadeespecializacao";
            this.areadeespecializacao.Size = new System.Drawing.Size(545, 26);
            this.areadeespecializacao.TabIndex = 15;
            this.areadeespecializacao.Text = "Procurar área ...";
            // 
            // scrollautonomia
            // 
            this.scrollautonomia.Location = new System.Drawing.Point(682, 151);
            this.scrollautonomia.Name = "scrollautonomia";
            this.scrollautonomia.Size = new System.Drawing.Size(23, 63);
            this.scrollautonomia.TabIndex = 16;
            // 
            // scrollbarareaespecializacao
            // 
            this.scrollbarareaespecializacao.Location = new System.Drawing.Point(681, 282);
            this.scrollbarareaespecializacao.Name = "scrollbarareaespecializacao";
            this.scrollbarareaespecializacao.Size = new System.Drawing.Size(23, 63);
            this.scrollbarareaespecializacao.TabIndex = 17;
            // 
            // scrollpaginainteira
            // 
            this.scrollpaginainteira.Location = new System.Drawing.Point(705, 89);
            this.scrollpaginainteira.Name = "scrollpaginainteira";
            this.scrollpaginainteira.Size = new System.Drawing.Size(23, 338);
            this.scrollpaginainteira.TabIndex = 18;
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
            this.labellingua2parte.Size = new System.Drawing.Size(80, 22);
            this.labellingua2parte.TabIndex = 20;
            this.labellingua2parte.Text = "1º língua";
            // 
            // labelarea2parte
            // 
            this.labelarea2parte.AutoSize = true;
            this.labelarea2parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelarea2parte.Location = new System.Drawing.Point(130, 323);
            this.labelarea2parte.Name = "labelarea2parte";
            this.labelarea2parte.Size = new System.Drawing.Size(68, 22);
            this.labelarea2parte.TabIndex = 22;
            this.labelarea2parte.Text = "1º área";
            // 
            // nivelaceitavel
            // 
            this.nivelaceitavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nivelaceitavel.FormattingEnabled = true;
            this.nivelaceitavel.ItemHeight = 18;
            this.nivelaceitavel.Location = new System.Drawing.Point(134, 347);
            this.nivelaceitavel.Margin = new System.Windows.Forms.Padding(2);
            this.nivelaceitavel.Name = "nivelaceitavel";
            this.nivelaceitavel.Size = new System.Drawing.Size(545, 26);
            this.nivelaceitavel.TabIndex = 21;
            this.nivelaceitavel.Text = "Coloque o nível aceitável ... (0 a 10)";
            // 
            // CriteriosDesej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelarea2parte);
            this.Controls.Add(this.nivelaceitavel);
            this.Controls.Add(this.labellingua2parte);
            this.Controls.Add(this.nivelaceitavellingua);
            this.Controls.Add(this.scrollpaginainteira);
            this.Controls.Add(this.scrollbarareaespecializacao);
            this.Controls.Add(this.scrollautonomia);
            this.Controls.Add(this.areadeespecializacao);
            this.Controls.Add(this.labelareaespecializa);
            this.Controls.Add(this.linguas);
            this.Controls.Add(this.labelcomunicacaoling);
            this.Controls.Add(this.autonomia);
            this.Controls.Add(this.labelautonomia);
            this.Controls.Add(this.label1);
            this.Name = "CriteriosDesej";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelautonomia;
        private System.Windows.Forms.ComboBox autonomia;
        private System.Windows.Forms.Label labelcomunicacaoling;
        private System.Windows.Forms.ComboBox linguas;
        private System.Windows.Forms.Label labelareaespecializa;
        private System.Windows.Forms.ComboBox areadeespecializacao;
        private System.Windows.Forms.VScrollBar scrollautonomia;
        private System.Windows.Forms.VScrollBar scrollbarareaespecializacao;
        private System.Windows.Forms.VScrollBar scrollpaginainteira;
        private System.Windows.Forms.ComboBox nivelaceitavellingua;
        private System.Windows.Forms.Label labellingua2parte;
        private System.Windows.Forms.Label labelarea2parte;
        private System.Windows.Forms.ComboBox nivelaceitavel;
    }
}