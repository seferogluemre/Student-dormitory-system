namespace Ogrenci_Yurt_Sistemi
{
    partial class frmÖgrenciRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÖgrenciRapor));
            this.ögrenci1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet10 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet10();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ögrenci1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet10TableAdapters.Ögrenci1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenci1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // ögrenci1BindingSource
            // 
            this.ögrenci1BindingSource.DataMember = "Ögrenci1";
            this.ögrenci1BindingSource.DataSource = this.yurtKayıtSistemiDataSet10;
            // 
            // yurtKayıtSistemiDataSet10
            // 
            this.yurtKayıtSistemiDataSet10.DataSetName = "YurtKayıtSistemiDataSet10";
            this.yurtKayıtSistemiDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ögrenci1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ogrenci_Yurt_Sistemi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(1072, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // ögrenci1TableAdapter
            // 
            this.ögrenci1TableAdapter.ClearBeforeFill = true;
            // 
            // frmÖgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 507);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "frmÖgrenciRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖGRENCİ RAPOR";
            this.Load += new System.EventHandler(this.frmÖgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ögrenci1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private YurtKayıtSistemiDataSet10 yurtKayıtSistemiDataSet10;
        private System.Windows.Forms.BindingSource ögrenci1BindingSource;
        private YurtKayıtSistemiDataSet10TableAdapters.Ögrenci1TableAdapter ögrenci1TableAdapter;
    }
}