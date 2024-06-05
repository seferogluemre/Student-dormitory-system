namespace Ogrenci_Yurt_Sistemi
{
    partial class frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.textBoxyöneticiıd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyöneticipaorla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxyntckullancııad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yöneticiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiŞifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtSistemiDataSet7 = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet7();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.admin1TableAdapter = new Ogrenci_Yurt_Sistemi.YurtKayıtSistemiDataSet7TableAdapters.Admin1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxyöneticiıd
            // 
            this.textBoxyöneticiıd.BackColor = System.Drawing.Color.White;
            this.textBoxyöneticiıd.Enabled = false;
            this.textBoxyöneticiıd.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxyöneticiıd.Location = new System.Drawing.Point(159, 12);
            this.textBoxyöneticiıd.Multiline = true;
            this.textBoxyöneticiıd.Name = "textBoxyöneticiıd";
            this.textBoxyöneticiıd.Size = new System.Drawing.Size(260, 25);
            this.textBoxyöneticiıd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "YÖNETİCİ ID:";
            // 
            // txtyöneticipaorla
            // 
            this.txtyöneticipaorla.BackColor = System.Drawing.Color.White;
            this.txtyöneticipaorla.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyöneticipaorla.Location = new System.Drawing.Point(159, 96);
            this.txtyöneticipaorla.Multiline = true;
            this.txtyöneticipaorla.Name = "txtyöneticipaorla";
            this.txtyöneticipaorla.Size = new System.Drawing.Size(260, 25);
            this.txtyöneticipaorla.TabIndex = 3;
            this.txtyöneticipaorla.MouseEnter += new System.EventHandler(this.txtyöneticipaorla_MouseEnter);
            this.txtyöneticipaorla.MouseLeave += new System.EventHandler(this.txtyöneticipaorla_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "PAROLA:";
            // 
            // txtboxyntckullancııad
            // 
            this.txtboxyntckullancııad.BackColor = System.Drawing.Color.White;
            this.txtboxyntckullancııad.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxyntckullancııad.Location = new System.Drawing.Point(159, 54);
            this.txtboxyntckullancııad.Multiline = true;
            this.txtboxyntckullancııad.Name = "txtboxyntckullancııad";
            this.txtboxyntckullancııad.Size = new System.Drawing.Size(260, 25);
            this.txtboxyntckullancııad.TabIndex = 2;
            this.txtboxyntckullancııad.MouseEnter += new System.EventHandler(this.txtboxyntckullancııad_MouseEnter);
            this.txtboxyntckullancııad.MouseLeave += new System.EventHandler(this.txtboxyntckullancııad_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yöneticiIDDataGridViewTextBoxColumn,
            this.yöneticiAdDataGridViewTextBoxColumn,
            this.yöneticiŞifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.admin1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 213);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yöneticiIDDataGridViewTextBoxColumn
            // 
            this.yöneticiIDDataGridViewTextBoxColumn.DataPropertyName = "YöneticiID";
            this.yöneticiIDDataGridViewTextBoxColumn.HeaderText = "YöneticiID";
            this.yöneticiIDDataGridViewTextBoxColumn.Name = "yöneticiIDDataGridViewTextBoxColumn";
            this.yöneticiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yöneticiAdDataGridViewTextBoxColumn
            // 
            this.yöneticiAdDataGridViewTextBoxColumn.DataPropertyName = "YöneticiAd";
            this.yöneticiAdDataGridViewTextBoxColumn.HeaderText = "YöneticiAd";
            this.yöneticiAdDataGridViewTextBoxColumn.Name = "yöneticiAdDataGridViewTextBoxColumn";
            // 
            // yöneticiŞifreDataGridViewTextBoxColumn
            // 
            this.yöneticiŞifreDataGridViewTextBoxColumn.DataPropertyName = "YöneticiŞifre";
            this.yöneticiŞifreDataGridViewTextBoxColumn.HeaderText = "YöneticiŞifre";
            this.yöneticiŞifreDataGridViewTextBoxColumn.Name = "yöneticiŞifreDataGridViewTextBoxColumn";
            // 
            // admin1BindingSource
            // 
            this.admin1BindingSource.DataMember = "Admin1";
            this.admin1BindingSource.DataSource = this.yurtKayıtSistemiDataSet7;
            // 
            // yurtKayıtSistemiDataSet7
            // 
            this.yurtKayıtSistemiDataSet7.DataSetName = "YurtKayıtSistemiDataSet7";
            this.yurtKayıtSistemiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(25, 150);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(116, 37);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsil.Location = new System.Drawing.Point(173, 150);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(116, 37);
            this.buttonsil.TabIndex = 5;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttongüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttongüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongüncelle.Location = new System.Drawing.Point(313, 150);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(116, 37);
            this.buttongüncelle.TabIndex = 6;
            this.buttongüncelle.Text = "GÜNCELLE";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // admin1TableAdapter
            // 
            this.admin1TableAdapter.ClearBeforeFill = true;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(455, 435);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxyöneticiıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyöneticipaorla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxyntckullancııad);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ PANEL";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtSistemiDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxyöneticiıd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyöneticipaorla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxyntckullancııad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttongüncelle;
        private YurtKayıtSistemiDataSet7 yurtKayıtSistemiDataSet7;
        private System.Windows.Forms.BindingSource admin1BindingSource;
        private YurtKayıtSistemiDataSet7TableAdapters.Admin1TableAdapter admin1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiŞifreDataGridViewTextBoxColumn;
    }
}