namespace Ogrenci_Yurt_Sistemi
{
    partial class frmGider_listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGider_listesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ödemeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelGiderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderler1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet6 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet6();
            this.giderler1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet6TableAdapters.Giderler1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderler1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ödemeIdDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.personelGiderDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderler1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1178, 715);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ödemeIdDataGridViewTextBoxColumn
            // 
            this.ödemeIdDataGridViewTextBoxColumn.DataPropertyName = "ÖdemeId";
            this.ödemeIdDataGridViewTextBoxColumn.HeaderText = "ÖdemeId";
            this.ödemeIdDataGridViewTextBoxColumn.Name = "ödemeIdDataGridViewTextBoxColumn";
            this.ödemeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "İnternet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "İnternet";
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            // 
            // personelGiderDataGridViewTextBoxColumn
            // 
            this.personelGiderDataGridViewTextBoxColumn.DataPropertyName = "PersonelGider";
            this.personelGiderDataGridViewTextBoxColumn.HeaderText = "PersonelGider";
            this.personelGiderDataGridViewTextBoxColumn.Name = "personelGiderDataGridViewTextBoxColumn";
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            // 
            // giderler1BindingSource
            // 
            this.giderler1BindingSource.DataMember = "Giderler1";
            this.giderler1BindingSource.DataSource = this.yurtKayıtSistemiDataSet6;
            // 
            // yurtKayıtSistemiDataSet6
            // 
            this.yurtKayıtSistemiDataSet6.DataSetName = "YurtKayıtSistemiDataSet6";
            this.yurtKayıtSistemiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderler1TableAdapter
            // 
            this.giderler1TableAdapter.ClearBeforeFill = true;
            // 
            // frmGider_listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 715);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGider_listesi";
            this.Text = "GİDERLER LİSTESİ";
            this.Load += new System.EventHandler(this.frmGider_listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderler1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtSistemiDataSet6 yurtKayıtSistemiDataSet6;
        private System.Windows.Forms.BindingSource giderler1BindingSource;
        private YurtKayıtSistemiDataSet6TableAdapters.Giderler1TableAdapter giderler1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ödemeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelGiderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}