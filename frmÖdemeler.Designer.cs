namespace Ogrenci_Yurt_Sistemi
{
    partial class frmÖdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÖdemeler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxÖgrId = new System.Windows.Forms.TextBox();
            this.textbxÖgrad = new System.Windows.Forms.TextBox();
            this.textboxÖgrsoyad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ögrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrKalanBorçDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borçlar1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet4 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet4();
            this.butonÖdemeal = new System.Windows.Forms.Button();
            this.borçlar1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet4TableAdapters.Borçlar1TableAdapter();
            this.txtKalanborç = new System.Windows.Forms.TextBox();
            this.textBoxÖdenen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxÖdenenAY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borçlar1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖGRENCİ ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(84, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD";
            // 
            // textBoxÖgrId
            // 
            this.textBoxÖgrId.Location = new System.Drawing.Point(121, 42);
            this.textBoxÖgrId.Multiline = true;
            this.textBoxÖgrId.Name = "textBoxÖgrId";
            this.textBoxÖgrId.Size = new System.Drawing.Size(216, 27);
            this.textBoxÖgrId.TabIndex = 1;
            // 
            // textbxÖgrad
            // 
            this.textbxÖgrad.Location = new System.Drawing.Point(121, 91);
            this.textbxÖgrad.Multiline = true;
            this.textbxÖgrad.Name = "textbxÖgrad";
            this.textbxÖgrad.Size = new System.Drawing.Size(216, 27);
            this.textbxÖgrad.TabIndex = 2;
            // 
            // textboxÖgrsoyad
            // 
            this.textboxÖgrsoyad.Location = new System.Drawing.Point(121, 148);
            this.textboxÖgrsoyad.Multiline = true;
            this.textboxÖgrsoyad.Name = "textboxÖgrsoyad";
            this.textboxÖgrsoyad.Size = new System.Drawing.Size(216, 27);
            this.textboxÖgrsoyad.TabIndex = 3;
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
            this.ögrKalanBorçDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borçlar1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(362, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 404);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ögrIdDataGridViewTextBoxColumn
            // 
            this.ögrIdDataGridViewTextBoxColumn.DataPropertyName = "ÖgrId";
            this.ögrIdDataGridViewTextBoxColumn.HeaderText = "ÖgrId";
            this.ögrIdDataGridViewTextBoxColumn.Name = "ögrIdDataGridViewTextBoxColumn";
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
            // ögrKalanBorçDataGridViewTextBoxColumn
            // 
            this.ögrKalanBorçDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ögrKalanBorçDataGridViewTextBoxColumn.DataPropertyName = "ÖgrKalanBorç";
            this.ögrKalanBorçDataGridViewTextBoxColumn.HeaderText = "ÖgrKalanBorç";
            this.ögrKalanBorçDataGridViewTextBoxColumn.Name = "ögrKalanBorçDataGridViewTextBoxColumn";
            // 
            // borçlar1BindingSource
            // 
            this.borçlar1BindingSource.DataMember = "Borçlar1";
            this.borçlar1BindingSource.DataSource = this.yurtKayıtSistemiDataSet4;
            // 
            // yurtKayıtSistemiDataSet4
            // 
            this.yurtKayıtSistemiDataSet4.DataSetName = "YurtKayıtSistemiDataSet4";
            this.yurtKayıtSistemiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butonÖdemeal
            // 
            this.butonÖdemeal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butonÖdemeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonÖdemeal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butonÖdemeal.Location = new System.Drawing.Point(170, 343);
            this.butonÖdemeal.Name = "butonÖdemeal";
            this.butonÖdemeal.Size = new System.Drawing.Size(133, 37);
            this.butonÖdemeal.TabIndex = 6;
            this.butonÖdemeal.Text = "ÖDEME AL";
            this.butonÖdemeal.UseVisualStyleBackColor = false;
            this.butonÖdemeal.Click += new System.EventHandler(this.butonÖdemeal_Click);
            // 
            // borçlar1TableAdapter
            // 
            this.borçlar1TableAdapter.ClearBeforeFill = true;
            // 
            // txtKalanborç
            // 
            this.txtKalanborç.Location = new System.Drawing.Point(121, 247);
            this.txtKalanborç.Multiline = true;
            this.txtKalanborç.Name = "txtKalanborç";
            this.txtKalanborç.Size = new System.Drawing.Size(216, 27);
            this.txtKalanborç.TabIndex = 5;
            // 
            // textBoxÖdenen
            // 
            this.textBoxÖdenen.Location = new System.Drawing.Point(121, 198);
            this.textBoxÖdenen.Multiline = true;
            this.textBoxÖdenen.Name = "textBoxÖdenen";
            this.textBoxÖdenen.Size = new System.Drawing.Size(216, 27);
            this.textBoxÖdenen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(2, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "KALAN BORÇ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(31, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "ÖDENEN:";
            // 
            // textBoxÖdenenAY
            // 
            this.textBoxÖdenenAY.Location = new System.Drawing.Point(121, 299);
            this.textBoxÖdenenAY.Multiline = true;
            this.textBoxÖdenenAY.Name = "textBoxÖdenenAY";
            this.textBoxÖdenenAY.Size = new System.Drawing.Size(216, 27);
            this.textBoxÖdenenAY.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(2, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "ÖDENEN AY";
            // 
            // frmÖdemeler
            // 
            this.AcceptButton = this.butonÖdemeal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 404);
            this.Controls.Add(this.textBoxÖdenenAY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKalanborç);
            this.Controls.Add(this.textBoxÖdenen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butonÖdemeal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textboxÖgrsoyad);
            this.Controls.Add(this.textbxÖgrad);
            this.Controls.Add(this.textBoxÖgrId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmÖdemeler";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÖDEMELER";
            this.Load += new System.EventHandler(this.frmÖdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borçlar1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxÖgrId;
        private System.Windows.Forms.TextBox textbxÖgrad;
        private System.Windows.Forms.TextBox textboxÖgrsoyad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butonÖdemeal;
        private YurtKayıtSistemiDataSet4 yurtKayıtSistemiDataSet4;
        private System.Windows.Forms.BindingSource borçlar1BindingSource;
        private YurtKayıtSistemiDataSet4TableAdapters.Borçlar1TableAdapter borçlar1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrKalanBorçDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtKalanborç;
        private System.Windows.Forms.TextBox textBoxÖdenen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxÖdenenAY;
        private System.Windows.Forms.Label label6;
    }
}