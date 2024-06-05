namespace Ogrenci_Yurt_Sistemi
{
    partial class frmpersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet8 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet8();
            this.txtbxpersongörev = new System.Windows.Forms.TextBox();
            this.txtbxpersonad = new System.Windows.Forms.TextBox();
            this.txtbxPersonID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.personel1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet8TableAdapters.Personel1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personel1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            this.personelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personel1BindingSource
            // 
            this.personel1BindingSource.DataMember = "Personel1";
            this.personel1BindingSource.DataSource = this.yurtKayıtSistemiDataSet8;
            // 
            // yurtKayıtSistemiDataSet8
            // 
            this.yurtKayıtSistemiDataSet8.DataSetName = "YurtKayıtSistemiDataSet8";
            this.yurtKayıtSistemiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbxpersongörev
            // 
            this.txtbxpersongörev.Location = new System.Drawing.Point(201, 97);
            this.txtbxpersongörev.Multiline = true;
            this.txtbxpersongörev.Name = "txtbxpersongörev";
            this.txtbxpersongörev.Size = new System.Drawing.Size(216, 27);
            this.txtbxpersongörev.TabIndex = 3;
            this.txtbxpersongörev.MouseEnter += new System.EventHandler(this.txtbxpersongörev_MouseEnter);
            this.txtbxpersongörev.MouseLeave += new System.EventHandler(this.txtbxpersongörev_MouseLeave);
            // 
            // txtbxpersonad
            // 
            this.txtbxpersonad.Location = new System.Drawing.Point(201, 55);
            this.txtbxpersonad.Multiline = true;
            this.txtbxpersonad.Name = "txtbxpersonad";
            this.txtbxpersonad.Size = new System.Drawing.Size(216, 27);
            this.txtbxpersonad.TabIndex = 2;
            this.txtbxpersonad.MouseEnter += new System.EventHandler(this.txtbxpersonad_MouseEnter);
            this.txtbxpersonad.MouseLeave += new System.EventHandler(this.txtbxpersonad_MouseLeave);
            // 
            // txtbxPersonID
            // 
            this.txtbxPersonID.Location = new System.Drawing.Point(201, 12);
            this.txtbxPersonID.Multiline = true;
            this.txtbxPersonID.Name = "txtbxPersonID";
            this.txtbxPersonID.Size = new System.Drawing.Size(216, 27);
            this.txtbxPersonID.TabIndex = 1;
            this.txtbxPersonID.MouseEnter += new System.EventHandler(this.textBoxÖgrId_MouseEnter);
            this.txtbxPersonID.MouseLeave += new System.EventHandler(this.txtbxPersonID_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(46, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "PERSONEL GÖREVİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(79, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PERSONEL AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "PERSONEL ID:";
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttongüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttongüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongüncelle.Location = new System.Drawing.Point(341, 155);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(116, 37);
            this.buttongüncelle.TabIndex = 6;
            this.buttongüncelle.Text = "GÜNCELLE";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsil.Location = new System.Drawing.Point(201, 155);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(116, 37);
            this.buttonsil.TabIndex = 5;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(53, 155);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(116, 37);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // personel1TableAdapter
            // 
            this.personel1TableAdapter.ClearBeforeFill = true;
            // 
            // frmpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 453);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.txtbxpersongörev);
            this.Controls.Add(this.txtbxpersonad);
            this.Controls.Add(this.txtbxPersonID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmpersonel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmpersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbxpersongörev;
        private System.Windows.Forms.TextBox txtbxpersonad;
        private System.Windows.Forms.TextBox txtbxPersonID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttongüncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonKaydet;
        private YurtKayıtSistemiDataSet8 yurtKayıtSistemiDataSet8;
        private System.Windows.Forms.BindingSource personel1BindingSource;
        private YurtKayıtSistemiDataSet8TableAdapters.Personel1TableAdapter personel1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}