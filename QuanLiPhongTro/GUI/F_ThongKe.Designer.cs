﻿namespace GUI
{
    partial class F_ThongKe
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
            this.HoaDon_DTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon_DTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDon_DTOBindingSource
            // 
            this.HoaDon_DTOBindingSource.DataSource = typeof(DTO.HoaDon_DTO);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 98;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDon_DTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(723, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // F_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "F_ThongKe";
            this.Text = "F_ThongKe";
            this.Load += new System.EventHandler(this.F_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon_DTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDon_DTOBindingSource;
    }
}