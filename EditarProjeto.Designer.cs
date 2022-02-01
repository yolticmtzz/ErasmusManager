namespace EramusManager
{
    partial class EditarProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProjeto));
            this.label1 = new System.Windows.Forms.Label();
            this.criarprojetobtt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statustext = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newname = new System.Windows.Forms.TextBox();
            this.comboNomeProjeto = new System.Windows.Forms.ComboBox();
            this.comboparterns = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelstatus = new System.Windows.Forms.Panel();
            this.textstatus = new System.Windows.Forms.Label();
            this.finishedpanel = new System.Windows.Forms.Panel();
            this.finishedtext = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finishcheck = new System.Windows.Forms.CheckBox();
            this.boxDebugPID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelstatus.SuspendLayout();
            this.finishedpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.criarprojetobtt.Location = new System.Drawing.Point(325, 440);
            this.criarprojetobtt.Margin = new System.Windows.Forms.Padding(2);
            this.criarprojetobtt.Name = "criarprojetobtt";
            this.criarprojetobtt.Size = new System.Drawing.Size(277, 29);
            this.criarprojetobtt.TabIndex = 15;
            this.criarprojetobtt.Text = "Edit Project";
            this.criarprojetobtt.UseVisualStyleBackColor = false;
            this.criarprojetobtt.Click += new System.EventHandler(this.criarprojetobtt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(321, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Project Partners";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(321, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statustext
            // 
            this.statustext.AutoSize = true;
            this.statustext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.statustext.Location = new System.Drawing.Point(322, 258);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(122, 22);
            this.statustext.TabIndex = 16;
            this.statustext.Text = "Project Status";
            this.statustext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statustext.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(322, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Change Project Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newname
            // 
            this.newname.Location = new System.Drawing.Point(325, 136);
            this.newname.Multiline = true;
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(278, 26);
            this.newname.TabIndex = 23;
            this.newname.TextChanged += new System.EventHandler(this.newname_TextChanged);
            // 
            // comboNomeProjeto
            // 
            this.comboNomeProjeto.FormattingEnabled = true;
            this.comboNomeProjeto.ItemHeight = 13;
            this.comboNomeProjeto.Location = new System.Drawing.Point(326, 83);
            this.comboNomeProjeto.Margin = new System.Windows.Forms.Padding(2);
            this.comboNomeProjeto.Name = "comboNomeProjeto";
            this.comboNomeProjeto.Size = new System.Drawing.Size(277, 21);
            this.comboNomeProjeto.TabIndex = 24;
            this.comboNomeProjeto.Text = "Search ...";
            this.comboNomeProjeto.SelectedIndexChanged += new System.EventHandler(this.comboNomeProjeto_SelectedIndexChanged);
            // 
            // comboparterns
            // 
            this.comboparterns.FormattingEnabled = true;
            this.comboparterns.ItemHeight = 13;
            this.comboparterns.Location = new System.Drawing.Point(325, 200);
            this.comboparterns.Margin = new System.Windows.Forms.Padding(2);
            this.comboparterns.Name = "comboparterns";
            this.comboparterns.Size = new System.Drawing.Size(277, 21);
            this.comboparterns.TabIndex = 25;
            this.comboparterns.Text = "Search ...";
            this.comboparterns.SelectedIndexChanged += new System.EventHandler(this.comboparterns_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelstatus
            // 
            this.panelstatus.BackColor = System.Drawing.Color.Green;
            this.panelstatus.Controls.Add(this.textstatus);
            this.panelstatus.Location = new System.Drawing.Point(327, 306);
            this.panelstatus.Name = "panelstatus";
            this.panelstatus.Size = new System.Drawing.Size(277, 51);
            this.panelstatus.TabIndex = 27;
            // 
            // textstatus
            // 
            this.textstatus.AutoSize = true;
            this.textstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textstatus.Location = new System.Drawing.Point(92, 14);
            this.textstatus.Name = "textstatus";
            this.textstatus.Size = new System.Drawing.Size(101, 22);
            this.textstatus.TabIndex = 28;
            this.textstatus.Text = "In Progress";
            this.textstatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finishedpanel
            // 
            this.finishedpanel.BackColor = System.Drawing.Color.Red;
            this.finishedpanel.Controls.Add(this.finishedtext);
            this.finishedpanel.Location = new System.Drawing.Point(327, 303);
            this.finishedpanel.Name = "finishedpanel";
            this.finishedpanel.Size = new System.Drawing.Size(277, 51);
            this.finishedpanel.TabIndex = 29;
            // 
            // finishedtext
            // 
            this.finishedtext.AutoSize = true;
            this.finishedtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.finishedtext.Location = new System.Drawing.Point(92, 14);
            this.finishedtext.Name = "finishedtext";
            this.finishedtext.Size = new System.Drawing.Size(78, 22);
            this.finishedtext.TabIndex = 28;
            this.finishedtext.Text = "Finished";
            this.finishedtext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(323, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Finish Project ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finishcheck
            // 
            this.finishcheck.AutoSize = true;
            this.finishcheck.Location = new System.Drawing.Point(453, 382);
            this.finishcheck.Name = "finishcheck";
            this.finishcheck.Size = new System.Drawing.Size(15, 14);
            this.finishcheck.TabIndex = 29;
            this.finishcheck.UseVisualStyleBackColor = true;
            // 
            // boxDebugPID
            // 
            this.boxDebugPID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boxDebugPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxDebugPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDebugPID.Location = new System.Drawing.Point(23, 365);
            this.boxDebugPID.Multiline = true;
            this.boxDebugPID.Name = "boxDebugPID";
            this.boxDebugPID.ReadOnly = true;
            this.boxDebugPID.Size = new System.Drawing.Size(276, 31);
            this.boxDebugPID.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            // 
            // EditarProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 490);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxDebugPID);
            this.Controls.Add(this.finishedpanel);
            this.Controls.Add(this.finishcheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelstatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboparterns);
            this.Controls.Add(this.comboNomeProjeto);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.criarprojetobtt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarProjeto";
            this.Text = "Erasmus Manager - Edit Project";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelstatus.ResumeLayout(false);
            this.panelstatus.PerformLayout();
            this.finishedpanel.ResumeLayout(false);
            this.finishedpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button criarprojetobtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statustext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.ComboBox comboNomeProjeto;
        private System.Windows.Forms.ComboBox comboparterns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelstatus;
        private System.Windows.Forms.Label textstatus;
        private System.Windows.Forms.Panel finishedpanel;
        private System.Windows.Forms.Label finishedtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox finishcheck;
        private System.Windows.Forms.TextBox boxDebugPID;
        private System.Windows.Forms.Label label6;
    }
}