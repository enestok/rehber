namespace rehber
{
    partial class Frm_ePostaOlustur
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddAttach = new System.Windows.Forms.Button();
            this.btnAliciEkle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtRichMesaj = new System.Windows.Forms.RichTextBox();
            this.txtGonderenMail = new Telerik.WinControls.UI.RadTextBox();
            this.txtAliciMail = new Telerik.WinControls.UI.RadTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lnkAliciTemizle = new System.Windows.Forms.LinkLabel();
            this.lnkAttachTumunuTemizle = new System.Windows.Forms.LinkLabel();
            this.selectedFilePanel1 = new rehber.SelectedFilePanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtGonderenSifre = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.txtKonu = new Telerik.WinControls.UI.RadMaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtGonderenMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliciMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGonderenSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Image = global::rehber.Properties.Resources.attachement;
            this.btnAddAttach.Location = new System.Drawing.Point(348, 174);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(64, 80);
            this.btnAddAttach.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnAddAttach, "Dosya Ekle..");
            this.btnAddAttach.UseVisualStyleBackColor = true;
            this.btnAddAttach.Click += new System.EventHandler(this.btnAddAttach_Click);
            // 
            // btnAliciEkle
            // 
            this.btnAliciEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnAliciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAliciEkle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAliciEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnAliciEkle.Image = global::rehber.Properties.Resources.iconAddd;
            this.btnAliciEkle.Location = new System.Drawing.Point(289, 87);
            this.btnAliciEkle.Name = "btnAliciEkle";
            this.btnAliciEkle.Size = new System.Drawing.Size(42, 42);
            this.btnAliciEkle.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAliciEkle, "Alıcı Ekle");
            this.btnAliciEkle.UseVisualStyleBackColor = false;
            this.btnAliciEkle.Click += new System.EventHandler(this.btnAliciEkle_Click);
            this.btnAliciEkle.MouseLeave += new System.EventHandler(this.btnAliciEkle_MouseLeave);
            this.btnAliciEkle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAliciEkle_MouseMove);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Image = global::rehber.Properties.Resources.sendOff;
            this.btnGonder.Location = new System.Drawing.Point(348, 58);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(80, 77);
            this.btnGonder.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnGonder, "Gönder");
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            this.btnGonder.MouseLeave += new System.EventHandler(this.btnGonder_MouseLeave);
            this.btnGonder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGonder_MouseMove);
            // 
            // txtRichMesaj
            // 
            this.txtRichMesaj.Location = new System.Drawing.Point(20, 54);
            this.txtRichMesaj.Name = "txtRichMesaj";
            this.txtRichMesaj.Size = new System.Drawing.Size(322, 196);
            this.txtRichMesaj.TabIndex = 21;
            this.txtRichMesaj.Text = "";
            this.toolTip1.SetToolTip(this.txtRichMesaj, "Mesaj Yaz");
            // 
            // txtGonderenMail
            // 
            this.txtGonderenMail.Location = new System.Drawing.Point(104, 69);
            this.txtGonderenMail.Name = "txtGonderenMail";
            this.txtGonderenMail.Size = new System.Drawing.Size(227, 22);
            this.txtGonderenMail.TabIndex = 2;
            this.txtGonderenMail.ThemeName = "TelerikMetro";
            // 
            // txtAliciMail
            // 
            this.txtAliciMail.Location = new System.Drawing.Point(104, 59);
            this.txtAliciMail.Name = "txtAliciMail";
            this.txtAliciMail.Size = new System.Drawing.Size(227, 22);
            this.txtAliciMail.TabIndex = 2;
            this.txtAliciMail.ThemeName = "TelerikMetro";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lnkAliciTemizle
            // 
            this.lnkAliciTemizle.AutoSize = true;
            this.lnkAliciTemizle.Location = new System.Drawing.Point(288, 43);
            this.lnkAliciTemizle.Name = "lnkAliciTemizle";
            this.lnkAliciTemizle.Size = new System.Drawing.Size(43, 13);
            this.lnkAliciTemizle.TabIndex = 18;
            this.lnkAliciTemizle.TabStop = true;
            this.lnkAliciTemizle.Text = "Temizle";
            this.lnkAliciTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAliciTemizle_LinkClicked);
            // 
            // lnkAttachTumunuTemizle
            // 
            this.lnkAttachTumunuTemizle.AutoSize = true;
            this.lnkAttachTumunuTemizle.Location = new System.Drawing.Point(291, 304);
            this.lnkAttachTumunuTemizle.Name = "lnkAttachTumunuTemizle";
            this.lnkAttachTumunuTemizle.Size = new System.Drawing.Size(43, 13);
            this.lnkAttachTumunuTemizle.TabIndex = 17;
            this.lnkAttachTumunuTemizle.TabStop = true;
            this.lnkAttachTumunuTemizle.Text = "Temizle";
            this.lnkAttachTumunuTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTumunuTemizle_LinkClicked);
            // 
            // selectedFilePanel1
            // 
            this.selectedFilePanel1.AutoScroll = true;
            this.selectedFilePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFilePanel1.Location = new System.Drawing.Point(33, 301);
            this.selectedFilePanel1.Name = "selectedFilePanel1";
            this.selectedFilePanel1.Size = new System.Drawing.Size(322, 131);
            this.selectedFilePanel1.TabIndex = 16;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.txtGonderenSifre);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.txtGonderenMail);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Gönderici";
            this.radGroupBox1.Location = new System.Drawing.Point(21, 44);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(353, 189);
            this.radGroupBox1.TabIndex = 18;
            this.radGroupBox1.Text = "Gönderici";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel3.Location = new System.Drawing.Point(84, 69);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(10, 19);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = ":";
            this.radLabel3.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // txtGonderenSifre
            // 
            this.txtGonderenSifre.Location = new System.Drawing.Point(104, 97);
            this.txtGonderenSifre.Name = "txtGonderenSifre";
            this.txtGonderenSifre.Size = new System.Drawing.Size(227, 22);
            this.txtGonderenSifre.TabIndex = 3;
            this.txtGonderenSifre.ThemeName = "TelerikMetro";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel4.Location = new System.Drawing.Point(84, 97);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(10, 19);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = ":";
            this.radLabel4.Click += new System.EventHandler(this.radLabel4_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel2.Location = new System.Drawing.Point(17, 97);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(33, 19);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Şifre";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel1.Location = new System.Drawing.Point(17, 69);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(31, 19);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Mail";
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btnAliciEkle);
            this.radGroupBox2.Controls.Add(this.lnkAliciTemizle);
            this.radGroupBox2.Controls.Add(this.txtAliciMail);
            this.radGroupBox2.Controls.Add(this.radLabel6);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.HeaderText = "Alıcı";
            this.radGroupBox2.Location = new System.Drawing.Point(21, 248);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(353, 163);
            this.radGroupBox2.TabIndex = 19;
            this.radGroupBox2.Text = "Alıcı";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel6.Location = new System.Drawing.Point(81, 62);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(10, 19);
            this.radLabel6.TabIndex = 1;
            this.radLabel6.Text = ":";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radLabel5.Location = new System.Drawing.Point(17, 62);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(57, 19);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Alıcı Mail";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.radPanel1);
            this.radGroupBox3.Controls.Add(this.lnkAttachTumunuTemizle);
            this.radGroupBox3.Controls.Add(this.selectedFilePanel1);
            this.radGroupBox3.HeaderText = "E - Posta Oluştur";
            this.radGroupBox3.Location = new System.Drawing.Point(393, 12);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(459, 447);
            this.radGroupBox3.TabIndex = 20;
            this.radGroupBox3.Text = "E - Posta Oluştur";
            this.radGroupBox3.ThemeName = "TelerikMetro";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.txtRichMesaj);
            this.radPanel1.Controls.Add(this.txtKonu);
            this.radPanel1.Controls.Add(this.btnGonder);
            this.radPanel1.Controls.Add(this.btnAddAttach);
            this.radPanel1.Location = new System.Drawing.Point(13, 28);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(433, 267);
            this.radPanel1.TabIndex = 22;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(20, 20);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.NullText = "Konu";
            this.txtKonu.Size = new System.Drawing.Size(322, 22);
            this.txtKonu.TabIndex = 19;
            this.txtKonu.TabStop = false;
            this.txtKonu.ThemeName = "TelerikMetro";
            // 
            // Frm_ePostaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(872, 475);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.MaximumSize = new System.Drawing.Size(880, 510);
            this.MinimumSize = new System.Drawing.Size(880, 510);
            this.Name = "Frm_ePostaOlustur";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(880, 510);
            this.Text = "E-Posta Yaz";
            this.Load += new System.EventHandler(this.Frm_ePostaOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGonderenMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliciMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGonderenSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnAliciEkle;
        private System.Windows.Forms.Button btnAddAttach;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private rehber.SelectedFilePanel selectedFilePanel1;
        private System.Windows.Forms.LinkLabel lnkAttachTumunuTemizle;
        private System.Windows.Forms.LinkLabel lnkAliciTemizle;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtGonderenSifre;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtGonderenMail;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox txtAliciMail;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadMaskedEditBox txtKonu;
        private System.Windows.Forms.RichTextBox txtRichMesaj;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}

