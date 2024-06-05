namespace Ogrenci_Yurt_Sistemi
{
    partial class FrmBölümler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBölümler));
            this.pictureKaydet = new System.Windows.Forms.PictureBox();
            this.picturesilme = new System.Windows.Forms.PictureBox();
            this.picturegüncelleme = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bölümIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümler1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet2 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDblm = new System.Windows.Forms.TextBox();
            this.textBoxBölümad = new System.Windows.Forms.TextBox();
            this.yurtKayıtSistemiDataSet1 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet1();
            this.yurtKayıtSistemiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bölümler1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet2TableAdapters.Bölümler1TableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegüncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bölümler1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureKaydet
            // 
            this.pictureKaydet.Image = ((System.Drawing.Image)(resources.GetObject("pictureKaydet.Image")));
            this.pictureKaydet.Location = new System.Drawing.Point(381, 13);
            this.pictureKaydet.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureKaydet.Name = "pictureKaydet";
            this.pictureKaydet.Size = new System.Drawing.Size(138, 73);
            this.pictureKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKaydet.TabIndex = 0;
            this.pictureKaydet.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureKaydet, "BÖLÜM EKLEME ");
            this.pictureKaydet.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picturesilme
            // 
            this.picturesilme.Image = ((System.Drawing.Image)(resources.GetObject("picturesilme.Image")));
            this.picturesilme.Location = new System.Drawing.Point(531, 13);
            this.picturesilme.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.picturesilme.Name = "picturesilme";
            this.picturesilme.Size = new System.Drawing.Size(135, 73);
            this.picturesilme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturesilme.TabIndex = 1;
            this.picturesilme.TabStop = false;
            this.toolTip1.SetToolTip(this.picturesilme, "BÖLÜM SİLME");
            this.picturesilme.Click += new System.EventHandler(this.picturesilme_Click);
            // 
            // picturegüncelleme
            // 
            this.picturegüncelleme.Image = ((System.Drawing.Image)(resources.GetObject("picturegüncelleme.Image")));
            this.picturegüncelleme.Location = new System.Drawing.Point(450, 94);
            this.picturegüncelleme.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.picturegüncelleme.Name = "picturegüncelleme";
            this.picturegüncelleme.Size = new System.Drawing.Size(139, 83);
            this.picturegüncelleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturegüncelleme.TabIndex = 2;
            this.picturegüncelleme.TabStop = false;
            this.toolTip1.SetToolTip(this.picturegüncelleme, "BÖLÜM GÜNCELLEME");
            this.picturegüncelleme.Click += new System.EventHandler(this.picturegüncelleme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bölümIdDataGridViewTextBoxColumn,
            this.bölümAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bölümler1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 308);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bölümIdDataGridViewTextBoxColumn
            // 
            this.bölümIdDataGridViewTextBoxColumn.DataPropertyName = "BölümId";
            this.bölümIdDataGridViewTextBoxColumn.HeaderText = "BölümId";
            this.bölümIdDataGridViewTextBoxColumn.Name = "bölümIdDataGridViewTextBoxColumn";
            this.bölümIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bölümIdDataGridViewTextBoxColumn.Width = 312;
            // 
            // bölümAdDataGridViewTextBoxColumn
            // 
            this.bölümAdDataGridViewTextBoxColumn.DataPropertyName = "BölümAd";
            this.bölümAdDataGridViewTextBoxColumn.HeaderText = "BölümAd";
            this.bölümAdDataGridViewTextBoxColumn.Name = "bölümAdDataGridViewTextBoxColumn";
            this.bölümAdDataGridViewTextBoxColumn.Width = 311;
            // 
            // bölümler1BindingSource
            // 
            this.bölümler1BindingSource.DataMember = "Bölümler1";
            this.bölümler1BindingSource.DataSource = this.yurtKayıtSistemiDataSet2;
            // 
            // yurtKayıtSistemiDataSet2
            // 
            this.yurtKayıtSistemiDataSet2.DataSetName = "YurtKayıtSistemiDataSet2";
            this.yurtKayıtSistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BÖLÜM ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "BÖLÜM AD:";
            // 
            // textBoxIDblm
            // 
            this.textBoxIDblm.Location = new System.Drawing.Point(143, 22);
            this.textBoxIDblm.Multiline = true;
            this.textBoxIDblm.Name = "textBoxIDblm";
            this.textBoxIDblm.Size = new System.Drawing.Size(220, 31);
            this.textBoxIDblm.TabIndex = 1;
            // 
            // textBoxBölümad
            // 
            this.textBoxBölümad.Location = new System.Drawing.Point(143, 81);
            this.textBoxBölümad.Multiline = true;
            this.textBoxBölümad.Name = "textBoxBölümad";
            this.textBoxBölümad.Size = new System.Drawing.Size(220, 29);
            this.textBoxBölümad.TabIndex = 2;
            // 
            // yurtKayıtSistemiDataSet1
            // 
            this.yurtKayıtSistemiDataSet1.DataSetName = "YurtKayıtSistemiDataSet1";
            this.yurtKayıtSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtKayıtSistemiDataSet1BindingSource
            // 
            this.yurtKayıtSistemiDataSet1BindingSource.DataSource = this.yurtKayıtSistemiDataSet1;
            this.yurtKayıtSistemiDataSet1BindingSource.Position = 0;
            // 
            // bölümler1TableAdapter
            // 
            this.bölümler1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmBölümler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 500);
            this.Controls.Add(this.textBoxBölümad);
            this.Controls.Add(this.textBoxIDblm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picturegüncelleme);
            this.Controls.Add(this.picturesilme);
            this.Controls.Add(this.pictureKaydet);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "FrmBölümler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÖLÜMLER";
            this.Load += new System.EventHandler(this.FrmBölümler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegüncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bölümler1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureKaydet;
        private System.Windows.Forms.PictureBox picturesilme;
        private System.Windows.Forms.PictureBox picturegüncelleme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDblm;
        private System.Windows.Forms.TextBox textBoxBölümad;
        private YurtKayıtSistemiDataSet1 yurtKayıtSistemiDataSet1;
        private System.Windows.Forms.BindingSource yurtKayıtSistemiDataSet1BindingSource;
        private YurtKayıtSistemiDataSet2 yurtKayıtSistemiDataSet2;
        private System.Windows.Forms.BindingSource bölümler1BindingSource;
        private YurtKayıtSistemiDataSet2TableAdapters.Bölümler1TableAdapter bölümler1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}