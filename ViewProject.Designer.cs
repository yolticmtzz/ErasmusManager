
namespace EramusManager
{
    partial class ViewProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.eramusmanagerdbDataSet = new EramusManager.eramusmanagerdbDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new EramusManager.eramusmanagerdbDataSetTableAdapters.ProjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eramusmanagerdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projetos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eramusmanagerdbDataSet
            // 
            this.eramusmanagerdbDataSet.DataSetName = "eramusmanagerdbDataSet";
            this.eramusmanagerdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.eramusmanagerdbDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 516);
            this.Controls.Add(this.label1);
            this.Name = "ViewProject";
            this.Text = "ViewProject";
            this.Load += new System.EventHandler(this.ViewProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eramusmanagerdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private eramusmanagerdbDataSet eramusmanagerdbDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private eramusmanagerdbDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
    }
}