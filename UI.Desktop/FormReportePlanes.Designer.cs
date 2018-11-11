namespace UI.Desktop
{
    partial class FormReportePlanes
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
            this.SP_PlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AcademiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_PlanesTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.SP_PlanesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PlanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_PlanesBindingSource
            // 
            this.SP_PlanesBindingSource.DataMember = "SP_Planes";
            this.SP_PlanesBindingSource.DataSource = this.AcademiaDataSet;
            // 
            // AcademiaDataSet
            // 
            this.AcademiaDataSet.DataSetName = "AcademiaDataSet";
            this.AcademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Planes";
            reportDataSource1.Value = this.SP_PlanesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReportePlanes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_PlanesTableAdapter
            // 
            this.SP_PlanesTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportePlanes";
            this.Text = "FormReportePlanes";
            this.Load += new System.EventHandler(this.FormReportePlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_PlanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademiaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_PlanesBindingSource;
        private AcademiaDataSet AcademiaDataSet;
        private AcademiaDataSetTableAdapters.SP_PlanesTableAdapter SP_PlanesTableAdapter;
    }
}