namespace EramusManager
{
    partial class Gestaoequipa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestaoequipa));
            this.label1 = new System.Windows.Forms.Label();
            this.comboprojectos = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.criarprojetobtt = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.debugPID = new System.Windows.Forms.TextBox();
            this.listanomes = new System.Windows.Forms.ListBox();
            this.debug2 = new System.Windows.Forms.TextBox();
            this.listatrib1 = new System.Windows.Forms.ListBox();
            this.listatrib2 = new System.Windows.Forms.ListBox();
            this.listatrib3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Erasmus Manager";
            // 
            // comboprojectos
            // 
            this.comboprojectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboprojectos.FormattingEnabled = true;
            this.comboprojectos.ItemHeight = 18;
            this.comboprojectos.Location = new System.Drawing.Point(82, 92);
            this.comboprojectos.Margin = new System.Windows.Forms.Padding(2);
            this.comboprojectos.Name = "comboprojectos";
            this.comboprojectos.Size = new System.Drawing.Size(625, 26);
            this.comboprojectos.TabIndex = 10;
            this.comboprojectos.Text = "Procurar Projeto ...";
            this.comboprojectos.SelectedIndexChanged += new System.EventHandler(this.comboprojectos_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox4.Location = new System.Drawing.Point(517, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 24);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Atributo 3";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(82, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 24);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Nome";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(227, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 24);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Atributo 1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(372, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 24);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Atributo 2";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.Location = new System.Drawing.Point(82, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 27);
            this.button5.TabIndex = 39;
            this.button5.Text = "Adicionar parceiros";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.Location = new System.Drawing.Point(372, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 27);
            this.button6.TabIndex = 40;
            this.button6.Text = "Importar estudantes";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // criarprojetobtt
            // 
            this.criarprojetobtt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.criarprojetobtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.criarprojetobtt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.criarprojetobtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.criarprojetobtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.criarprojetobtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.criarprojetobtt.ForeColor = System.Drawing.Color.White;
            this.criarprojetobtt.Location = new System.Drawing.Point(82, 395);
            this.criarprojetobtt.Margin = new System.Windows.Forms.Padding(2);
            this.criarprojetobtt.Name = "criarprojetobtt";
            this.criarprojetobtt.Size = new System.Drawing.Size(625, 29);
            this.criarprojetobtt.TabIndex = 41;
            this.criarprojetobtt.Text = "Iniciar Simulação";
            this.criarprojetobtt.UseVisualStyleBackColor = false;
            this.criarprojetobtt.Click += new System.EventHandler(this.criarprojetobtt_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(723, 178);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 114);
            this.vScrollBar1.TabIndex = 42;
            // 
            // debugPID
            // 
            this.debugPID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.debugPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugPID.Location = new System.Drawing.Point(66, 34);
            this.debugPID.Multiline = true;
            this.debugPID.Name = "debugPID";
            this.debugPID.ReadOnly = true;
            this.debugPID.Size = new System.Drawing.Size(92, 31);
            this.debugPID.TabIndex = 43;
            // 
            // listanomes
            // 
            this.listanomes.FormattingEnabled = true;
            this.listanomes.Location = new System.Drawing.Point(82, 168);
            this.listanomes.Name = "listanomes";
            this.listanomes.Size = new System.Drawing.Size(139, 160);
            this.listanomes.TabIndex = 44;
            // 
            // debug2
            // 
            this.debug2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.debug2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug2.Location = new System.Drawing.Point(606, 41);
            this.debug2.Multiline = true;
            this.debug2.Name = "debug2";
            this.debug2.ReadOnly = true;
            this.debug2.Size = new System.Drawing.Size(92, 31);
            this.debug2.TabIndex = 45;
            // 
            // listatrib1
            // 
            this.listatrib1.FormattingEnabled = true;
            this.listatrib1.Location = new System.Drawing.Point(227, 168);
            this.listatrib1.Name = "listatrib1";
            this.listatrib1.Size = new System.Drawing.Size(139, 160);
            this.listatrib1.TabIndex = 46;
            // 
            // listatrib2
            // 
            this.listatrib2.FormattingEnabled = true;
            this.listatrib2.Location = new System.Drawing.Point(372, 168);
            this.listatrib2.Name = "listatrib2";
            this.listatrib2.Size = new System.Drawing.Size(139, 160);
            this.listatrib2.TabIndex = 47;
            // 
            // listatrib3
            // 
            this.listatrib3.FormattingEnabled = true;
            this.listatrib3.Location = new System.Drawing.Point(517, 168);
            this.listatrib3.Name = "listatrib3";
            this.listatrib3.Size = new System.Drawing.Size(139, 160);
            this.listatrib3.TabIndex = 48;
            // 
            // Gestaoequipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.listatrib3);
            this.Controls.Add(this.listatrib2);
            this.Controls.Add(this.listatrib1);
            this.Controls.Add(this.debug2);
            this.Controls.Add(this.listanomes);
            this.Controls.Add(this.debugPID);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.criarprojetobtt);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboprojectos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestaoequipa";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Gestaoequipa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboprojectos;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button criarprojetobtt;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox debugPID;
        private System.Windows.Forms.ListBox listanomes;
        private System.Windows.Forms.TextBox debug2;
        private System.Windows.Forms.ListBox listatrib1;
        private System.Windows.Forms.ListBox listatrib2;
        private System.Windows.Forms.ListBox listatrib3;
    }
}