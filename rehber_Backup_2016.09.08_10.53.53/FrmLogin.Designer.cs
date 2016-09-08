namespace rehber
{
    partial class FrmLogin
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
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.chkBeniHatirla = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSifreGoster = new Telerik.WinControls.UI.RadButton();
            this.txtKullaniciAdi = new Telerik.WinControls.UI.RadTextBox();
            this.txtSifre = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitOlDialog = new Telerik.WinControls.UI.RadButton();
            this.btnGiris = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeniHatirla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKayitOlDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.chkBeniHatirla);
            this.radPanel1.Controls.Add(this.btnSifreGoster);
            this.radPanel1.Controls.Add(this.txtKullaniciAdi);
            this.radPanel1.Controls.Add(this.txtSifre);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Location = new System.Drawing.Point(40, 37);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(389, 154);
            this.radPanel1.TabIndex = 3;
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.Location = new System.Drawing.Point(160, 98);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            // 
            // 
            // 
            this.chkBeniHatirla.RootElement.StretchHorizontally = true;
            this.chkBeniHatirla.RootElement.StretchVertically = true;
            this.chkBeniHatirla.Size = new System.Drawing.Size(81, 18);
            this.chkBeniHatirla.TabIndex = 12;
            this.chkBeniHatirla.Text = "Beni Hatırla!";
            this.chkBeniHatirla.ThemeName = "Office2010Silver";
            // 
            // btnSifreGoster
            // 
            this.btnSifreGoster.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSifreGoster.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnSifreGoster.Image = global::rehber.image.SeePassword2;
            this.btnSifreGoster.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifreGoster.Location = new System.Drawing.Point(351, 68);
            this.btnSifreGoster.MaximumSize = new System.Drawing.Size(200, 200);
            this.btnSifreGoster.Name = "btnSifreGoster";
            // 
            // 
            // 
            this.btnSifreGoster.RootElement.MaxSize = new System.Drawing.Size(200, 200);
            this.btnSifreGoster.Size = new System.Drawing.Size(27, 27);
            this.btnSifreGoster.TabIndex = 1;
            this.btnSifreGoster.Tag = "";
            this.btnSifreGoster.ThemeName = "Office2010Silver";
            this.toolTip1.SetToolTip(this.btnSifreGoster, "Şifreyi Göster");
            this.btnSifreGoster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSifreGoster_MouseDown);
            this.btnSifreGoster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSifreGoster_MouseUp);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(156, 34);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(194, 24);
            this.txtKullaniciAdi.TabIndex = 10;
            this.txtKullaniciAdi.Text = "admin";
            this.txtKullaniciAdi.ThemeName = "Office2010Silver";
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(156, 70);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(194, 24);
            this.txtSifre.TabIndex = 11;
            this.txtSifre.Text = "admin";
            this.txtSifre.ThemeName = "Office2010Silver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre               :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı     :";
            // 
            // btnKayitOlDialog
            // 
            this.btnKayitOlDialog.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnKayitOlDialog.Location = new System.Drawing.Point(57, 205);
            this.btnKayitOlDialog.Name = "btnKayitOlDialog";
            this.btnKayitOlDialog.Size = new System.Drawing.Size(108, 38);
            this.btnKayitOlDialog.TabIndex = 4;
            this.btnKayitOlDialog.Text = "Kayıt Ol";
            this.btnKayitOlDialog.ThemeName = "Office2010Silver";
            this.btnKayitOlDialog.Click += new System.EventHandler(this.btnKayitOlDialog_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Buxton Sketch", 17F);
            this.btnGiris.Location = new System.Drawing.Point(307, 205);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(108, 43);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.ThemeName = "Office2010Silver";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnGiris);
            this.radGroupBox1.Controls.Add(this.btnKayitOlDialog);
            this.radGroupBox1.Controls.Add(this.radPanel1);
            this.radGroupBox1.HeaderText = "Kullanıcı Girişi";
            this.radGroupBox1.Location = new System.Drawing.Point(23, 19);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(463, 284);
            this.radGroupBox1.TabIndex = 6;
            this.radGroupBox1.Text = "Kullanıcı Girişi";
            this.radGroupBox1.ThemeName = "Office2010Silver";
            // 
            // radThemeManager1
            // 
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1});
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 327);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBeniHatirla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKayitOlDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadCheckBox chkBeniHatirla;
        private Telerik.WinControls.UI.RadTextBox txtKullaniciAdi;
        private Telerik.WinControls.UI.RadTextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnKayitOlDialog;
        private Telerik.WinControls.UI.RadButton btnGiris;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadButton btnSifreGoster;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}