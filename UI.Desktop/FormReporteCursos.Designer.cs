namespace UI.Desktop
{
    partial class FormReporteCursos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_CursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AcademiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_CursosTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.SP_CursosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_CursosBindingSource
            // 
            this.SP_CursosBindingSource.DataMember = "SP_Cursos";
            this.SP_CursosBindingSource.DataSource = this.AcademiaDataSet;
            // 
            // AcademiaDataSet
            // 
            this.AcademiaDataSet.DataSetName = "AcademiaDataSet";
            this.AcademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Cursos";
            reportDataSource1.Value = this.SP_CursosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReporteCursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_CursosTableAdapter
            // 
            this.SP_CursosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteCursos";
            this.Text = "FormReporteCursos";
            this.Load += new System.EventHandler(this.FormReporteCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_CursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademiaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_CursosBindingSource;
        private AcademiaDataSet AcademiaDataSet;
        private AcademiaDataSetTableAdapters.SP_CursosTableAdapter SP_CursosTableAdapter;
    }
}