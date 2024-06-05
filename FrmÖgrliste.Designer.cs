namespace Ogrenci_Yurt_Sistemi
{
    partial class FrmÖgrliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖgrliste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ögrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrBölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenci1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet5 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet5();
            this.ögrenci1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet5TableAdapters.Ögrenci1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenci1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ögrIdDataGridViewTextBoxColumn,
            this.ögrAdDataGridViewTextBoxColumn,
            this.ögrSoyadDataGridViewTextBoxColumn,
            this.ögrTcDataGridViewTextBoxColumn,
            this.ögrTelefonDataGridViewTextBoxColumn,
            this.ögrDogumDataGridViewTextBoxColumn,
            this.ögrBölümDataGridViewTextBoxColumn,
            this.ögrMailDataGridViewTextBoxColumn,
            this.ögrOdaNoDataGridViewTextBoxColumn,
            this.ögrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ögrVeliTelefonDataGridViewTextBoxColumn,
            this.ögrVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ögrenci1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1281, 717);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ögrIdDataGridViewTextBoxColumn
            // 
            this.ögrIdDataGridViewTextBoxColumn.DataPropertyName = "ÖgrId";
            this.ögrIdDataGridViewTextBoxColumn.HeaderText = "ÖgrId";
            this.ögrIdDataGridViewTextBoxColumn.Name = "ögrIdDataGridViewTextBoxColumn";
            this.ögrIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ögrAdDataGridViewTextBoxColumn
            // 
            this.ögrAdDataGridViewTextBoxColumn.DataPropertyName = "ÖgrAd";
            this.ögrAdDataGridViewTextBoxColumn.HeaderText = "ÖgrAd";
            this.ögrAdDataGridViewTextBoxColumn.Name = "ögrAdDataGridViewTextBoxColumn";
            // 
            // ögrSoyadDataGridViewTextBoxColumn
            // 
            this.ögrSoyadDataGridViewTextBoxColumn.DataPropertyName = "ÖgrSoyad";
            this.ögrSoyadDataGridViewTextBoxColumn.HeaderText = "ÖgrSoyad";
            this.ögrSoyadDataGridViewTextBoxColumn.Name = "ögrSoyadDataGridViewTextBoxColumn";
            // 
            // ögrTcDataGridViewTextBoxColumn
            // 
            this.ögrTcDataGridViewTextBoxColumn.DataPropertyName = "ÖgrTc";
            this.ögrTcDataGridViewTextBoxColumn.HeaderText = "ÖgrTc";
            this.ögrTcDataGridViewTextBoxColumn.Name = "ögrTcDataGridViewTextBoxColumn";
            // 
            // ögrTelefonDataGridViewTextBoxColumn
            // 
            this.ögrTelefonDataGridViewTextBoxColumn.DataPropertyName = "ÖgrTelefon";
            this.ögrTelefonDataGridViewTextBoxColumn.HeaderText = "ÖgrTelefon";
            this.ögrTelefonDataGridViewTextBoxColumn.Name = "ögrTelefonDataGridViewTextBoxColumn";
            // 
            // ögrDogumDataGridViewTextBoxColumn
            // 
            this.ögrDogumDataGridViewTextBoxColumn.DataPropertyName = "ÖgrDogum";
            this.ögrDogumDataGridViewTextBoxColumn.HeaderText = "ÖgrDogum";
            this.ögrDogumDataGridViewTextBoxColumn.Name = "ögrDogumDataGridViewTextBoxColumn";
            // 
            // ögrBölümDataGridViewTextBoxColumn
            // 
            this.ögrBölümDataGridViewTextBoxColumn.DataPropertyName = "ÖgrBölüm";
            this.ögrBölümDataGridViewTextBoxColumn.HeaderText = "ÖgrBölüm";
            this.ögrBölümDataGridViewTextBoxColumn.Name = "ögrBölümDataGridViewTextBoxColumn";
            // 
            // ögrMailDataGridViewTextBoxColumn
            // 
            this.ögrMailDataGridViewTextBoxColumn.DataPropertyName = "ÖgrMail";
            this.ögrMailDataGridViewTextBoxColumn.HeaderText = "ÖgrMail";
            this.ögrMailDataGridViewTextBoxColumn.Name = "ögrMailDataGridViewTextBoxColumn";
            // 
            // ögrOdaNoDataGridViewTextBoxColumn
            // 
            this.ögrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "ÖgrOdaNo";
            this.ögrOdaNoDataGridViewTextBoxColumn.HeaderText = "ÖgrOdaNo";
            this.ögrOdaNoDataGridViewTextBoxColumn.Name = "ögrOdaNoDataGridViewTextBoxColumn";
            // 
            // ögrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ögrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "ÖgrVeliAdSoyad";
            this.ögrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "ÖgrVeliAdSoyad";
            this.ögrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ögrVeliAdSoyadDataGridViewTextBoxColumn";
            // 
            // ögrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ögrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "ÖgrVeliTelefon";
            this.ögrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "ÖgrVeliTelefon";
            this.ögrVeliTelefonDataGridViewTextBoxColumn.Name = "ögrVeliTelefonDataGridViewTextBoxColumn";
            // 
            // ögrVeliAdresDataGridViewTextBoxColumn
            // 
            this.ögrVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "ÖgrVeliAdres";
            this.ögrVeliAdresDataGridViewTextBoxColumn.HeaderText = "ÖgrVeliAdres";
            this.ögrVeliAdresDataGridViewTextBoxColumn.Name = "ögrVeliAdresDataGridViewTextBoxColumn";
            // 
            // ögrenci1BindingSource
            // 
            this.ögrenci1BindingSource.DataMember = "Ögrenci1";
            this.ögrenci1BindingSource.DataSource = this.yurtKayıtSistemiDataSet5;
            // 
            // yurtKayıtSistemiDataSet5
            // 
            this.yurtKayıtSistemiDataSet5.DataSetName = "YurtKayıtSistemiDataSet5";
            this.yurtKayıtSistemiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ögrenci1TableAdapter
            // 
            this.ögrenci1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmÖgrliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1281, 717);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmÖgrliste";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖGRENCİLER LİSTESİ";
            this.Load += new System.EventHandler(this.FrmÖgrliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenci1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtSistemiDataSet5 yurtKayıtSistemiDataSet5;
        private System.Windows.Forms.BindingSource ögrenci1BindingSource;
        private YurtKayıtSistemiDataSet5TableAdapters.Ögrenci1TableAdapter ögrenci1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrBölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrVeliAdresDataGridViewTextBoxColumn;
    }
}