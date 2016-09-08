namespace rehber
{
    partial class Frm_AliciEkle
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
            this.chkLstKisiler = new System.Windows.Forms.CheckedListBox();
            this.chkTumunuSec = new System.Windows.Forms.CheckBox();
            this.btnAliciSec = new Telerik.WinControls.UI.RadButton();
            this.txtAliciAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLstKisiler
            // 
            this.chkLstKisiler.FormattingEnabled = true;
            this.chkLstKisiler.HorizontalScrollbar = true;
            this.chkLstKisiler.Location = new System.Drawing.Point(62, 114);
            this.chkLstKisiler.Name = "chkLstKisiler";
            this.chkLstKisiler.Size = new System.Drawing.Size(235, 259);
            this.chkLstKisiler.TabIndex = 6;
            // 
            // chkTumunuSec
            // 
            this.chkTumunuSec.AutoSize = true;
            this.chkTumunuSec.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.chkTumunuSec.ForeColor = System.Drawing.Color.Black;
            this.chkTumunuSec.Location = new System.Drawing.Point(62, 85);
            this.chkTumunuSec.Name = "chkTumunuSec";
            this.chkTumunuSec.Size = new System.Drawing.Size(92, 23);
            this.chkTumunuSec.TabIndex = 7;
            this.chkTumunuSec.Text = "Tümünü Seç";
            this.chkTumunuSec.UseVisualStyleBackColor = true;
            this.chkTumunuSec.CheckedChanged += new System.EventHandler(this.chkTumunuSec_CheckedChanged);
            // 
            // btnAliciSec
            // 
            this.btnAliciSec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAliciSec.Font = new System.Drawing.Font("Buxton Sketch", 14F);
            this.btnAliciSec.Location = new System.Drawing.Point(207, 388);
            this.btnAliciSec.Name = "btnAliciSec";
            this.btnAliciSec.Size = new System.Drawing.Size(90, 49);
            this.btnAliciSec.TabIndex = 8;
            this.btnAliciSec.Text = "Seç";
           // this.btnAliciSec.UseMnemonic = true;
            this.btnAliciSec.Click += new System.EventHandler(this.btnAliciSec_Click);
            // 
            // txtAliciAra
            // 
            this.txtAliciAra.Location = new System.Drawing.Point(117, 39);
            this.txtAliciAra.Name = "txtAliciAra";
            this.txtAliciAra.Size = new System.Drawing.Size(180, 20);
            this.txtAliciAra.TabIndex = 1;
            this.txtAliciAra.TextChanged += new System.EventHandler(this.txtAliciAra_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label14.Location = new System.Drawing.Point(58, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "ARA    :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAliciAra);
            this.groupBox1.Controls.Add(this.btnAliciSec);
            this.groupBox1.Controls.Add(this.chkTumunuSec);
            this.groupBox1.Controls.Add(this.chkLstKisiler);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı Seçiniz";
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Font = new System.Drawing.Font("Buxton Sketch", 14F);
            this.btnIptal.Location = new System.Drawing.Point(111, 396);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 33);
            this.btnIptal.TabIndex = 20;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // Frm_AliciEkle
            // 
            this.AcceptButton = this.btnAliciSec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 492);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_AliciEkle";
            this.Text = "AliciEkle";
            this.Load += new System.EventHandler(this.Frm_AliciEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkLstKisiler;
        private System.Windows.Forms.CheckBox chkTumunuSec;
        private Telerik.WinControls.UI.RadButton btnAliciSec;
        private System.Windows.Forms.TextBox txtAliciAra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;


    }
}