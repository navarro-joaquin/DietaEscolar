﻿namespace DietaEscolar
{
    partial class FrmReporteNivelAlternativa
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
            this.consultasDataSet = new DietaEscolar.consultasDataSet();
            this.BusquedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Consulta";
            reportDataSource1.Value = this.BusquedaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DietaEscolar.ReporteNivelAlternativa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // consultasDataSet
            // 
            this.consultasDataSet.DataSetName = "consultasDataSet";
            this.consultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BusquedaBindingSource
            // 
            this.BusquedaBindingSource.DataMember = "Busqueda";
            this.BusquedaBindingSource.DataSource = this.consultasDataSet;
            // 
            // FrmReporteNivelAlternativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 372);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteNivelAlternativa";
            this.Text = ".::. Reporte de Stock en Nivel Alternativa y Convenio .::.";
            this.Load += new System.EventHandler(this.FrmReporteNivelAlternativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusquedaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BusquedaBindingSource;
        private consultasDataSet consultasDataSet;
    }
}