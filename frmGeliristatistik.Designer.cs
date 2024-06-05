namespace Ogrenci_Yurt_Sistemi
{
    partial class frmGeliristatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeliristatistik));
            this.label1 = new System.Windows.Forms.Label();
            this.labelpara = new System.Windows.Forms.Label();
            this.labelSçlnaymktr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbsçlnay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(430, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KASADAKİ PARA MİKTARI:";
            // 
            // labelpara
            // 
            this.labelpara.AutoSize = true;
            this.labelpara.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelpara.Location = new System.Drawing.Point(638, 25);
            this.labelpara.Name = "labelpara";
            this.labelpara.Size = new System.Drawing.Size(13, 20);
            this.labelpara.TabIndex = 1;
            this.labelpara.Text = ".";
            // 
            // labelSçlnaymktr
            // 
            this.labelSçlnaymktr.AutoSize = true;
            this.labelSçlnaymktr.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSçlnaymktr.Location = new System.Drawing.Point(638, 84);
            this.labelSçlnaymktr.Name = "labelSçlnaymktr";
            this.labelSçlnaymktr.Size = new System.Drawing.Size(13, 20);
            this.labelSçlnaymktr.TabIndex = 3;
            this.labelSçlnaymktr.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(525, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEÇİLEN AY:\r\n";
            // 
            // cmbsçlnay
            // 
            this.cmbsçlnay.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsçlnay.FormattingEnabled = true;
            this.cmbsçlnay.Location = new System.Drawing.Point(172, 27);
            this.cmbsçlnay.Name = "cmbsçlnay";
            this.cmbsçlnay.Size = new System.Drawing.Size(174, 26);
            this.cmbsçlnay.TabIndex = 4;
            this.cmbsçlnay.SelectedIndexChanged += new System.EventHandler(this.cmbsçlnay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "AY SEÇİNİZ:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "AYLIK";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(30, 132);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "AYLIK";
            series1.Name = "AYLIK";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(666, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // frmGeliristatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(725, 444);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbsçlnay);
            this.Controls.Add(this.labelSçlnaymktr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelpara);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGeliristatistik";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GELİR İSTATİSTİKLERİ";
            this.Load += new System.EventHandler(this.frmGeliristatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpara;
        private System.Windows.Forms.Label labelSçlnaymktr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsçlnay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}