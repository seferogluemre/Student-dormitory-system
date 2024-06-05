namespace Ogrenci_Yurt_Sistemi
{
    partial class frmadmingiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmingiriş));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGiriş = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxparola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKullanıcıadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 223);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.buttonGiriş);
            this.groupBox2.Location = new System.Drawing.Point(92, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonGiriş
            // 
            this.buttonGiriş.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGiriş.BackgroundImage")));
            this.buttonGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGiriş.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGiriş.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiriş.Location = new System.Drawing.Point(121, 59);
            this.buttonGiriş.Name = "buttonGiriş";
            this.buttonGiriş.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.buttonGiriş.Size = new System.Drawing.Size(138, 53);
            this.buttonGiriş.TabIndex = 0;
            this.buttonGiriş.UseVisualStyleBackColor = false;
            this.buttonGiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 215);
            this.panel2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(447, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "ŞİFRE GİZLE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.textBoxparola);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxKullanıcıadı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(92, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxparola
            // 
            this.textBoxparola.BackColor = System.Drawing.Color.White;
            this.textBoxparola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxparola.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxparola.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxparola.Location = new System.Drawing.Point(146, 77);
            this.textBoxparola.Multiline = true;
            this.textBoxparola.Name = "textBoxparola";
            this.textBoxparola.Size = new System.Drawing.Size(197, 20);
            this.textBoxparola.TabIndex = 2;
            this.textBoxparola.MouseEnter += new System.EventHandler(this.textBoxparola_MouseEnter);
            this.textBoxparola.MouseLeave += new System.EventHandler(this.textBoxparola_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PAROLA:";
            // 
            // textBoxKullanıcıadı
            // 
            this.textBoxKullanıcıadı.BackColor = System.Drawing.Color.White;
            this.textBoxKullanıcıadı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKullanıcıadı.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullanıcıadı.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBoxKullanıcıadı.Location = new System.Drawing.Point(146, 25);
            this.textBoxKullanıcıadı.Multiline = true;
            this.textBoxKullanıcıadı.Name = "textBoxKullanıcıadı";
            this.textBoxKullanıcıadı.Size = new System.Drawing.Size(197, 20);
            this.textBoxKullanıcıadı.TabIndex = 1;
            this.textBoxKullanıcıadı.MouseEnter += new System.EventHandler(this.textBoxKullanıcıadı_MouseEnter);
            this.textBoxKullanıcıadı.MouseLeave += new System.EventHandler(this.textBoxKullanıcıadı_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // frmadmingiriş
            // 
            this.AcceptButton = this.buttonGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(581, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmadmingiriş";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKullanıcıadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxparola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGiriş;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}