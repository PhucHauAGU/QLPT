namespace GUI
{
    partial class F_RKhu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLPTDataSet = new GUI.QLPTDataSet();
            this.KHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHUTableAdapter = new GUI.QLPTDataSetTableAdapters.KHUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KHUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLPTDataSet
            // 
            this.QLPTDataSet.DataSetName = "QLPTDataSet";
            this.QLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHUBindingSource
            // 
            this.KHUBindingSource.DataMember = "KHU";
            this.KHUBindingSource.DataSource = this.QLPTDataSet;
            // 
            // KHUTableAdapter
            // 
            this.KHUTableAdapter.ClearBeforeFill = true;
            // 
            // F_RKhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "F_RKhu";
            this.Text = "F_RKhu";
            this.Load += new System.EventHandler(this.F_RKhu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHUBindingSource;
        private QLPTDataSet QLPTDataSet;
        private QLPTDataSetTableAdapters.KHUTableAdapter KHUTableAdapter;
    }
}