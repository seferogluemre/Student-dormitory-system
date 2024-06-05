namespace Ogrenci_Yurt_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtÖGRad = new System.Windows.Forms.TextBox();
            this.txtÖgrSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskÖgrTc = new System.Windows.Forms.MaskedTextBox();
            this.mskTELEFON = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskDOGUMtrh = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxÖGRBÖLÜM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMAİL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBOXODANO = new System.Windows.Forms.ComboBox();
            this.textBoxVeliADSOYAD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rchtxtAdres = new System.Windows.Forms.RichTextBox();
            this.butonKaydet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖGRENCİ KAYIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖGRENCİ İSİM:";
            // 
            // txtÖGRad
            // 
            this.txtÖGRad.BackColor = System.Drawing.SystemColors.Info;
            this.txtÖGRad.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÖGRad.Location = new System.Drawing.Point(160, 56);
            this.txtÖGRad.Multiline = true;
            this.txtÖGRad.Name = "txtÖGRad";
            this.txtÖGRad.Size = new System.Drawing.Size(283, 25);
            this.txtÖGRad.TabIndex = 1;
            // 
            // txtÖgrSoyad
            // 
            this.txtÖgrSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.txtÖgrSoyad.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÖgrSoyad.Location = new System.Drawing.Point(160, 104);
            this.txtÖgrSoyad.Multiline = true;
            this.txtÖgrSoyad.Name = "txtÖgrSoyad";
            this.txtÖgrSoyad.Size = new System.Drawing.Size(283, 25);
            this.txtÖgrSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(117, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC:";
            // 
            // mskÖgrTc
            // 
            this.mskÖgrTc.BackColor = System.Drawing.SystemColors.Info;
            this.mskÖgrTc.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskÖgrTc.Location = new System.Drawing.Point(160, 146);
            this.mskÖgrTc.Mask = "00000000000";
            this.mskÖgrTc.Name = "mskÖgrTc";
            this.mskÖgrTc.Size = new System.Drawing.Size(283, 25);
            this.mskÖgrTc.TabIndex = 3;
            // 
            // mskTELEFON
            // 
            this.mskTELEFON.BackColor = System.Drawing.SystemColors.Info;
            this.mskTELEFON.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTELEFON.Location = new System.Drawing.Point(160, 194);
            this.mskTELEFON.Mask = "(999) 000-0000";
            this.mskTELEFON.Name = "mskTELEFON";
            this.mskTELEFON.Size = new System.Drawing.Size(283, 25);
            this.mskTELEFON.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "DOGUM TARİHİ";
            // 
            // mskDOGUMtrh
            // 
            this.mskDOGUMtrh.BackColor = System.Drawing.SystemColors.Info;
            this.mskDOGUMtrh.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDOGUMtrh.Location = new System.Drawing.Point(160, 245);
            this.mskDOGUMtrh.Mask = "00/00/0000";
            this.mskDOGUMtrh.Name = "mskDOGUMtrh";
            this.mskDOGUMtrh.Size = new System.Drawing.Size(283, 25);
            this.mskDOGUMtrh.TabIndex = 5;
            this.mskDOGUMtrh.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "ÖGRENCİ BÖLÜM";
            // 
            // comboBoxÖGRBÖLÜM
            // 
            this.comboBoxÖGRBÖLÜM.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxÖGRBÖLÜM.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxÖGRBÖLÜM.FormattingEnabled = true;
            this.comboBoxÖGRBÖLÜM.Location = new System.Drawing.Point(156, 296);
            this.comboBoxÖGRBÖLÜM.Name = "comboBoxÖGRBÖLÜM";
            this.comboBoxÖGRBÖLÜM.Size = new System.Drawing.Size(283, 25);
            this.comboBoxÖGRBÖLÜM.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(97, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "MAİL:";
            // 
            // textBoxMAİL
            // 
            this.textBoxMAİL.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMAİL.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMAİL.Location = new System.Drawing.Point(160, 349);
            this.textBoxMAİL.Multiline = true;
            this.textBoxMAİL.Name = "textBoxMAİL";
            this.textBoxMAİL.Size = new System.Drawing.Size(283, 25);
            this.textBoxMAİL.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(78, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "ODA NO";
            // 
            // cmbBOXODANO
            // 
            this.cmbBOXODANO.BackColor = System.Drawing.SystemColors.Info;
            this.cmbBOXODANO.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBOXODANO.FormattingEnabled = true;
            this.cmbBOXODANO.Location = new System.Drawing.Point(160, 398);
            this.cmbBOXODANO.Name = "cmbBOXODANO";
            this.cmbBOXODANO.Size = new System.Drawing.Size(283, 25);
            this.cmbBOXODANO.TabIndex = 8;
            // 
            // textBoxVeliADSOYAD
            // 
            this.textBoxVeliADSOYAD.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxVeliADSOYAD.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVeliADSOYAD.Location = new System.Drawing.Point(160, 466);
            this.textBoxVeliADSOYAD.Multiline = true;
            this.textBoxVeliADSOYAD.Name = "textBoxVeliADSOYAD";
            this.textBoxVeliADSOYAD.Size = new System.Drawing.Size(283, 25);
            this.textBoxVeliADSOYAD.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "VELİ AD SOYAD";
            // 
            // mskVeliTelefon
            // 
            this.mskVeliTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.mskVeliTelefon.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskVeliTelefon.Location = new System.Drawing.Point(160, 519);
            this.mskVeliTelefon.Mask = "(999) 000-0000";
            this.mskVeliTelefon.Name = "mskVeliTelefon";
            this.mskVeliTelefon.Size = new System.Drawing.Size(283, 25);
            this.mskVeliTelefon.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(36, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "VELİ TELEFON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(80, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "ADRES:";
            // 
            // rchtxtAdres
            // 
            this.rchtxtAdres.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtAdres.Location = new System.Drawing.Point(160, 573);
            this.rchtxtAdres.Name = "rchtxtAdres";
            this.rchtxtAdres.Size = new System.Drawing.Size(292, 169);
            this.rchtxtAdres.TabIndex = 11;
            this.rchtxtAdres.Text = "";
            // 
            // butonKaydet
            // 
            this.butonKaydet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonKaydet.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonKaydet.Location = new System.Drawing.Point(235, 748);
            this.butonKaydet.Name = "butonKaydet";
            this.butonKaydet.Size = new System.Drawing.Size(130, 36);
            this.butonKaydet.TabIndex = 12;
            this.butonKaydet.Text = "KAYDET";
            this.butonKaydet.UseVisualStyleBackColor = false;
            this.butonKaydet.Click += new System.EventHandler(this.butonKaydet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(62, 637);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = ".";
            this.label13.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.butonKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(481, 796);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.butonKaydet);
            this.Controls.Add(this.rchtxtAdres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mskVeliTelefon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxVeliADSOYAD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbBOXODANO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMAİL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxÖGRBÖLÜM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskDOGUMtrh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTELEFON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskÖgrTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtÖgrSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtÖGRad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖGRENCİ KAYIT PANELİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtÖGRad;
        private System.Windows.Forms.TextBox txtÖgrSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskÖgrTc;
        private System.Windows.Forms.MaskedTextBox mskTELEFON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskDOGUMtrh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxÖGRBÖLÜM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMAİL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBOXODANO;
        private System.Windows.Forms.TextBox textBoxVeliADSOYAD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskVeliTelefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rchtxtAdres;
        private System.Windows.Forms.Button butonKaydet;
        private System.Windows.Forms.Label label13;
    }
}

