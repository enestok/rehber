namespace rehber
{
    partial class FrmChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSifreGosterYeniTekrar = new Telerik.WinControls.UI.RadToggleButton();
            this.btnSifreGosterYeni = new Telerik.WinControls.UI.RadToggleButton();
            this.btnSifreGosterEski = new Telerik.WinControls.UI.RadToggleButton();
            this.lblKullanici = new Telerik.WinControls.UI.RadLabel();
            this.txtSifreChangeEski = new Telerik.WinControls.UI.RadTextBox();
            this.txtSifreChangeYeni = new Telerik.WinControls.UI.RadTextBox();
            this.txtSifreChangeYeniTekrar = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifreChange = new Telerik.WinControls.UI.RadButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGosterYeniTekrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGosterYeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGosterEski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeEski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeniTekrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eski Şifre";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSifreGosterYeniTekrar);
            this.panel1.Controls.Add(this.btnSifreGosterYeni);
            this.panel1.Controls.Add(this.btnSifreGosterEski);
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.txtSifreChangeEski);
            this.panel1.Controls.Add(this.txtSifreChangeYeni);
            this.panel1.Controls.Add(this.txtSifreChangeYeniTekrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 211);
            this.panel1.TabIndex = 2;
            // 
            // btnSifreGosterYeniTekrar
            // 
            this.btnSifreGosterYeniTekrar.Image = global::rehber.image.SeePassword2;
            this.btnSifreGosterYeniTekrar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifreGosterYeniTekrar.Location = new System.Drawing.Point(447, 140);
            this.btnSifreGosterYeniTekrar.Name = "btnSifreGosterYeniTekrar";
            this.btnSifreGosterYeniTekrar.Size = new System.Drawing.Size(26, 24);
            this.btnSifreGosterYeniTekrar.TabIndex = 7;
            this.btnSifreGosterYeniTekrar.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btnSifreGosterYeniTekrar_ToggleStateChanged);
            // 
            // btnSifreGosterYeni
            // 
            this.btnSifreGosterYeni.Image = global::rehber.image.SeePassword2;
            this.btnSifreGosterYeni.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifreGosterYeni.Location = new System.Drawing.Point(447, 102);
            this.btnSifreGosterYeni.Name = "btnSifreGosterYeni";
            this.btnSifreGosterYeni.Size = new System.Drawing.Size(26, 24);
            this.btnSifreGosterYeni.TabIndex = 6;
            this.btnSifreGosterYeni.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btnSifreGosterYeni_ToggleStateChanged);
            // 
            // btnSifreGosterEski
            // 
            this.btnSifreGosterEski.Image = global::rehber.image.SeePassword2;
            this.btnSifreGosterEski.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifreGosterEski.Location = new System.Drawing.Point(447, 64);
            this.btnSifreGosterEski.Name = "btnSifreGosterEski";
            this.btnSifreGosterEski.Size = new System.Drawing.Size(26, 24);
            this.btnSifreGosterEski.TabIndex = 5;
            this.btnSifreGosterEski.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.btnSifreGosterEski_ToggleStateChanged);
            // 
            // lblKullanici
            // 
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblKullanici.Location = new System.Drawing.Point(167, 29);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(73, 23);
            this.lblKullanici.TabIndex = 11;
            this.lblKullanici.Text = "radLabel1";
            // 
            // txtSifreChangeEski
            // 
            this.txtSifreChangeEski.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifreChangeEski.Location = new System.Drawing.Point(167, 64);
            this.txtSifreChangeEski.Name = "txtSifreChangeEski";
            this.txtSifreChangeEski.PasswordChar = '*';
            this.txtSifreChangeEski.Size = new System.Drawing.Size(274, 24);
            this.txtSifreChangeEski.TabIndex = 0;
            this.txtSifreChangeEski.ThemeName = "TelerikMetro";
             // 
            // txtSifreChangeYeni
            // 
            this.txtSifreChangeYeni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifreChangeYeni.Location = new System.Drawing.Point(167, 102);
            this.txtSifreChangeYeni.Name = "txtSifreChangeYeni";
            this.txtSifreChangeYeni.PasswordChar = '*';
            this.txtSifreChangeYeni.Size = new System.Drawing.Size(274, 24);
            this.txtSifreChangeYeni.TabIndex = 1;
            this.txtSifreChangeYeni.ThemeName = "TelerikMetro";
           // 
            // txtSifreChangeYeniTekrar
            // 
            this.txtSifreChangeYeniTekrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifreChangeYeniTekrar.Location = new System.Drawing.Point(167, 141);
            this.txtSifreChangeYeniTekrar.Name = "txtSifreChangeYeniTekrar";
            this.txtSifreChangeYeniTekrar.PasswordChar = '*';
            this.txtSifreChangeYeniTekrar.Size = new System.Drawing.Size(274, 24);
            this.txtSifreChangeYeniTekrar.TabIndex = 2;
            this.txtSifreChangeYeniTekrar.ThemeName = "TelerikMetro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yeni Şifre Tekrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnSifreChange
            // 
            this.btnSifreChange.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnSifreChange.Location = new System.Drawing.Point(386, 263);
            this.btnSifreChange.Name = "btnSifreChange";
            this.btnSifreChange.Size = new System.Drawing.Size(129, 64);
            this.btnSifreChange.TabIndex = 3;
            this.btnSifreChange.Text = "Değiştir";
            this.btnSifreChange.ThemeName = "TelerikMetro";
            this.btnSifreChange.Click += new System.EventHandler(this.btnSifreChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(148, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(148, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(148, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(148, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 359);
            this.Controls.Add(this.btnSifreChange);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChangePassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGosterYeniTekrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGosterYeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreGosterEski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeEski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeniTekrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtSifreChangeEski;
        private Telerik.WinControls.UI.RadTextBox txtSifreChangeYeni;
        private Telerik.WinControls.UI.RadTextBox txtSifreChangeYeniTekrar;
        private Telerik.WinControls.UI.RadButton btnSifreChange;
        private Telerik.WinControls.UI.RadLabel lblKullanici;
        private Telerik.WinControls.UI.RadToggleButton btnSifreGosterEski;
        private Telerik.WinControls.UI.RadToggleButton btnSifreGosterYeniTekrar;
        private Telerik.WinControls.UI.RadToggleButton btnSifreGosterYeni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}