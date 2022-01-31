
namespace EramusManager
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studpanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.projetospanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.butviewp = new System.Windows.Forms.Button();
            this.btnnp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChildPannel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.studpanel.SuspendLayout();
            this.projetospanel.SuspendLayout();
            this.ChildPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 18;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.studpanel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.projetospanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 580);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // studpanel
            // 
            this.studpanel.Controls.Add(this.button5);
            this.studpanel.Controls.Add(this.button4);
            this.studpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studpanel.Location = new System.Drawing.Point(0, 306);
            this.studpanel.Name = "studpanel";
            this.studpanel.Size = new System.Drawing.Size(195, 84);
            this.studpanel.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "Assign Students";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Import Students";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(178)))), ((int)(((byte)(86)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(0, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Students";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // projetospanel
            // 
            this.projetospanel.BackColor = System.Drawing.Color.Gray;
            this.projetospanel.Controls.Add(this.button2);
            this.projetospanel.Controls.Add(this.butviewp);
            this.projetospanel.Controls.Add(this.btnnp);
            this.projetospanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projetospanel.Location = new System.Drawing.Point(0, 141);
            this.projetospanel.Name = "projetospanel";
            this.projetospanel.Size = new System.Drawing.Size(195, 124);
            this.projetospanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Project";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butviewp
            // 
            this.butviewp.BackColor = System.Drawing.Color.White;
            this.butviewp.Dock = System.Windows.Forms.DockStyle.Top;
            this.butviewp.FlatAppearance.BorderSize = 0;
            this.butviewp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butviewp.ForeColor = System.Drawing.Color.Black;
            this.butviewp.Location = new System.Drawing.Point(0, 37);
            this.butviewp.Name = "butviewp";
            this.butviewp.Size = new System.Drawing.Size(195, 39);
            this.butviewp.TabIndex = 1;
            this.butviewp.Text = "View Projects";
            this.butviewp.UseVisualStyleBackColor = false;
            this.butviewp.Click += new System.EventHandler(this.butviewp_Click);
            // 
            // btnnp
            // 
            this.btnnp.BackColor = System.Drawing.Color.White;
            this.btnnp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnp.FlatAppearance.BorderSize = 0;
            this.btnnp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnp.ForeColor = System.Drawing.Color.Black;
            this.btnnp.Location = new System.Drawing.Point(0, 0);
            this.btnnp.Name = "btnnp";
            this.btnnp.Size = new System.Drawing.Size(195, 37);
            this.btnnp.TabIndex = 0;
            this.btnnp.Text = "New Project";
            this.btnnp.UseVisualStyleBackColor = false;
            this.btnnp.Click += new System.EventHandler(this.btnnp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(178)))), ((int)(((byte)(86)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Projects";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ChildPannel
            // 
            this.ChildPannel.BackColor = System.Drawing.Color.SkyBlue;
            this.ChildPannel.Controls.Add(this.pictureBox1);
            this.ChildPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPannel.Location = new System.Drawing.Point(195, 0);
            this.ChildPannel.Name = "ChildPannel";
            this.ChildPannel.Size = new System.Drawing.Size(945, 580);
            this.ChildPannel.TabIndex = 21;
            this.ChildPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildPannel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(178)))), ((int)(((byte)(86)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(0, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "Manage Team";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 580);
            this.Controls.Add(this.ChildPannel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Text = "Eramus Manager - Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            this.studpanel.ResumeLayout(false);
            this.projetospanel.ResumeLayout(false);
            this.ChildPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel projetospanel;
        private System.Windows.Forms.Button butviewp;
        private System.Windows.Forms.Button btnnp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ChildPannel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel studpanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}