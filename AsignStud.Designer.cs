
namespace EramusManager
{
    partial class AsignStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignStud));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboStudentName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProjectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.criarprojetobtt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.debugPID = new System.Windows.Forms.TextBox();
            this.boxDebugSID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Assign Students";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboStudentName
            // 
            this.comboStudentName.FormattingEnabled = true;
            this.comboStudentName.ItemHeight = 13;
            this.comboStudentName.Location = new System.Drawing.Point(301, 89);
            this.comboStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.comboStudentName.Name = "comboStudentName";
            this.comboStudentName.Size = new System.Drawing.Size(277, 21);
            this.comboStudentName.TabIndex = 29;
            this.comboStudentName.Text = "Search ...";
            this.comboStudentName.SelectedIndexChanged += new System.EventHandler(this.comboNomeProjeto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(296, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Student Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboProjectName
            // 
            this.comboProjectName.FormattingEnabled = true;
            this.comboProjectName.ItemHeight = 13;
            this.comboProjectName.Location = new System.Drawing.Point(302, 188);
            this.comboProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.comboProjectName.Name = "comboProjectName";
            this.comboProjectName.Size = new System.Drawing.Size(277, 21);
            this.comboProjectName.TabIndex = 31;
            this.comboProjectName.Text = "Search ...";
            this.comboProjectName.SelectedIndexChanged += new System.EventHandler(this.comboProjectName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(297, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Project Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(300, 115);
            this.studentName.Multiline = true;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Size = new System.Drawing.Size(278, 26);
            this.studentName.TabIndex = 33;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(300, 214);
            this.ProjectName.Multiline = true;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Size = new System.Drawing.Size(278, 26);
            this.ProjectName.TabIndex = 34;
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
            this.criarprojetobtt.Location = new System.Drawing.Point(302, 380);
            this.criarprojetobtt.Margin = new System.Windows.Forms.Padding(2);
            this.criarprojetobtt.Name = "criarprojetobtt";
            this.criarprojetobtt.Size = new System.Drawing.Size(277, 29);
            this.criarprojetobtt.TabIndex = 35;
            this.criarprojetobtt.Text = "Assign";
            this.criarprojetobtt.UseVisualStyleBackColor = false;
            this.criarprojetobtt.Click += new System.EventHandler(this.criarprojetobtt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(394, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Project ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // debugPID
            // 
            this.debugPID.Location = new System.Drawing.Point(302, 281);
            this.debugPID.Multiline = true;
            this.debugPID.Name = "debugPID";
            this.debugPID.ReadOnly = true;
            this.debugPID.Size = new System.Drawing.Size(278, 26);
            this.debugPID.TabIndex = 37;
            this.debugPID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxDebugSID
            // 
            this.boxDebugSID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boxDebugSID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxDebugSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDebugSID.Location = new System.Drawing.Point(304, 331);
            this.boxDebugSID.Multiline = true;
            this.boxDebugSID.Name = "boxDebugSID";
            this.boxDebugSID.ReadOnly = true;
            this.boxDebugSID.Size = new System.Drawing.Size(276, 31);
            this.boxDebugSID.TabIndex = 38;
            // 
            // AsignStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 441);
            this.Controls.Add(this.boxDebugSID);
            this.Controls.Add(this.debugPID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.criarprojetobtt);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.comboProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignStud";
            this.Text = "Erasmus Manger - Assign Students";
            this.Load += new System.EventHandler(this.AsignStud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Button criarprojetobtt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox debugPID;
        private System.Windows.Forms.TextBox boxDebugSID;
    }
}