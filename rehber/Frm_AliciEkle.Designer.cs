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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtAliciAra = new Telerik.WinControls.UI.RadTextBox();
            this.chkTumunuSec = new Telerik.WinControls.UI.RadCheckBox();
            this.btnIptal = new Telerik.WinControls.UI.RadButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAliciSec = new Telerik.WinControls.UI.RadButton();
            this.chkLstKisiler = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliciAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTumunuSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIptal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAliciSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtAliciAra);
            this.radGroupBox1.Controls.Add(this.chkTumunuSec);
            this.radGroupBox1.Controls.Add(this.btnIptal);
            this.radGroupBox1.Controls.Add(this.label14);
            this.radGroupBox1.Controls.Add(this.btnAliciSec);
            this.radGroupBox1.Controls.Add(this.chkLstKisiler);
            this.radGroupBox1.HeaderText = "Alıcı Seçiniz";
            this.radGroupBox1.Location = new System.Drawing.Point(37, 27);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(340, 460);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Alıcı Seçiniz";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // txtAliciAra
            // 
            this.txtAliciAra.Location = new System.Drawing.Point(99, 33);
            this.txtAliciAra.Name = "txtAliciAra";
            this.txtAliciAra.Size = new System.Drawing.Size(187, 22);
            this.txtAliciAra.TabIndex = 1;
            this.txtAliciAra.ThemeName = "TelerikMetro";
            this.txtAliciAra.TextChanged += new System.EventHandler(this.txtAliciAra_TextChanged);
            // 
            // chkTumunuSec
            // 
            this.chkTumunuSec.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTumunuSec.Location = new System.Drawing.Point(52, 82);
            this.chkTumunuSec.Name = "chkTumunuSec";
            // 
            // 
            // 
            this.chkTumunuSec.RootElement.StretchHorizontally = true;
            this.chkTumunuSec.RootElement.StretchVertically = true;
            this.chkTumunuSec.Size = new System.Drawing.Size(95, 22);
            this.chkTumunuSec.TabIndex = 2;
            this.chkTumunuSec.Text = "Tümünü Seç!";
            this.chkTumunuSec.ThemeName = "TelerikMetro";
            this.chkTumunuSec.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkTumunuSec_ToggleStateChanged);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnIptal.Location = new System.Drawing.Point(52, 399);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(81, 34);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.ThemeName = "TelerikMetro";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label14.Location = new System.Drawing.Point(48, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "ARA    :";
            // 
            // btnAliciSec
            // 
            this.btnAliciSec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAliciSec.Font = new System.Drawing.Font("Buxton Sketch", 16F);
            this.btnAliciSec.Location = new System.Drawing.Point(197, 384);
            this.btnAliciSec.Name = "btnAliciSec";
            this.btnAliciSec.Size = new System.Drawing.Size(90, 49);
            this.btnAliciSec.TabIndex = 5;
            this.btnAliciSec.Text = "Seç";
            this.btnAliciSec.ThemeName = "TelerikMetro";
            this.btnAliciSec.Click += new System.EventHandler(this.btnAliciSec_Click);
            // 
            // chkLstKisiler
            // 
            this.chkLstKisiler.FormattingEnabled = true;
            this.chkLstKisiler.HorizontalScrollbar = true;
            this.chkLstKisiler.Location = new System.Drawing.Point(52, 110);
            this.chkLstKisiler.Name = "chkLstKisiler";
            this.chkLstKisiler.Size = new System.Drawing.Size(235, 259);
            this.chkLstKisiler.TabIndex = 3;
            // 
            // Frm_AliciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 510);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Frm_AliciEkle";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Alıcı Seç";
            this.Load += new System.EventHandler(this.Frm_AliciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliciAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTumunuSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIptal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAliciSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtAliciAra;
        private Telerik.WinControls.UI.RadCheckBox chkTumunuSec;
        private Telerik.WinControls.UI.RadButton btnIptal;
        private System.Windows.Forms.Label label14;
        private Telerik.WinControls.UI.RadButton btnAliciSec;
        private System.Windows.Forms.CheckedListBox chkLstKisiler;




    }
}