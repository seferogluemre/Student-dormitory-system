namespace Ogrenci_Yurt_Sistemi
{
    partial class frmnotekleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnotekleme));
            this.buttonkydt = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonkydt
            // 
            this.buttonkydt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonkydt.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonkydt.Location = new System.Drawing.Point(185, 434);
            this.buttonkydt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonkydt.Name = "buttonkydt";
            this.buttonkydt.Size = new System.Drawing.Size(387, 52);
            this.buttonkydt.TabIndex = 0;
            this.buttonkydt.Text = "KAYDET";
            this.buttonkydt.UseVisualStyleBackColor = true;
            this.buttonkydt.Click += new System.EventHandler(this.buttonkydt_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(735, 425);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // frmnotekleme
            // 
            this.AcceptButton = this.buttonkydt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 487);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonkydt);
            this.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmnotekleme";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT EKLEME";
            this.Load += new System.EventHandler(this.frmnotekleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonkydt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}